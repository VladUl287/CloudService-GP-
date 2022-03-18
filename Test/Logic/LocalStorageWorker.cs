using Ionic.Zip;
using System;
using System.IO;
using System.IO.Compression;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Test.Models;
using TPJ.Encrypt;
using TPJ.Encrypt.Models;

namespace Test.Logic
{
    public class LocalStorageWorker
    {
        private static readonly string key = "123456";
        private static readonly string parentName = "storage.zip";
        private static readonly Encryption encrypt = new Encryption(new EncryptSettings(key));

        public static void AddFiles(string[] filePaths)
        {
            string filePathParent = $"{Settings.PathStorage}\\{parentName}";
            string password = Config.Password + key;

            var drive = new DriveInfo(Path.GetPathRoot(filePathParent));
            if (drive.AvailableFreeSpace < 10_485_760 * (filePaths.Length + 2))
            {
                CustomBox.Show("На диске c хранилищем недостаточно места.");
                return;
            }

            using (var zip = new Ionic.Zip.ZipFile(filePathParent))
            {
                zip.AlternateEncoding = Encoding.UTF8;
                zip.AlternateEncodingUsage = ZipOption.AsNecessary;
                if (Settings.Encryption)
                {
                    zip.Encryption = EncryptionAlgorithm.WinZipAes256;
                }
                zip.Password = password;

                for (int i = 0; i < filePaths.Length; i++)
                {
                    if (File.Exists(filePaths[i]))
                    {
                        using (var stream = File.OpenRead(filePaths[i]))
                        {
                            var fileName = Path.GetFileName(filePaths[i]);
                            var encryptName = encrypt.Encrypt(fileName).Replace('/', '-');
                            var entry = zip.Entries.FirstOrDefault(x => x.FileName == encryptName);
                            if (entry != null)
                            {
                                zip.RemoveEntry(entry);
                            }
                            zip.AddEntry(encryptName, stream);
                            zip.Save();
                        }
                    }
                }
            }
        }

        public static StorageFile[] GetFiles()
        {
            string filePathParent = $"{Settings.PathStorage}\\{parentName}";

            var files = Array.Empty<StorageFile>();

            if (!File.Exists(filePathParent))
            {
                return files;
            }
            using (var zip = System.IO.Compression.ZipFile.Open(filePathParent, ZipArchiveMode.Read))
            {
                files = new StorageFile[zip.Entries.Count];
                for (int i = 0; i < zip.Entries.Count; i++)
                {
                    var subEntry = zip.Entries[i];
                    string decrypt = encrypt.Decrypt(subEntry.Name.Replace('-', '/'));
                    var extension = Path.GetExtension(decrypt);
                    files[i] = new StorageFile
                    {
                        Name = decrypt,
                        Length = subEntry.Length,
                        Compress = subEntry.CompressedLength,
                        Modified = subEntry.LastWriteTime.ToString(),
                        Extension = extension
                    };
                }
            }

            return files;
        }

        public static void ExtractFile(string name, string selectedPath = "")
        {
            string filePathParent = $"{Settings.PathStorage}\\{parentName}";
            string password = Config.Password + key;

            if (File.Exists(filePathParent))
            {
                using (var zip = Ionic.Zip.ZipFile.Read(filePathParent))
                {
                    zip.Password = password;
                    string encryptName = encrypt.Encrypt(name);
                    string afterEncrypt = encryptName.Replace('/', '-');
                    var entry = zip.FirstOrDefault(x => x.FileName == afterEncrypt);
                    if (entry != null)
                    {
                        string decrypt = encrypt.Decrypt(encryptName);

                        using (var reader = entry.OpenReader())
                        {
                            string path = string.IsNullOrEmpty(selectedPath) ? Directory.GetCurrentDirectory() : selectedPath;
                            using (var fileStream = File.Create($"{path}\\{decrypt}"))
                            {
                                reader.CopyTo(fileStream);
                            }
                        }
                    }
                }
            }
        }

        public static void RemoveAll()
        {
            string filePathParent = $"{Settings.PathStorage}\\{parentName}";
            if (File.Exists(filePathParent))
            {
                File.Delete(filePathParent);
            }
        }

        public static void RemoveFile(string name)
        {
            string filePathParent = $"{Settings.PathStorage}\\{parentName}";
            string password = Config.Password + key;

            if (File.Exists(filePathParent))
            {
                using (var zip = Ionic.Zip.ZipFile.Read(filePathParent))
                {
                    zip.Password = password;
                    string encryptName = encrypt.Encrypt(name).Replace('/', '-');
                    var entry = zip.FirstOrDefault(x => x.FileName == encryptName);
                    if (entry != null)
                    {
                        zip.RemoveEntry(entry);
                        zip.Save();
                    }
                }
            }
        }

        public static Task<StorageFile[]> GetFilesAsync()
        {
            return Task.Run(() =>
            {
                return GetFiles();
            });
        }

        public static Task ExtractFileAsync(string name, string selectedPath = "")
        {
            return Task.Run(() =>
            {
                ExtractFile(name, selectedPath);
            });
        }

        public static Task AddFilesAsync(string[] filePaths)
        {
            return Task.Run(() =>
            {
                AddFiles(filePaths);
            });
        }
    }
}