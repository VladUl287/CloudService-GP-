
namespace Test
{
    partial class AuthorizationForm
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
            this.tbUsername = new System.Windows.Forms.TextBox();
            this.btnLogin = new System.Windows.Forms.Button();
            this.panelPassword = new System.Windows.Forms.Panel();
            this.panelLoginOrEmail = new System.Windows.Forms.Panel();
            this.lbLoginOrEmail = new System.Windows.Forms.Label();
            this.lbPassword = new System.Windows.Forms.Label();
            this.tbPassword = new System.Windows.Forms.TextBox();
            this.btnTooglePass = new System.Windows.Forms.Button();
            this.lbRemember = new System.Windows.Forms.Label();
            this.lbOffline = new System.Windows.Forms.Label();
            this.cbAutonomously = new Test.CheckBoxControl.ControlCB();
            this.cbRemember = new Test.CheckBoxControl.ControlCB();
            this.SuspendLayout();
            // 
            // tbUsername
            // 
            this.tbUsername.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tbUsername.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(60)))), ((int)(((byte)(99)))));
            this.tbUsername.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbUsername.ForeColor = System.Drawing.Color.White;
            this.tbUsername.Location = new System.Drawing.Point(119, 95);
            this.tbUsername.MaxLength = 150;
            this.tbUsername.Multiline = true;
            this.tbUsername.Name = "tbUsername";
            this.tbUsername.Size = new System.Drawing.Size(447, 20);
            this.tbUsername.TabIndex = 17;
            // 
            // btnLogin
            // 
            this.btnLogin.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnLogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(109)))), ((int)(((byte)(228)))));
            this.btnLogin.FlatAppearance.BorderSize = 0;
            this.btnLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnLogin.ForeColor = System.Drawing.Color.White;
            this.btnLogin.Location = new System.Drawing.Point(389, 337);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(177, 33);
            this.btnLogin.TabIndex = 16;
            this.btnLogin.Text = "Войти";
            this.btnLogin.UseVisualStyleBackColor = false;
            this.btnLogin.Click += new System.EventHandler(this.BtnLogin_Click);
            // 
            // panelPassword
            // 
            this.panelPassword.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panelPassword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(109)))), ((int)(((byte)(228)))));
            this.panelPassword.ForeColor = System.Drawing.Color.White;
            this.panelPassword.Location = new System.Drawing.Point(117, 185);
            this.panelPassword.Name = "panelPassword";
            this.panelPassword.Size = new System.Drawing.Size(449, 1);
            this.panelPassword.TabIndex = 15;
            // 
            // panelLoginOrEmail
            // 
            this.panelLoginOrEmail.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panelLoginOrEmail.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(109)))), ((int)(((byte)(228)))));
            this.panelLoginOrEmail.ForeColor = System.Drawing.Color.White;
            this.panelLoginOrEmail.Location = new System.Drawing.Point(119, 117);
            this.panelLoginOrEmail.Name = "panelLoginOrEmail";
            this.panelLoginOrEmail.Size = new System.Drawing.Size(447, 1);
            this.panelLoginOrEmail.TabIndex = 14;
            // 
            // lbLoginOrEmail
            // 
            this.lbLoginOrEmail.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbLoginOrEmail.AutoSize = true;
            this.lbLoginOrEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbLoginOrEmail.ForeColor = System.Drawing.Color.White;
            this.lbLoginOrEmail.Location = new System.Drawing.Point(13, 95);
            this.lbLoginOrEmail.Name = "lbLoginOrEmail";
            this.lbLoginOrEmail.Size = new System.Drawing.Size(102, 20);
            this.lbLoginOrEmail.TabIndex = 23;
            this.lbLoginOrEmail.Text = "Email/Логин:";
            // 
            // lbPassword
            // 
            this.lbPassword.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbPassword.AutoSize = true;
            this.lbPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbPassword.ForeColor = System.Drawing.Color.White;
            this.lbPassword.Location = new System.Drawing.Point(42, 163);
            this.lbPassword.Name = "lbPassword";
            this.lbPassword.Size = new System.Drawing.Size(71, 20);
            this.lbPassword.TabIndex = 24;
            this.lbPassword.Text = "Пароль:";
            // 
            // tbPassword
            // 
            this.tbPassword.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tbPassword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(60)))), ((int)(((byte)(99)))));
            this.tbPassword.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbPassword.ForeColor = System.Drawing.Color.White;
            this.tbPassword.Location = new System.Drawing.Point(149, 163);
            this.tbPassword.MaxLength = 150;
            this.tbPassword.Multiline = true;
            this.tbPassword.Name = "tbPassword";
            this.tbPassword.PasswordChar = '•';
            this.tbPassword.Size = new System.Drawing.Size(417, 20);
            this.tbPassword.TabIndex = 30;
            // 
            // btnTooglePass
            // 
            this.btnTooglePass.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnTooglePass.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(60)))), ((int)(((byte)(99)))));
            this.btnTooglePass.BackgroundImage = global::Test.Properties.Resources.iconHidePassword;
            this.btnTooglePass.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnTooglePass.FlatAppearance.BorderSize = 0;
            this.btnTooglePass.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTooglePass.ForeColor = System.Drawing.Color.White;
            this.btnTooglePass.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTooglePass.Location = new System.Drawing.Point(116, 161);
            this.btnTooglePass.Margin = new System.Windows.Forms.Padding(0);
            this.btnTooglePass.Name = "btnTooglePass";
            this.btnTooglePass.Padding = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.btnTooglePass.Size = new System.Drawing.Size(30, 22);
            this.btnTooglePass.TabIndex = 27;
            this.btnTooglePass.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTooglePass.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnTooglePass.UseVisualStyleBackColor = false;
            this.btnTooglePass.Click += new System.EventHandler(this.BtnShowPassword_Click);
            // 
            // lbRemember
            // 
            this.lbRemember.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbRemember.AutoSize = true;
            this.lbRemember.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbRemember.ForeColor = System.Drawing.Color.White;
            this.lbRemember.Location = new System.Drawing.Point(195, 203);
            this.lbRemember.Name = "lbRemember";
            this.lbRemember.Size = new System.Drawing.Size(94, 20);
            this.lbRemember.TabIndex = 33;
            this.lbRemember.Text = "Запомнить";
            // 
            // lbOffline
            // 
            this.lbOffline.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbOffline.AutoSize = true;
            this.lbOffline.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbOffline.ForeColor = System.Drawing.Color.White;
            this.lbOffline.Location = new System.Drawing.Point(195, 241);
            this.lbOffline.Name = "lbOffline";
            this.lbOffline.Size = new System.Drawing.Size(169, 20);
            this.lbOffline.TabIndex = 35;
            this.lbOffline.Text = "Работать автономно";
            // 
            // cbAutonomously
            // 
            this.cbAutonomously.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cbAutonomously.AutoSize = true;
            this.cbAutonomously.Location = new System.Drawing.Point(116, 241);
            this.cbAutonomously.MinimumSize = new System.Drawing.Size(30, 22);
            this.cbAutonomously.Name = "cbAutonomously";
            this.cbAutonomously.Size = new System.Drawing.Size(78, 22);
            this.cbAutonomously.TabIndex = 34;
            this.cbAutonomously.Text = "controlCB1";
            this.cbAutonomously.UseVisualStyleBackColor = true;
            // 
            // cbRemember
            // 
            this.cbRemember.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cbRemember.AutoSize = true;
            this.cbRemember.Location = new System.Drawing.Point(116, 203);
            this.cbRemember.MinimumSize = new System.Drawing.Size(30, 22);
            this.cbRemember.Name = "cbRemember";
            this.cbRemember.Size = new System.Drawing.Size(78, 22);
            this.cbRemember.TabIndex = 32;
            this.cbRemember.Text = "controlCB1";
            this.cbRemember.UseVisualStyleBackColor = true;
            // 
            // AuthorizationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(60)))), ((int)(((byte)(99)))));
            this.ClientSize = new System.Drawing.Size(578, 382);
            this.Controls.Add(this.lbOffline);
            this.Controls.Add(this.cbAutonomously);
            this.Controls.Add(this.lbRemember);
            this.Controls.Add(this.cbRemember);
            this.Controls.Add(this.tbPassword);
            this.Controls.Add(this.btnTooglePass);
            this.Controls.Add(this.lbPassword);
            this.Controls.Add(this.lbLoginOrEmail);
            this.Controls.Add(this.tbUsername);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.panelPassword);
            this.Controls.Add(this.panelLoginOrEmail);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AuthorizationForm";
            this.Text = "AuthorizationForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox tbUsername;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Panel panelPassword;
        private System.Windows.Forms.Panel panelLoginOrEmail;
        private System.Windows.Forms.Label lbLoginOrEmail;
        private System.Windows.Forms.Label lbPassword;
        private System.Windows.Forms.Button btnTooglePass;
        private System.Windows.Forms.TextBox tbPassword;
        private CheckBoxControl.ControlCB cbRemember;
        private System.Windows.Forms.Label lbRemember;
        private CheckBoxControl.ControlCB cbAutonomously;
        private System.Windows.Forms.Label lbOffline;
    }
}