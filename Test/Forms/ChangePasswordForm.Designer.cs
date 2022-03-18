
namespace Test.Forms
{
    partial class ChangePasswordForm
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
            this.panelTop = new System.Windows.Forms.Panel();
            this.lbHead = new System.Windows.Forms.Label();
            this.btnExit = new System.Windows.Forms.Button();
            this.tbOldPassword = new System.Windows.Forms.TextBox();
            this.panelNewPassword = new System.Windows.Forms.Panel();
            this.panelPassword = new System.Windows.Forms.Panel();
            this.lbPassword = new System.Windows.Forms.Label();
            this.lbNewPassword = new System.Windows.Forms.Label();
            this.tbNewPassword = new System.Windows.Forms.TextBox();
            this.btnChangePassword = new System.Windows.Forms.Button();
            this.panelTop.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelTop
            // 
            this.panelTop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.panelTop.Controls.Add(this.lbHead);
            this.panelTop.Controls.Add(this.btnExit);
            this.panelTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTop.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.panelTop.Location = new System.Drawing.Point(0, 0);
            this.panelTop.Name = "panelTop";
            this.panelTop.Size = new System.Drawing.Size(495, 35);
            this.panelTop.TabIndex = 16;
            // 
            // lbHead
            // 
            this.lbHead.AutoSize = true;
            this.lbHead.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.lbHead.ForeColor = System.Drawing.Color.White;
            this.lbHead.Location = new System.Drawing.Point(3, 9);
            this.lbHead.Name = "lbHead";
            this.lbHead.Size = new System.Drawing.Size(0, 16);
            this.lbHead.TabIndex = 6;
            // 
            // btnExit
            // 
            this.btnExit.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnExit.FlatAppearance.BorderSize = 0;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.ForeColor = System.Drawing.Color.White;
            this.btnExit.Location = new System.Drawing.Point(450, 0);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(45, 35);
            this.btnExit.TabIndex = 3;
            this.btnExit.Text = "X";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.BtnExit_Click);
            // 
            // tbOldPassword
            // 
            this.tbOldPassword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(99)))));
            this.tbOldPassword.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbOldPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbOldPassword.ForeColor = System.Drawing.Color.White;
            this.tbOldPassword.Location = new System.Drawing.Point(139, 48);
            this.tbOldPassword.MaxLength = 30;
            this.tbOldPassword.Multiline = true;
            this.tbOldPassword.Name = "tbOldPassword";
            this.tbOldPassword.Size = new System.Drawing.Size(344, 20);
            this.tbOldPassword.TabIndex = 33;
            // 
            // panelNewPassword
            // 
            this.panelNewPassword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(109)))), ((int)(((byte)(228)))));
            this.panelNewPassword.ForeColor = System.Drawing.Color.White;
            this.panelNewPassword.Location = new System.Drawing.Point(139, 115);
            this.panelNewPassword.Name = "panelNewPassword";
            this.panelNewPassword.Size = new System.Drawing.Size(345, 1);
            this.panelNewPassword.TabIndex = 32;
            // 
            // panelPassword
            // 
            this.panelPassword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(109)))), ((int)(((byte)(228)))));
            this.panelPassword.ForeColor = System.Drawing.Color.White;
            this.panelPassword.Location = new System.Drawing.Point(139, 71);
            this.panelPassword.Name = "panelPassword";
            this.panelPassword.Size = new System.Drawing.Size(344, 1);
            this.panelPassword.TabIndex = 31;
            // 
            // lbPassword
            // 
            this.lbPassword.AutoSize = true;
            this.lbPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbPassword.ForeColor = System.Drawing.Color.White;
            this.lbPassword.Location = new System.Drawing.Point(1, 49);
            this.lbPassword.Name = "lbPassword";
            this.lbPassword.Size = new System.Drawing.Size(136, 20);
            this.lbPassword.TabIndex = 34;
            this.lbPassword.Text = "Текущий пароль:";
            // 
            // lbNewPassword
            // 
            this.lbNewPassword.AutoSize = true;
            this.lbNewPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbNewPassword.ForeColor = System.Drawing.Color.White;
            this.lbNewPassword.Location = new System.Drawing.Point(13, 93);
            this.lbNewPassword.Name = "lbNewPassword";
            this.lbNewPassword.Size = new System.Drawing.Size(122, 20);
            this.lbNewPassword.TabIndex = 35;
            this.lbNewPassword.Text = "Новый пароль:";
            // 
            // tbNewPassword
            // 
            this.tbNewPassword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(99)))));
            this.tbNewPassword.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbNewPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbNewPassword.ForeColor = System.Drawing.Color.White;
            this.tbNewPassword.Location = new System.Drawing.Point(139, 93);
            this.tbNewPassword.MaxLength = 30;
            this.tbNewPassword.Name = "tbNewPassword";
            this.tbNewPassword.Size = new System.Drawing.Size(345, 19);
            this.tbNewPassword.TabIndex = 39;
            // 
            // btnChangePassword
            // 
            this.btnChangePassword.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnChangePassword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(109)))), ((int)(((byte)(228)))));
            this.btnChangePassword.FlatAppearance.BorderSize = 0;
            this.btnChangePassword.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnChangePassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnChangePassword.ForeColor = System.Drawing.Color.White;
            this.btnChangePassword.Location = new System.Drawing.Point(325, 128);
            this.btnChangePassword.Name = "btnChangePassword";
            this.btnChangePassword.Size = new System.Drawing.Size(158, 29);
            this.btnChangePassword.TabIndex = 40;
            this.btnChangePassword.Text = "Сменить пароль";
            this.btnChangePassword.UseVisualStyleBackColor = false;
            this.btnChangePassword.Click += new System.EventHandler(this.BtnChangePassword_Click);
            // 
            // ChangePasswordForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(99)))));
            this.ClientSize = new System.Drawing.Size(495, 169);
            this.Controls.Add(this.btnChangePassword);
            this.Controls.Add(this.tbNewPassword);
            this.Controls.Add(this.lbNewPassword);
            this.Controls.Add(this.lbPassword);
            this.Controls.Add(this.tbOldPassword);
            this.Controls.Add(this.panelNewPassword);
            this.Controls.Add(this.panelPassword);
            this.Controls.Add(this.panelTop);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ChangePasswordForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ChangePassword";
            this.panelTop.ResumeLayout(false);
            this.panelTop.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelTop;
        private System.Windows.Forms.Label lbHead;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.TextBox tbOldPassword;
        private System.Windows.Forms.Panel panelNewPassword;
        private System.Windows.Forms.Panel panelPassword;
        private System.Windows.Forms.Label lbPassword;
        private System.Windows.Forms.Label lbNewPassword;
        private System.Windows.Forms.TextBox tbNewPassword;
        private System.Windows.Forms.Button btnChangePassword;
    }
}