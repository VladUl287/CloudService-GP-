
namespace Test
{
    partial class SettingsForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SettingsForm));
            this.lbStoragePath = new System.Windows.Forms.Label();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.btnAccept = new System.Windows.Forms.Button();
            this.btnSelectPath = new System.Windows.Forms.Button();
            this.cbDeleteInsert = new Test.CheckBoxControl.ControlCB();
            this.cbReplaceInsertCloud = new Test.CheckBoxControl.ControlCB();
            this.cbReplaceInsertLocal = new Test.CheckBoxControl.ControlCB();
            this.cbEncryption = new Test.CheckBoxControl.ControlCB();
            this.cbDeleteExtract = new Test.CheckBoxControl.ControlCB();
            this.lbDeleteInsert = new System.Windows.Forms.Label();
            this.lbDeleteExtract = new System.Windows.Forms.Label();
            this.lbEncryption = new System.Windows.Forms.Label();
            this.lbReplaceInsertLocal = new System.Windows.Forms.Label();
            this.lbReplaceInsertCloud = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbConnectionCheck)).BeginInit();
            this.SuspendLayout();
            // 
            // lbAppTitle
            // 
            this.lbAppTitle.Location = new System.Drawing.Point(6, 14);
            this.lbAppTitle.Size = new System.Drawing.Size(149, 31);
            this.lbAppTitle.Text = "Настройки";
            // 
            // pictureBoxLogo
            // 
            this.pictureBoxLogo.Visible = false;
            // 
            // pbConnectionCheck
            // 
            this.pbConnectionCheck.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pbConnectionCheck.BackgroundImage")));
            this.pbConnectionCheck.Image = ((System.Drawing.Image)(resources.GetObject("pbConnectionCheck.Image")));
            this.pbConnectionCheck.Location = new System.Drawing.Point(-1002, 14);
            this.pbConnectionCheck.Visible = false;
            // 
            // lbStoragePath
            // 
            this.lbStoragePath.AutoSize = true;
            this.lbStoragePath.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbStoragePath.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lbStoragePath.Location = new System.Drawing.Point(160, 213);
            this.lbStoragePath.Name = "lbStoragePath";
            this.lbStoragePath.Size = new System.Drawing.Size(164, 20);
            this.lbStoragePath.TabIndex = 9;
            this.lbStoragePath.Text = "Папка с программой";
            // 
            // btnAccept
            // 
            this.btnAccept.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAccept.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(109)))), ((int)(((byte)(228)))));
            this.btnAccept.FlatAppearance.BorderSize = 0;
            this.btnAccept.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAccept.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnAccept.Location = new System.Drawing.Point(377, 254);
            this.btnAccept.Name = "btnAccept";
            this.btnAccept.Size = new System.Drawing.Size(134, 33);
            this.btnAccept.TabIndex = 11;
            this.btnAccept.Text = "Применить";
            this.btnAccept.UseVisualStyleBackColor = false;
            this.btnAccept.Click += new System.EventHandler(this.BtnAccept_Click);
            // 
            // btnSelectPath
            // 
            this.btnSelectPath.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(109)))), ((int)(((byte)(228)))));
            this.btnSelectPath.FlatAppearance.BorderSize = 0;
            this.btnSelectPath.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSelectPath.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnSelectPath.ForeColor = System.Drawing.Color.White;
            this.btnSelectPath.Location = new System.Drawing.Point(14, 207);
            this.btnSelectPath.Name = "btnSelectPath";
            this.btnSelectPath.Size = new System.Drawing.Size(143, 29);
            this.btnSelectPath.TabIndex = 12;
            this.btnSelectPath.Text = "Путь хранилища";
            this.btnSelectPath.UseVisualStyleBackColor = false;
            this.btnSelectPath.Click += new System.EventHandler(this.BtnSelectPath_Click);
            // 
            // cbDeleteInsert
            // 
            this.cbDeleteInsert.AutoSize = true;
            this.cbDeleteInsert.Location = new System.Drawing.Point(12, 67);
            this.cbDeleteInsert.MinimumSize = new System.Drawing.Size(30, 22);
            this.cbDeleteInsert.Name = "cbDeleteInsert";
            this.cbDeleteInsert.Size = new System.Drawing.Size(78, 22);
            this.cbDeleteInsert.TabIndex = 15;
            this.cbDeleteInsert.Text = "controlCB1";
            this.cbDeleteInsert.UseVisualStyleBackColor = true;
            // 
            // cbReplaceInsertCloud
            // 
            this.cbReplaceInsertCloud.AutoSize = true;
            this.cbReplaceInsertCloud.Location = new System.Drawing.Point(12, 179);
            this.cbReplaceInsertCloud.MinimumSize = new System.Drawing.Size(30, 22);
            this.cbReplaceInsertCloud.Name = "cbReplaceInsertCloud";
            this.cbReplaceInsertCloud.Size = new System.Drawing.Size(78, 22);
            this.cbReplaceInsertCloud.TabIndex = 17;
            this.cbReplaceInsertCloud.Text = "controlCB3";
            this.cbReplaceInsertCloud.UseVisualStyleBackColor = true;
            // 
            // cbReplaceInsertLocal
            // 
            this.cbReplaceInsertLocal.AutoSize = true;
            this.cbReplaceInsertLocal.Location = new System.Drawing.Point(12, 151);
            this.cbReplaceInsertLocal.MinimumSize = new System.Drawing.Size(30, 22);
            this.cbReplaceInsertLocal.Name = "cbReplaceInsertLocal";
            this.cbReplaceInsertLocal.Size = new System.Drawing.Size(78, 22);
            this.cbReplaceInsertLocal.TabIndex = 18;
            this.cbReplaceInsertLocal.Text = "controlCB4";
            this.cbReplaceInsertLocal.UseVisualStyleBackColor = true;
            // 
            // cbEncryption
            // 
            this.cbEncryption.AutoSize = true;
            this.cbEncryption.Location = new System.Drawing.Point(12, 123);
            this.cbEncryption.MinimumSize = new System.Drawing.Size(30, 22);
            this.cbEncryption.Name = "cbEncryption";
            this.cbEncryption.Size = new System.Drawing.Size(78, 22);
            this.cbEncryption.TabIndex = 19;
            this.cbEncryption.Text = "controlCB5";
            this.cbEncryption.UseVisualStyleBackColor = true;
            // 
            // cbDeleteExtract
            // 
            this.cbDeleteExtract.AutoSize = true;
            this.cbDeleteExtract.Location = new System.Drawing.Point(12, 95);
            this.cbDeleteExtract.MinimumSize = new System.Drawing.Size(30, 22);
            this.cbDeleteExtract.Name = "cbDeleteExtract";
            this.cbDeleteExtract.Size = new System.Drawing.Size(78, 22);
            this.cbDeleteExtract.TabIndex = 20;
            this.cbDeleteExtract.Text = "controlCB6";
            this.cbDeleteExtract.UseVisualStyleBackColor = true;
            // 
            // lbDeleteInsert
            // 
            this.lbDeleteInsert.AutoSize = true;
            this.lbDeleteInsert.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbDeleteInsert.Location = new System.Drawing.Point(91, 67);
            this.lbDeleteInsert.Name = "lbDeleteInsert";
            this.lbDeleteInsert.Size = new System.Drawing.Size(204, 20);
            this.lbDeleteInsert.TabIndex = 21;
            this.lbDeleteInsert.Text = "Удалять при добавлении";
            // 
            // lbDeleteExtract
            // 
            this.lbDeleteExtract.AutoSize = true;
            this.lbDeleteExtract.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbDeleteExtract.Location = new System.Drawing.Point(91, 96);
            this.lbDeleteExtract.Name = "lbDeleteExtract";
            this.lbDeleteExtract.Size = new System.Drawing.Size(201, 20);
            this.lbDeleteExtract.TabIndex = 22;
            this.lbDeleteExtract.Text = "Удалять при извлечении";
            // 
            // lbEncryption
            // 
            this.lbEncryption.AutoSize = true;
            this.lbEncryption.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbEncryption.Location = new System.Drawing.Point(91, 123);
            this.lbEncryption.Name = "lbEncryption";
            this.lbEncryption.Size = new System.Drawing.Size(100, 20);
            this.lbEncryption.TabIndex = 23;
            this.lbEncryption.Text = "Шифровать";
            // 
            // lbReplaceInsertLocal
            // 
            this.lbReplaceInsertLocal.AutoSize = true;
            this.lbReplaceInsertLocal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbReplaceInsertLocal.Location = new System.Drawing.Point(91, 151);
            this.lbReplaceInsertLocal.Name = "lbReplaceInsertLocal";
            this.lbReplaceInsertLocal.Size = new System.Drawing.Size(402, 20);
            this.lbReplaceInsertLocal.TabIndex = 24;
            this.lbReplaceInsertLocal.Text = "Заменять при добавлении в локальном хранилище";
            // 
            // lbReplaceInsertCloud
            // 
            this.lbReplaceInsertCloud.AutoSize = true;
            this.lbReplaceInsertCloud.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbReplaceInsertCloud.Location = new System.Drawing.Point(91, 179);
            this.lbReplaceInsertCloud.Name = "lbReplaceInsertCloud";
            this.lbReplaceInsertCloud.Size = new System.Drawing.Size(391, 20);
            this.lbReplaceInsertCloud.TabIndex = 25;
            this.lbReplaceInsertCloud.Text = "Заменять при добавлении в облачное хранилище";
            // 
            // SettingsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(60)))), ((int)(((byte)(99)))));
            this.ClientSize = new System.Drawing.Size(523, 299);
            this.Controls.Add(this.lbReplaceInsertCloud);
            this.Controls.Add(this.lbReplaceInsertLocal);
            this.Controls.Add(this.lbEncryption);
            this.Controls.Add(this.lbDeleteExtract);
            this.Controls.Add(this.lbDeleteInsert);
            this.Controls.Add(this.cbDeleteExtract);
            this.Controls.Add(this.cbEncryption);
            this.Controls.Add(this.cbReplaceInsertLocal);
            this.Controls.Add(this.cbReplaceInsertCloud);
            this.Controls.Add(this.cbDeleteInsert);
            this.Controls.Add(this.btnSelectPath);
            this.Controls.Add(this.btnAccept);
            this.Controls.Add(this.lbStoragePath);
            this.ForeColor = System.Drawing.Color.White;
            this.Name = "SettingsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SettingsForm";
            this.Controls.SetChildIndex(this.lbStoragePath, 0);
            this.Controls.SetChildIndex(this.btnAccept, 0);
            this.Controls.SetChildIndex(this.btnSelectPath, 0);
            this.Controls.SetChildIndex(this.cbDeleteInsert, 0);
            this.Controls.SetChildIndex(this.cbReplaceInsertCloud, 0);
            this.Controls.SetChildIndex(this.cbReplaceInsertLocal, 0);
            this.Controls.SetChildIndex(this.cbEncryption, 0);
            this.Controls.SetChildIndex(this.cbDeleteExtract, 0);
            this.Controls.SetChildIndex(this.lbDeleteInsert, 0);
            this.Controls.SetChildIndex(this.lbDeleteExtract, 0);
            this.Controls.SetChildIndex(this.lbEncryption, 0);
            this.Controls.SetChildIndex(this.lbReplaceInsertLocal, 0);
            this.Controls.SetChildIndex(this.lbReplaceInsertCloud, 0);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbConnectionCheck)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lbStoragePath;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.Button btnAccept;
        private System.Windows.Forms.Button btnSelectPath;
        private CheckBoxControl.ControlCB cbDeleteInsert;
        private CheckBoxControl.ControlCB cbReplaceInsertCloud;
        private CheckBoxControl.ControlCB cbReplaceInsertLocal;
        private CheckBoxControl.ControlCB cbEncryption;
        private CheckBoxControl.ControlCB cbDeleteExtract;
        private System.Windows.Forms.Label lbDeleteInsert;
        private System.Windows.Forms.Label lbDeleteExtract;
        private System.Windows.Forms.Label lbEncryption;
        private System.Windows.Forms.Label lbReplaceInsertLocal;
        private System.Windows.Forms.Label lbReplaceInsertCloud;
    }
}