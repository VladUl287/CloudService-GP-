
namespace Test
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.btnExitAccount = new System.Windows.Forms.Button();
            this.btnAdmin = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.btnUpload = new System.Windows.Forms.Button();
            this.btnClearLocalStorage = new System.Windows.Forms.Button();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.pbLoading = new System.Windows.Forms.PictureBox();
            this.btnSynchronize = new System.Windows.Forms.Button();
            this.contextMenuStripCloud = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.infoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.extractToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnUploadHosting = new System.Windows.Forms.Button();
            this.btnUploadLocal = new System.Windows.Forms.Button();
            this.btnMoveToCloud = new System.Windows.Forms.Button();
            this.btnDownloadFile = new System.Windows.Forms.Button();
            this.btnClearCloudStorage = new System.Windows.Forms.Button();
            this.lbLocalStorage = new System.Windows.Forms.Label();
            this.lbCloudStorage = new System.Windows.Forms.Label();
            this.listViewCloud = new System.Windows.Forms.ListView();
            this.imageListIcons = new System.Windows.Forms.ImageList(this.components);
            this.listViewLocal = new System.Windows.Forms.ListView();
            this.contextMenuStripLocal = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.infoToolStripMenuItemLocal = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteToolStripMenuItemLocal = new System.Windows.Forms.ToolStripMenuItem();
            this.extractToolStripMenuItemLocal = new System.Windows.Forms.ToolStripMenuItem();
            this.btnSettings = new System.Windows.Forms.Button();
            this.btnChangePassword = new System.Windows.Forms.Button();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.btnUserGuide = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbConnectionCheck)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbLoading)).BeginInit();
            this.contextMenuStripCloud.SuspendLayout();
            this.contextMenuStripLocal.SuspendLayout();
            this.SuspendLayout();
            // 
            // pbConnectionCheck
            // 
            this.pbConnectionCheck.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)));
            this.pbConnectionCheck.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pbConnectionCheck.BackgroundImage")));
            // 
            // btnExitAccount
            // 
            this.btnExitAccount.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnExitAccount.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(109)))), ((int)(((byte)(228)))));
            this.btnExitAccount.FlatAppearance.BorderSize = 0;
            this.btnExitAccount.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExitAccount.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.btnExitAccount.ForeColor = System.Drawing.Color.White;
            this.btnExitAccount.Location = new System.Drawing.Point(12, 408);
            this.btnExitAccount.Name = "btnExitAccount";
            this.btnExitAccount.Size = new System.Drawing.Size(60, 29);
            this.btnExitAccount.TabIndex = 0;
            this.btnExitAccount.Text = "Выход";
            this.btnExitAccount.UseVisualStyleBackColor = false;
            this.btnExitAccount.Click += new System.EventHandler(this.BtnExitAccount_Click);
            // 
            // btnAdmin
            // 
            this.btnAdmin.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAdmin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(109)))), ((int)(((byte)(228)))));
            this.btnAdmin.FlatAppearance.BorderSize = 0;
            this.btnAdmin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdmin.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.btnAdmin.ForeColor = System.Drawing.Color.White;
            this.btnAdmin.Location = new System.Drawing.Point(575, 408);
            this.btnAdmin.Name = "btnAdmin";
            this.btnAdmin.Size = new System.Drawing.Size(212, 29);
            this.btnAdmin.TabIndex = 0;
            this.btnAdmin.Text = "Управление пользователями";
            this.btnAdmin.UseVisualStyleBackColor = false;
            this.btnAdmin.Visible = false;
            this.btnAdmin.Click += new System.EventHandler(this.BtnAdminForm_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.Multiselect = true;
            // 
            // btnUpload
            // 
            this.btnUpload.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnUpload.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(109)))), ((int)(((byte)(228)))));
            this.btnUpload.FlatAppearance.BorderSize = 0;
            this.btnUpload.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpload.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.btnUpload.ForeColor = System.Drawing.Color.White;
            this.btnUpload.Location = new System.Drawing.Point(123, 336);
            this.btnUpload.Name = "btnUpload";
            this.btnUpload.Size = new System.Drawing.Size(87, 29);
            this.btnUpload.TabIndex = 2;
            this.btnUpload.Text = "Загрузить";
            this.btnUpload.UseVisualStyleBackColor = false;
            this.btnUpload.Click += new System.EventHandler(this.BtnUpload_Click);
            // 
            // btnClearLocalStorage
            // 
            this.btnClearLocalStorage.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnClearLocalStorage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(109)))), ((int)(((byte)(228)))));
            this.btnClearLocalStorage.FlatAppearance.BorderSize = 0;
            this.btnClearLocalStorage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClearLocalStorage.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.btnClearLocalStorage.ForeColor = System.Drawing.Color.White;
            this.btnClearLocalStorage.Location = new System.Drawing.Point(160, 371);
            this.btnClearLocalStorage.Name = "btnClearLocalStorage";
            this.btnClearLocalStorage.Size = new System.Drawing.Size(234, 29);
            this.btnClearLocalStorage.TabIndex = 4;
            this.btnClearLocalStorage.Text = "Очистить локальное хранилище";
            this.btnClearLocalStorage.UseVisualStyleBackColor = false;
            this.btnClearLocalStorage.Click += new System.EventHandler(this.BtnClearLocalStorage_Click);
            // 
            // pbLoading
            // 
            this.pbLoading.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.pbLoading.BackColor = System.Drawing.Color.Transparent;
            this.pbLoading.Image = global::Test.Properties.Resources.gifLoading;
            this.pbLoading.Location = new System.Drawing.Point(379, 286);
            this.pbLoading.Name = "pbLoading";
            this.pbLoading.Size = new System.Drawing.Size(42, 42);
            this.pbLoading.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbLoading.TabIndex = 5;
            this.pbLoading.TabStop = false;
            this.pbLoading.Visible = false;
            // 
            // btnSynchronize
            // 
            this.btnSynchronize.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(109)))), ((int)(((byte)(228)))));
            this.btnSynchronize.FlatAppearance.BorderSize = 0;
            this.btnSynchronize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSynchronize.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.btnSynchronize.ForeColor = System.Drawing.Color.White;
            this.btnSynchronize.Location = new System.Drawing.Point(538, 336);
            this.btnSynchronize.Name = "btnSynchronize";
            this.btnSynchronize.Size = new System.Drawing.Size(120, 29);
            this.btnSynchronize.TabIndex = 8;
            this.btnSynchronize.Text = "Синхронизация";
            this.btnSynchronize.UseVisualStyleBackColor = false;
            this.btnSynchronize.Click += new System.EventHandler(this.BtnSynchronize_Click);
            // 
            // contextMenuStripCloud
            // 
            this.contextMenuStripCloud.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.infoToolStripMenuItem,
            this.deleteToolStripMenuItem,
            this.extractToolStripMenuItem});
            this.contextMenuStripCloud.Name = "contextMenuStrip1";
            this.contextMenuStripCloud.ShowImageMargin = false;
            this.contextMenuStripCloud.Size = new System.Drawing.Size(124, 70);
            // 
            // infoToolStripMenuItem
            // 
            this.infoToolStripMenuItem.Name = "infoToolStripMenuItem";
            this.infoToolStripMenuItem.Size = new System.Drawing.Size(123, 22);
            this.infoToolStripMenuItem.Text = "Информация";
            this.infoToolStripMenuItem.Click += new System.EventHandler(this.InfoToolStripMenuItem_Click);
            // 
            // deleteToolStripMenuItem
            // 
            this.deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            this.deleteToolStripMenuItem.Size = new System.Drawing.Size(123, 22);
            this.deleteToolStripMenuItem.Text = "Удалить";
            this.deleteToolStripMenuItem.Click += new System.EventHandler(this.DeleteFileCloud_Click);
            // 
            // extractToolStripMenuItem
            // 
            this.extractToolStripMenuItem.Name = "extractToolStripMenuItem";
            this.extractToolStripMenuItem.Size = new System.Drawing.Size(123, 22);
            this.extractToolStripMenuItem.Text = "Извлечь";
            this.extractToolStripMenuItem.Click += new System.EventHandler(this.ExtractToolStripMenuItemCloud_Click);
            // 
            // btnUploadHosting
            // 
            this.btnUploadHosting.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(109)))), ((int)(((byte)(228)))));
            this.btnUploadHosting.FlatAppearance.BorderSize = 0;
            this.btnUploadHosting.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUploadHosting.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.btnUploadHosting.ForeColor = System.Drawing.Color.White;
            this.btnUploadHosting.Location = new System.Drawing.Point(374, 336);
            this.btnUploadHosting.Name = "btnUploadHosting";
            this.btnUploadHosting.Size = new System.Drawing.Size(158, 29);
            this.btnUploadHosting.TabIndex = 14;
            this.btnUploadHosting.Text = "Загрузить на хостинг";
            this.btnUploadHosting.UseVisualStyleBackColor = false;
            this.btnUploadHosting.Click += new System.EventHandler(this.BtnUploadCloud_Click);
            // 
            // btnUploadLocal
            // 
            this.btnUploadLocal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(109)))), ((int)(((byte)(228)))));
            this.btnUploadLocal.FlatAppearance.BorderSize = 0;
            this.btnUploadLocal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUploadLocal.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.btnUploadLocal.ForeColor = System.Drawing.Color.White;
            this.btnUploadLocal.Location = new System.Drawing.Point(216, 336);
            this.btnUploadLocal.Name = "btnUploadLocal";
            this.btnUploadLocal.Size = new System.Drawing.Size(151, 29);
            this.btnUploadLocal.TabIndex = 13;
            this.btnUploadLocal.Text = "Загрузить локально";
            this.btnUploadLocal.UseVisualStyleBackColor = false;
            this.btnUploadLocal.Click += new System.EventHandler(this.BtnUploadLocal_Click);
            // 
            // btnMoveToCloud
            // 
            this.btnMoveToCloud.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(109)))), ((int)(((byte)(228)))));
            this.btnMoveToCloud.FlatAppearance.BorderSize = 0;
            this.btnMoveToCloud.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMoveToCloud.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnMoveToCloud.ForeColor = System.Drawing.Color.White;
            this.btnMoveToCloud.Location = new System.Drawing.Point(383, 85);
            this.btnMoveToCloud.Name = "btnMoveToCloud";
            this.btnMoveToCloud.Size = new System.Drawing.Size(33, 28);
            this.btnMoveToCloud.TabIndex = 15;
            this.btnMoveToCloud.Text = ">";
            this.btnMoveToCloud.UseVisualStyleBackColor = false;
            this.btnMoveToCloud.Click += new System.EventHandler(this.BtnMoveToCloud_Click);
            // 
            // btnDownloadFile
            // 
            this.btnDownloadFile.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(109)))), ((int)(((byte)(228)))));
            this.btnDownloadFile.FlatAppearance.BorderSize = 0;
            this.btnDownloadFile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDownloadFile.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnDownloadFile.ForeColor = System.Drawing.Color.White;
            this.btnDownloadFile.Location = new System.Drawing.Point(383, 119);
            this.btnDownloadFile.Name = "btnDownloadFile";
            this.btnDownloadFile.Size = new System.Drawing.Size(33, 28);
            this.btnDownloadFile.TabIndex = 17;
            this.btnDownloadFile.Text = "<";
            this.btnDownloadFile.UseVisualStyleBackColor = false;
            this.btnDownloadFile.Click += new System.EventHandler(this.BtnMoveToLocal_Click);
            // 
            // btnClearCloudStorage
            // 
            this.btnClearCloudStorage.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnClearCloudStorage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(109)))), ((int)(((byte)(228)))));
            this.btnClearCloudStorage.FlatAppearance.BorderSize = 0;
            this.btnClearCloudStorage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClearCloudStorage.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.btnClearCloudStorage.ForeColor = System.Drawing.Color.White;
            this.btnClearCloudStorage.Location = new System.Drawing.Point(400, 371);
            this.btnClearCloudStorage.Name = "btnClearCloudStorage";
            this.btnClearCloudStorage.Size = new System.Drawing.Size(223, 29);
            this.btnClearCloudStorage.TabIndex = 18;
            this.btnClearCloudStorage.Text = "Очистить облачное хранилище";
            this.btnClearCloudStorage.UseVisualStyleBackColor = false;
            this.btnClearCloudStorage.Click += new System.EventHandler(this.BtnClearCloudStorage_Click);
            // 
            // lbLocalStorage
            // 
            this.lbLocalStorage.AutoSize = true;
            this.lbLocalStorage.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbLocalStorage.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lbLocalStorage.Location = new System.Drawing.Point(100, 62);
            this.lbLocalStorage.Name = "lbLocalStorage";
            this.lbLocalStorage.Size = new System.Drawing.Size(181, 20);
            this.lbLocalStorage.TabIndex = 19;
            this.lbLocalStorage.Text = "Локальное хранилище";
            // 
            // lbCloudStorage
            // 
            this.lbCloudStorage.AutoSize = true;
            this.lbCloudStorage.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbCloudStorage.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lbCloudStorage.Location = new System.Drawing.Point(525, 62);
            this.lbCloudStorage.Name = "lbCloudStorage";
            this.lbCloudStorage.Size = new System.Drawing.Size(173, 20);
            this.lbCloudStorage.TabIndex = 20;
            this.lbCloudStorage.Text = "Облачное хранилище";
            // 
            // listViewCloud
            // 
            this.listViewCloud.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(111)))), ((int)(((byte)(101)))), ((int)(((byte)(161)))));
            this.listViewCloud.ContextMenuStrip = this.contextMenuStripCloud;
            this.listViewCloud.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.listViewCloud.ForeColor = System.Drawing.Color.White;
            this.listViewCloud.HideSelection = false;
            this.listViewCloud.LargeImageList = this.imageListIcons;
            this.listViewCloud.Location = new System.Drawing.Point(426, 85);
            this.listViewCloud.MultiSelect = false;
            this.listViewCloud.Name = "listViewCloud";
            this.listViewCloud.Size = new System.Drawing.Size(361, 245);
            this.listViewCloud.TabIndex = 22;
            this.listViewCloud.UseCompatibleStateImageBehavior = false;
            // 
            // imageListIcons
            // 
            this.imageListIcons.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageListIcons.ImageStream")));
            this.imageListIcons.TransparentColor = System.Drawing.Color.Transparent;
            this.imageListIcons.Images.SetKeyName(0, "icons8IMG.png");
            this.imageListIcons.Images.SetKeyName(1, "iconsVIDEO.png");
            this.imageListIcons.Images.SetKeyName(2, "icons8DOC.png");
            this.imageListIcons.Images.SetKeyName(3, "icons8ZIP.png");
            this.imageListIcons.Images.SetKeyName(4, "iconsPDF.png");
            this.imageListIcons.Images.SetKeyName(5, "icons8DOCCODE.png");
            this.imageListIcons.Images.SetKeyName(6, "iconsFile.png");
            // 
            // listViewLocal
            // 
            this.listViewLocal.AllowDrop = true;
            this.listViewLocal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(111)))), ((int)(((byte)(101)))), ((int)(((byte)(161)))));
            this.listViewLocal.ContextMenuStrip = this.contextMenuStripLocal;
            this.listViewLocal.ForeColor = System.Drawing.Color.White;
            this.listViewLocal.HideSelection = false;
            this.listViewLocal.LargeImageList = this.imageListIcons;
            this.listViewLocal.Location = new System.Drawing.Point(12, 85);
            this.listViewLocal.MultiSelect = false;
            this.listViewLocal.Name = "listViewLocal";
            this.listViewLocal.Size = new System.Drawing.Size(361, 245);
            this.listViewLocal.TabIndex = 23;
            this.listViewLocal.UseCompatibleStateImageBehavior = false;
            // 
            // contextMenuStripLocal
            // 
            this.contextMenuStripLocal.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.infoToolStripMenuItemLocal,
            this.deleteToolStripMenuItemLocal,
            this.extractToolStripMenuItemLocal});
            this.contextMenuStripLocal.Name = "contextMenuStrip1";
            this.contextMenuStripLocal.ShowImageMargin = false;
            this.contextMenuStripLocal.Size = new System.Drawing.Size(124, 70);
            // 
            // infoToolStripMenuItemLocal
            // 
            this.infoToolStripMenuItemLocal.Name = "infoToolStripMenuItemLocal";
            this.infoToolStripMenuItemLocal.Size = new System.Drawing.Size(123, 22);
            this.infoToolStripMenuItemLocal.Text = "Информация";
            this.infoToolStripMenuItemLocal.Click += new System.EventHandler(this.InfoToolStripMenuItemLocal_Click);
            // 
            // deleteToolStripMenuItemLocal
            // 
            this.deleteToolStripMenuItemLocal.Name = "deleteToolStripMenuItemLocal";
            this.deleteToolStripMenuItemLocal.Size = new System.Drawing.Size(123, 22);
            this.deleteToolStripMenuItemLocal.Text = "Удалить";
            this.deleteToolStripMenuItemLocal.Click += new System.EventHandler(this.DeleteFileLocal_Click);
            // 
            // extractToolStripMenuItemLocal
            // 
            this.extractToolStripMenuItemLocal.Name = "extractToolStripMenuItemLocal";
            this.extractToolStripMenuItemLocal.Size = new System.Drawing.Size(123, 22);
            this.extractToolStripMenuItemLocal.Text = "Извлечь";
            this.extractToolStripMenuItemLocal.Click += new System.EventHandler(this.ExtractToolStripMenuItemLocal_Click);
            // 
            // btnSettings
            // 
            this.btnSettings.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(109)))), ((int)(((byte)(228)))));
            this.btnSettings.FlatAppearance.BorderSize = 0;
            this.btnSettings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSettings.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.btnSettings.ForeColor = System.Drawing.Color.White;
            this.btnSettings.Location = new System.Drawing.Point(686, 371);
            this.btnSettings.Name = "btnSettings";
            this.btnSettings.Size = new System.Drawing.Size(101, 29);
            this.btnSettings.TabIndex = 24;
            this.btnSettings.Text = "Настройки";
            this.btnSettings.UseVisualStyleBackColor = false;
            this.btnSettings.Click += new System.EventHandler(this.BtnSettingsForm_Click);
            // 
            // btnChangePassword
            // 
            this.btnChangePassword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(109)))), ((int)(((byte)(228)))));
            this.btnChangePassword.FlatAppearance.BorderSize = 0;
            this.btnChangePassword.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnChangePassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.btnChangePassword.ForeColor = System.Drawing.Color.White;
            this.btnChangePassword.Location = new System.Drawing.Point(78, 408);
            this.btnChangePassword.Name = "btnChangePassword";
            this.btnChangePassword.Size = new System.Drawing.Size(132, 29);
            this.btnChangePassword.TabIndex = 25;
            this.btnChangePassword.Text = "Сменить пароль";
            this.btnChangePassword.UseVisualStyleBackColor = false;
            this.btnChangePassword.Click += new System.EventHandler(this.BtnChangePassword_Click);
            // 
            // timer
            // 
            this.timer.Interval = 3000;
            // 
            // btnUserGuide
            // 
            this.btnUserGuide.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnUserGuide.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(109)))), ((int)(((byte)(228)))));
            this.btnUserGuide.FlatAppearance.BorderSize = 0;
            this.btnUserGuide.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUserGuide.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.btnUserGuide.ForeColor = System.Drawing.Color.White;
            this.btnUserGuide.Location = new System.Drawing.Point(216, 408);
            this.btnUserGuide.Name = "btnUserGuide";
            this.btnUserGuide.Size = new System.Drawing.Size(213, 29);
            this.btnUserGuide.TabIndex = 26;
            this.btnUserGuide.Text = "Руководство пользователя";
            this.btnUserGuide.UseVisualStyleBackColor = false;
            this.btnUserGuide.Click += new System.EventHandler(this.BtnUserGuide_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(60)))), ((int)(((byte)(99)))));
            this.ClientSize = new System.Drawing.Size(800, 441);
            this.Controls.Add(this.btnUserGuide);
            this.Controls.Add(this.btnChangePassword);
            this.Controls.Add(this.btnSettings);
            this.Controls.Add(this.listViewLocal);
            this.Controls.Add(this.listViewCloud);
            this.Controls.Add(this.lbCloudStorage);
            this.Controls.Add(this.lbLocalStorage);
            this.Controls.Add(this.btnClearCloudStorage);
            this.Controls.Add(this.btnDownloadFile);
            this.Controls.Add(this.btnMoveToCloud);
            this.Controls.Add(this.btnUploadHosting);
            this.Controls.Add(this.btnUploadLocal);
            this.Controls.Add(this.btnSynchronize);
            this.Controls.Add(this.pbLoading);
            this.Controls.Add(this.btnClearLocalStorage);
            this.Controls.Add(this.btnUpload);
            this.Controls.Add(this.btnAdmin);
            this.Controls.Add(this.btnExitAccount);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MainForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.Controls.SetChildIndex(this.btnExitAccount, 0);
            this.Controls.SetChildIndex(this.btnAdmin, 0);
            this.Controls.SetChildIndex(this.btnUpload, 0);
            this.Controls.SetChildIndex(this.btnClearLocalStorage, 0);
            this.Controls.SetChildIndex(this.pbLoading, 0);
            this.Controls.SetChildIndex(this.btnSynchronize, 0);
            this.Controls.SetChildIndex(this.btnUploadLocal, 0);
            this.Controls.SetChildIndex(this.btnUploadHosting, 0);
            this.Controls.SetChildIndex(this.btnMoveToCloud, 0);
            this.Controls.SetChildIndex(this.btnDownloadFile, 0);
            this.Controls.SetChildIndex(this.btnClearCloudStorage, 0);
            this.Controls.SetChildIndex(this.lbLocalStorage, 0);
            this.Controls.SetChildIndex(this.lbCloudStorage, 0);
            this.Controls.SetChildIndex(this.listViewCloud, 0);
            this.Controls.SetChildIndex(this.listViewLocal, 0);
            this.Controls.SetChildIndex(this.btnSettings, 0);
            this.Controls.SetChildIndex(this.btnChangePassword, 0);
            this.Controls.SetChildIndex(this.btnUserGuide, 0);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbConnectionCheck)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbLoading)).EndInit();
            this.contextMenuStripCloud.ResumeLayout(false);
            this.contextMenuStripLocal.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnExitAccount;
        private System.Windows.Forms.Button btnAdmin;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button btnUpload;
        private System.Windows.Forms.Button btnClearLocalStorage;
        private System.Windows.Forms.PictureBox pbLoading;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.Button btnSynchronize;
        private System.Windows.Forms.Button btnUploadHosting;
        private System.Windows.Forms.Button btnUploadLocal;
        private System.Windows.Forms.Button btnMoveToCloud;
        private System.Windows.Forms.Button btnDownloadFile;
        private System.Windows.Forms.Button btnClearCloudStorage;
        private System.Windows.Forms.Label lbLocalStorage;
        private System.Windows.Forms.Label lbCloudStorage;
        private System.Windows.Forms.ContextMenuStrip contextMenuStripCloud;
        private System.Windows.Forms.ToolStripMenuItem infoToolStripMenuItem;
        private System.Windows.Forms.ListView listViewCloud;
        private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem;
        private System.Windows.Forms.ListView listViewLocal;
        private System.Windows.Forms.ContextMenuStrip contextMenuStripLocal;
        private System.Windows.Forms.ToolStripMenuItem infoToolStripMenuItemLocal;
        private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItemLocal;
        private System.Windows.Forms.Button btnSettings;
        private System.Windows.Forms.ToolStripMenuItem extractToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem extractToolStripMenuItemLocal;
        private System.Windows.Forms.ImageList imageListIcons;
        private System.Windows.Forms.Button btnChangePassword;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.Button btnUserGuide;
    }
}