using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Test.Forms;
using Test.Logic;
using Test.Models;
using Test.Validation;

namespace Test
{
    public partial class MainForm : CustomForm
    {
        private StorageFile[] StorageFilesCloud = Array.Empty<StorageFile>();
        private StorageFile[] StorageFilesLocal = Array.Empty<StorageFile>();
        private readonly Button[] NetworkButtons;
        private readonly Button[] StorageButtons;
        private readonly int maxFilesNumber = 10;

        public MainForm(bool autonomously = false)
        {
            InitializeComponent();

            listViewLocal.AllowDrop = listViewCloud.AllowDrop = true;

            listViewLocal.DragEnter += ListView_DragEnter;
            listViewLocal.DragDrop += ListViewLocal_DragDrop;

            listViewCloud.DragEnter += ListView_DragEnter;
            listViewCloud.DragDrop += ListViewCloud_DragDrop;

            StorageButtons = new Button[]
            {
                btnUpload,
                btnSynchronize,
                btnDownloadFile,
                btnMoveToCloud,
                btnUploadLocal,
                btnUploadHosting,
                btnClearCloudStorage,
                btnClearLocalStorage
            };
            NetworkButtons = new Button[]
            {
                btnAdmin,
                btnChangePassword,
            };

            btnAdmin.Visible = Config.IsAdmin;

            this.autonomously = autonomously;
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            var picture = new PictureBox
            {
                Width = Width,
                Height = Height,
                Location = new Point(0, 0),
                SizeMode = PictureBoxSizeMode.Zoom,
                Image = Properties.Resources.intro,
                BackColor = Color.FromArgb(30, 3, 36)
            };

            if (autonomously)
            {
                ToogleNetworkInterface();
                GetLocalFiles();
            }
            else
            {
                timer.Tick += Timer_Elapsed;
                timer.Start();

                Timer_Elapsed(null, null);
                GetFilesAsync();
            }

            Controls.Add(picture);
            picture.BringToFront();

            Task.Delay(3800).ContinueWith(_ => { picture.Dispose(); });
            picture.Dispose();
        }

        private string[] CheckFiles(string[] filePaths, bool local = true)
        {
            if (filePaths.Length > maxFilesNumber)
            {
                CustomBox.Show(countFileError);
                return Array.Empty<string>();
            }

            var errorsNames = string.Empty;
            for (int i = 0; i < filePaths.Length; i++)
            {
                if (!string.IsNullOrEmpty(filePaths[i]))
                {
                    var correct = CheckFileSize(filePaths[i]);
                    if (!correct)
                    {
                        errorsNames += $"  - {Path.GetFileName(filePaths[i])}\n";
                        filePaths[i] = string.Empty;
                    }
                }
            }

            if (!string.IsNullOrEmpty(errorsNames))
            {
                var messageText = $"Некоторые файлы не соответсвуют допустимому размеру(10мб) и не будут загружены. Продолжить?\n" +
                    $"Список файлов не корректного размера:\n{errorsNames}";

                var result = CustomBox.ShowDialog(messageText, typeBtn: TypeButton.YesNo);
                if (result == DialogResult.No)
                {
                    return Array.Empty<string>();
                }
            }

            string storage = "локальном";
            var replace = Settings.ReplaceInsertLocal;
            var storageFiles = StorageFilesLocal;
            if (!local)
            {
                storage = "облачном";
                replace = Settings.ReplaceInsertCloud;
                storageFiles = StorageFilesCloud;
            }

            if (!replace)
            {
                var cloudFiles = storageFiles.Select(x => x.Name);
                var filesNames = filePaths.Select(x => Path.GetFileName(x)).ToList();

                var intersect = cloudFiles.Intersect(filesNames).ToList();

                if (intersect.Count > 0)
                {
                    if (intersect.Count == 1)
                    {
                        var messageText = $"Файл с названием {intersect[0]} уже существует в {storage} хранилище. Заменить?";
                        var result = CustomBox.ShowDialog(messageText, typeBtn: TypeButton.YesNo);
                        if (result == DialogResult.No)
                        {
                            var index = filesNames.IndexOf(intersect[0]);
                            if (index > -1)
                            {
                                filePaths[index] = string.Empty;
                            }
                        }
                    }
                    else
                    {
                        for (int i = 0; i < intersect.Count; i++)
                        {
                            var files = "  - " + string.Join("\n  - ", intersect);

                            string text = $"Файл с названием {intersect[i]} уже существует в {storage} хранилище. Заменить?\n" +
                                $"Всего файлов для замены ({intersect.Count}):\n{files}";

                            var result = CustomBox.ShowDialog(text, typeBtn: TypeButton.YesAllNoAll);
                            if (result == DialogResult.Yes)
                            {
                                intersect.RemoveAt(i);
                                i--;
                            }
                            else if (result == DialogResult.OK)
                            {
                                break;
                            }
                            else if (result == DialogResult.No)
                            {
                                var index = filesNames.IndexOf(intersect[i]);
                                if (index > -1)
                                {
                                    filePaths[index] = filesNames[index] = string.Empty;
                                }
                                intersect.RemoveAt(i);
                                i--;
                            }
                            else if (result == DialogResult.Ignore)
                            {
                                for (int j = 0; j < intersect.Count; j++)
                                {
                                    var index = filesNames.IndexOf(intersect[j]);
                                    if (index > -1)
                                    {
                                        filePaths[index] = filesNames[index] = string.Empty;
                                    }
                                }
                                break;
                            }
                            else if (result == DialogResult.Cancel)
                            {
                                return Array.Empty<string>();
                            }
                        }
                    }
                }
            }

            return filePaths.Where(x => !string.IsNullOrEmpty(x)).ToArray();
        }

        private async void ListViewCloud_DragDrop(object sender, DragEventArgs e)
        {
            if (!InternetConnetion.Check())
            {
                SetNotInternet();
                return;
            }

            var filePathsList = ((string[])e.Data.GetData(DataFormats.FileDrop, false)).ToList();

            for (int i = 0; i < filePathsList.Count; i++)
            {
                if (!File.Exists(filePathsList[i]))
                {
                    filePathsList[i] = string.Empty;
                }
            }

            var filePaths = filePathsList.Where(x => !string.IsNullOrEmpty(x)).ToArray();

            var resultFiles = CheckFiles(filePaths, false);
            if (resultFiles.Length == 0)
            {
                return;
            }

            OnLoading();

            await FtpWebWorker.UploadFilesAsync(filePaths);

            await GetCloudFiles();

            if (Settings.DeleteInsert)
            {
                DeleteFiles(filePaths);
            }

            OffLoading();
        }

        private async void ListViewLocal_DragDrop(object sender, DragEventArgs e)
        {
            var filePathsList = ((string[])e.Data.GetData(DataFormats.FileDrop, false)).ToList();

            for (int i = 0; i < filePathsList.Count; i++)
            {
                if (!File.Exists(filePathsList[i]))
                {
                    filePathsList[i] = string.Empty;
                }
            }

            var filePaths = filePathsList.Where(x => !string.IsNullOrEmpty(x)).ToArray();

            var resultFiles = CheckFiles(filePaths);
            if (resultFiles.Length == 0)
            {
                return;
            }

            OnLoading();

            await LocalStorageWorker.AddFilesAsync(filePaths);

            await GetLocalFiles();

            if (Settings.DeleteInsert)
            {
                DeleteFiles(filePaths);
            }

            OffLoading();
        }

        private void ListView_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
            {
                e.Effect = DragDropEffects.All;
            }
            else
            {
                e.Effect = DragDropEffects.None;
            }
        }

        private bool connection = true;

        private void ToogleStorageInterface(bool enable = false)
        {
            if (connection)
            {
                for (int i = 0; i < StorageButtons.Length; i++)
                {
                    StorageButtons[i].Enabled = enable;
                }
                listViewLocal.AllowDrop = listViewCloud.AllowDrop = contextMenuStripCloud.Enabled = contextMenuStripLocal.Enabled = enable;
            }
            else
            {
                listViewLocal.AllowDrop = btnUploadLocal.Enabled = btnClearLocalStorage.Enabled = contextMenuStripLocal.Enabled = enable;
            }
        }

        private void ToogleNetworkInterface(bool enable = false)
        {
            connection = false;
            for (int i = 0; i < StorageButtons.Length; i++)
            {
                NetworkButtons[i].Enabled = enable;
            }
            for (int i = 0; i < NetworkButtons.Length; i++)
            {
                NetworkButtons[i].Enabled = enable;
            }
            contextMenuStripCloud.Enabled = enable;
            listViewCloud.AllowDrop = enable;
        }

        private void Timer_Elapsed(object sender, EventArgs e)
        {
            if (!InternetConnetion.Check())
            {
                SetNotInternet();
            }
        }

        private void SetNotInternet()
        {
            timer.Stop();
            var result = CustomBox.ShowDialog(this, "Нет подключения к интернету. Продолжить работу автономно?", typeBtn: TypeButton.YesNo);
            if (result == DialogResult.Yes)
            {
                ToogleNetworkInterface();
            }
            else
            {
                Application.Exit();
                Environment.Exit(0);
            }
        }

        private async Task GetFilesAsync()
        {
            var localTask = GetLocalFiles();
            var cloudTask = GetCloudFiles();
            await Task.WhenAll(localTask, cloudTask).ConfigureAwait(false);
        }

        private async Task GetLocalFiles()
        {
            listViewLocal.Items.Clear();
            StorageFilesLocal = await LocalStorageWorker.GetFilesAsync();
            listViewLocal.Items.AddRange(
                StorageFilesLocal
                .Select(x => new ListViewItem
                {
                    Text = x.Name,
                    ImageIndex = GetIcon(x.Extension)
                })
                .ToArray());
        }

        private async Task GetCloudFiles()
        {
            listViewCloud.Items.Clear();
            StorageFilesCloud = await FtpWebWorker.GetFilesAsync();
            listViewCloud.Items.AddRange(
                StorageFilesCloud
                .Select(x => new ListViewItem
                {
                    Text = x.Name,
                    ImageIndex = GetIcon(x.Extension)
                })
                .ToArray());
        }

        private static readonly Dictionary<string, byte> Extensions = new Dictionary<string, byte>()
        {
            //Image
            { ".JPG", 0 },
            { ".JPE", 0 },
            { ".BMP", 0 },
            { ".GIF", 0 },
            { ".PNG", 0 },
            { ".TIF", 0 },
            { ".JPEG", 0 },
            { ".TIFF", 0 },
            //Video
            { ".AVI", 1 },
            { ".MKV", 1 },
            { ".MP4", 1 },
            { ".MPG", 1 },
            { ".VOB", 1 },
            { ".3GP", 1 },
            { ".MOV", 1 },
            { ".WMV", 1 },
            //TextDocument
            { ".TXT", 2 },
            { ".DOC", 2 },
            { ".RTF", 2 },
            { ".DOCX", 2 },
            //Archive
            { ".ZIP", 3 },
            { ".RAR", 3 },
            //Document
            { ".PDF", 4 },
            //WebDocument
            { ".JS", 5 },
            { ".CSS", 5 },
            { ".PHP", 5 },
            { ".HTML", 5 },
        };

        private static byte GetIcon(string extension)
        {
            if (Extensions.TryGetValue(extension.ToUpper(), out byte icon))
            {
                return icon;
            }
            return 6;
        }

        private void BtnClearLocalStorage_Click(object sender, EventArgs e)
        {
            if (StorageFilesLocal.Length > 0)
            {
                var result = CustomBox.ShowDialog(this, "Очистить локальное хранилище?", typeBtn: TypeButton.YesNo);
                if (result == DialogResult.Yes)
                {
                    pbLoading.Visible = true;

                    LocalStorageWorker.RemoveAll();
                    listViewLocal.Items.Clear();
                    StorageFilesLocal = Array.Empty<StorageFile>();

                    pbLoading.Visible = false;
                }
            }
        }

        private void BtnClearCloudStorage_Click(object sender, EventArgs e)
        {
            if (StorageFilesCloud.Length > 0)
            {
                if (!InternetConnetion.Check())
                {
                    SetNotInternet();
                    return;
                }

                var result = CustomBox.ShowDialog(this, "Очистить облачное хранилище?", typeBtn: TypeButton.YesNo);
                if (result == DialogResult.Yes)
                {
                    pbLoading.Visible = true;

                    FtpWebWorker.RemoveAllAsync();
                    listViewCloud.Items.Clear();
                    StorageFilesCloud = Array.Empty<StorageFile>();

                    pbLoading.Visible = false;
                }
            }
        }

        private async void BtnSynchronize_Click(object sender, EventArgs e)
        {
            if (!InternetConnetion.Check())
            {
                SetNotInternet();
                return;
            }

            var localFiles = StorageFilesLocal;
            var hostingFiles = StorageFilesCloud;

            if (StorageFilesCloud.Length == 0 && hostingFiles.Length == 0)
            {
                return;
            }

            OnLoading();

            for (int i = 0; i < localFiles.Length; i++)
            {
                await ExtractToCloud(localFiles[i].Name);
            }

            for (int i = 0; i < hostingFiles.Length; i++)
            {
                var file = localFiles.FirstOrDefault(x => x.Name == hostingFiles[i].Name);
                if (file == null)
                {
                    await DownloadToLocal(hostingFiles[i].Name);
                }
            }

            await GetFilesAsync();

            OffLoading();
        }

        private static readonly string countFileError = "Максимальное количество файлов одной загруки(10).";
        private readonly bool autonomously;

        private async void BtnUpload_Click(object sender, EventArgs e)
        {
            if (!InternetConnetion.Check())
            {
                SetNotInternet();
                return;
            }

            if (openFileDialog1.ShowDialog() == DialogResult.Cancel)
            {
                return;
            }

            var filesPathsLocal = openFileDialog1.FileNames;
            var filesPathsCloud = (string[])filesPathsLocal.Clone();

            var resultFilesLocal = CheckFiles(filesPathsLocal);
            var resultFilesCloud = CheckFiles(filesPathsCloud, false);

            if (resultFilesLocal.Length == 0 && resultFilesCloud.Length == 0)
            {
                return;
            }

            OnLoading();

            var localTask = LocalStorageWorker.AddFilesAsync(resultFilesLocal);
            var cloudTask = FtpWebWorker.UploadFilesAsync(resultFilesCloud);

            await Task.WhenAll(localTask, cloudTask);

            if (Settings.DeleteInsert)
            {
                DeleteFiles(resultFilesLocal);
                DeleteFiles(resultFilesCloud);
            }

            await GetFilesAsync();

            OffLoading();
        }

        private void OnLoading()
        {
            ToogleStorageInterface();
            pbLoading.Visible = true;
        }

        private void OffLoading()
        {
            ToogleStorageInterface(true);
            pbLoading.Visible = false;
        }

        private async void BtnUploadLocal_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.Cancel)
            {
                return;
            }

            var filePaths = openFileDialog1.FileNames;

            var resultFiles = CheckFiles(filePaths);
            if (resultFiles.Length == 0)
            {
                return;
            }

            OnLoading();

            await LocalStorageWorker.AddFilesAsync(filePaths);

            await GetLocalFiles();

            if (Settings.DeleteInsert)
            {
                DeleteFiles(filePaths);
            }

            OffLoading();
        }

        private async void BtnUploadCloud_Click(object sender, EventArgs e)
        {
            if (!InternetConnetion.Check())
            {
                SetNotInternet();
                return;
            }

            if (openFileDialog1.ShowDialog() == DialogResult.Cancel)
            {
                return;
            }

            var filePaths = openFileDialog1.FileNames;

            var resultFiles = CheckFiles(filePaths, false);
            if (resultFiles.Length == 0)
            {
                return;
            }

            OnLoading();

            await FtpWebWorker.UploadFilesAsync(filePaths);

            await GetCloudFiles();

            if (Settings.DeleteInsert)
            {
                DeleteFiles(filePaths);
            }

            OffLoading();
        }

        private static void DeleteFiles(string[] filesPaths)
        {
            for (int i = 0; i < filesPaths.Length; i++)
            {
                if (!string.IsNullOrEmpty(filesPaths[i]) && File.Exists(filesPaths[i]))
                {
                    File.Delete(filesPaths[i]);
                }
            }
        }

        private static bool CheckFileSize(string filePath)
        {
            var file = new FileInfo(filePath);
            return file.Length < 10_485_760;
        }

        private async void BtnMoveToCloud_Click(object sender, EventArgs e)
        {
            if (listViewLocal.SelectedItems.Count > 0)
            {
                OnLoading();

                var selected = listViewLocal.SelectedItems[0];

                var fileInfoCloud = StorageFilesCloud.FirstOrDefault(x => x.Name == selected.Text);

                if (Settings.ReplaceInsertCloud || fileInfoCloud == null)
                {
                    await ExtractToCloud(selected.Text);
                }
                else if (fileInfoCloud != null)
                {
                    var result = CustomBox.ShowDialog("Файл с таким названием уже существует в локальном облачном. Заменить?", typeBtn: TypeButton.YesNo);
                    if (result == DialogResult.Yes)
                    {
                        await ExtractToCloud(selected.Text);
                    }
                }

                await GetCloudFiles();

                OffLoading();
            }
        }

        private async Task ExtractToCloud(string filePath)
        {
            await LocalStorageWorker.ExtractFileAsync(filePath);
            await FtpWebWorker.UploadFileAsync(filePath);

            if (File.Exists(filePath))
            {
                File.Delete(filePath);
            }
        }

        private async void BtnMoveToLocal_Click(object sender, EventArgs e)
        {
            if (listViewCloud.SelectedItems.Count > 0)
            {
                OnLoading();

                var selected = listViewCloud.SelectedItems[0];

                var fileLocal = StorageFilesLocal.FirstOrDefault(x => x.Name == selected.Text);

                if (Settings.ReplaceInsertLocal || fileLocal == null)
                {
                    await DownloadToLocal(selected.Text);
                }
                else if (fileLocal != null)
                {
                    var result = CustomBox.ShowDialog("Файл с таким названием уже существует в локальном хранилище. Заменить?", "Уведомление", TypeButton.YesNo);
                    if (result == DialogResult.Yes)
                    {
                        await DownloadToLocal(selected.Text);
                    }
                }

                await GetLocalFiles();

                OffLoading();
            }
        }

        private async Task DownloadToLocal(string name)
        {
            var filePath = await FtpWebWorker.DownloadFileAsync(name);
            if (!string.IsNullOrEmpty(filePath))
            {
                LocalStorageWorker.AddFiles(new string[] { filePath });

                if (File.Exists(filePath))
                {
                    File.Delete(filePath);
                }
            }
        }

        private async void ExtractToolStripMenuItemCloud_Click(object sender, EventArgs e)
        {
            if (listViewCloud.SelectedItems.Count > 0)
            {
                var selected = listViewCloud.SelectedItems[0];

                if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
                {
                    OnLoading();

                    await FtpWebWorker.DownloadFileAsync(selected.Text, folderBrowserDialog1.SelectedPath);

                    if (Settings.DeleteExtract)
                    {
                        await FtpWebWorker.RemoveFileAsync(selected.Text);
                        await GetCloudFiles();
                    }

                    OffLoading();
                }
            }
        }

        private async void ExtractToolStripMenuItemLocal_Click(object sender, EventArgs e)
        {
            if (listViewLocal.SelectedItems.Count > 0)
            {
                var file = listViewLocal.SelectedItems[0];

                if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
                {
                    OnLoading();

                    await LocalStorageWorker.ExtractFileAsync(file.Text, folderBrowserDialog1.SelectedPath);

                    if (Settings.DeleteExtract)
                    {
                        LocalStorageWorker.RemoveFile(file.Text);
                        await GetLocalFiles();
                    }

                    OffLoading();
                }
            }
        }

        private void InfoToolStripMenuItemLocal_Click(object sender, EventArgs e)
        {
            if (listViewLocal.SelectedItems.Count > 0)
            {
                var selected = listViewLocal.SelectedItems[0];
                var file = StorageFilesLocal.FirstOrDefault(x => x.Name == selected.Text);

                CustomBox.Show(file.ToString(), "Информация о файле");
            }
        }

        private void InfoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (listViewCloud.SelectedItems.Count > 0)
            {
                var selected = listViewCloud.SelectedItems[0];
                var file = StorageFilesCloud.FirstOrDefault(x => x.Name == selected.Text);

                CustomBox.Show(file.ToString(), "Информация о файле");
            }
        }

        private async void DeleteFileLocal_Click(object sender, EventArgs e)
        {
            if (listViewLocal.SelectedItems.Count > 0)
            {
                OnLoading();

                var fileName = listViewLocal.SelectedItems[0];
                LocalStorageWorker.RemoveFile(fileName.Text);

                await GetLocalFiles();

                OffLoading();
            }
        }

        private async void DeleteFileCloud_Click(object sender, EventArgs e)
        {
            if (!InternetConnetion.Check())
            {
                SetNotInternet();
                return;
            }

            if (listViewCloud.SelectedItems.Count > 0)
            {
                OnLoading();

                var fileName = listViewCloud.SelectedItems[0];
                await FtpWebWorker.RemoveFileAsync(fileName.Text);

                await GetCloudFiles();

                OffLoading();
            }
        }

        private void BtnSettingsForm_Click(object sender, EventArgs e)
        {
            var form = new SettingsForm();
            form.ShowDialog();

            GetLocalFiles();
        }

        private void BtnAdminForm_Click(object sender, EventArgs e)
        {
            if (!InternetConnetion.Check())
            {
                SetNotInternet();
                return;
            }

            var adminForm = new AdminForm();
            adminForm.ShowDialog();
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            var remember = Config.IsRemember;
            if (!remember)
            {
                Reflection.RefreshConfig();
            }
        }

        private void BtnExitAccount_Click(object sender, EventArgs e)
        {
            Reflection.RefreshConfig();
            Application.Restart();
        }

        private void BtnChangePassword_Click(object sender, EventArgs e)
        {
            var change = new ChangePasswordForm();
            change.ShowDialog();
        }

        private void BtnUserGuide_Click(object sender, EventArgs e)
        {
            var form = new InfoForm("Руководство пользователя", $"{Directory.GetCurrentDirectory()}\\userGuide.rtf");
            form.ShowDialog();
        }
    }
}