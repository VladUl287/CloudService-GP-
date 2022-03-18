
namespace Test
{
    partial class AuthenticationForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AuthenticationForm));
            this.panelMenu = new System.Windows.Forms.Panel();
            this.btnUserGuide = new System.Windows.Forms.Button();
            this.btnPasMenu = new System.Windows.Forms.Button();
            this.btnRegMenu = new System.Windows.Forms.Button();
            this.btnAuthMenu = new System.Windows.Forms.Button();
            this.panelForm = new System.Windows.Forms.Panel();
            this.imgList = new System.Windows.Forms.ImageList(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbConnectionCheck)).BeginInit();
            this.panelMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // pbConnectionCheck
            // 
            this.pbConnectionCheck.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)));
            this.pbConnectionCheck.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pbConnectionCheck.BackgroundImage")));
            this.pbConnectionCheck.Location = new System.Drawing.Point(654, 14);
            // 
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.panelMenu.Controls.Add(this.btnUserGuide);
            this.panelMenu.Controls.Add(this.btnPasMenu);
            this.panelMenu.Controls.Add(this.btnRegMenu);
            this.panelMenu.Controls.Add(this.btnAuthMenu);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenu.Location = new System.Drawing.Point(0, 59);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(222, 382);
            this.panelMenu.TabIndex = 14;
            // 
            // btnUserGuide
            // 
            this.btnUserGuide.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnUserGuide.FlatAppearance.BorderSize = 0;
            this.btnUserGuide.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUserGuide.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnUserGuide.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnUserGuide.Image = global::Test.Properties.Resources.iconDocument;
            this.btnUserGuide.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUserGuide.Location = new System.Drawing.Point(0, 240);
            this.btnUserGuide.Name = "btnUserGuide";
            this.btnUserGuide.Padding = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.btnUserGuide.Size = new System.Drawing.Size(222, 80);
            this.btnUserGuide.TabIndex = 14;
            this.btnUserGuide.Text = "  Руководство";
            this.btnUserGuide.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUserGuide.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnUserGuide.UseVisualStyleBackColor = true;
            this.btnUserGuide.Click += new System.EventHandler(this.BtnUserGuide_Click);
            // 
            // btnPasMenu
            // 
            this.btnPasMenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnPasMenu.FlatAppearance.BorderSize = 0;
            this.btnPasMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPasMenu.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnPasMenu.ForeColor = System.Drawing.Color.White;
            this.btnPasMenu.Image = global::Test.Properties.Resources.iconBlockedUser;
            this.btnPasMenu.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPasMenu.Location = new System.Drawing.Point(0, 160);
            this.btnPasMenu.Name = "btnPasMenu";
            this.btnPasMenu.Padding = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.btnPasMenu.Size = new System.Drawing.Size(222, 80);
            this.btnPasMenu.TabIndex = 10;
            this.btnPasMenu.Text = "  Восстановление пароля";
            this.btnPasMenu.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPasMenu.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnPasMenu.UseVisualStyleBackColor = true;
            this.btnPasMenu.Click += new System.EventHandler(this.BtnPasMenu_Click);
            // 
            // btnRegMenu
            // 
            this.btnRegMenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnRegMenu.FlatAppearance.BorderSize = 0;
            this.btnRegMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegMenu.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnRegMenu.ForeColor = System.Drawing.Color.White;
            this.btnRegMenu.Image = global::Test.Properties.Resources.iconRegistration;
            this.btnRegMenu.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRegMenu.Location = new System.Drawing.Point(0, 80);
            this.btnRegMenu.Name = "btnRegMenu";
            this.btnRegMenu.Padding = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.btnRegMenu.Size = new System.Drawing.Size(222, 80);
            this.btnRegMenu.TabIndex = 13;
            this.btnRegMenu.Text = "  Регистрация";
            this.btnRegMenu.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRegMenu.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnRegMenu.UseVisualStyleBackColor = true;
            this.btnRegMenu.Click += new System.EventHandler(this.BtnRegMenu_Click);
            // 
            // btnAuthMenu
            // 
            this.btnAuthMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(109)))), ((int)(((byte)(228)))));
            this.btnAuthMenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnAuthMenu.FlatAppearance.BorderSize = 0;
            this.btnAuthMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAuthMenu.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnAuthMenu.ForeColor = System.Drawing.Color.White;
            this.btnAuthMenu.Image = global::Test.Properties.Resources.iconUser;
            this.btnAuthMenu.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAuthMenu.Location = new System.Drawing.Point(0, 0);
            this.btnAuthMenu.Name = "btnAuthMenu";
            this.btnAuthMenu.Padding = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.btnAuthMenu.Size = new System.Drawing.Size(222, 80);
            this.btnAuthMenu.TabIndex = 12;
            this.btnAuthMenu.Text = "  Авторизация";
            this.btnAuthMenu.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAuthMenu.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAuthMenu.UseVisualStyleBackColor = false;
            this.btnAuthMenu.Click += new System.EventHandler(this.BtnAuthMenu_Click);
            // 
            // panelForm
            // 
            this.panelForm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(60)))), ((int)(((byte)(99)))));
            this.panelForm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelForm.Location = new System.Drawing.Point(222, 59);
            this.panelForm.Name = "panelForm";
            this.panelForm.Size = new System.Drawing.Size(568, 382);
            this.panelForm.TabIndex = 15;
            // 
            // imgList
            // 
            this.imgList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imgList.ImageStream")));
            this.imgList.TransparentColor = System.Drawing.Color.Transparent;
            this.imgList.Images.SetKeyName(0, "icons8-сильный-коннект-30.png");
            this.imgList.Images.SetKeyName(1, "icons8-нет-коннекта-30.png");
            // 
            // AuthenticationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(790, 441);
            this.Controls.Add(this.panelForm);
            this.Controls.Add(this.panelMenu);
            this.Name = "AuthenticationForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Controls.SetChildIndex(this.panelMenu, 0);
            this.Controls.SetChildIndex(this.panelForm, 0);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbConnectionCheck)).EndInit();
            this.panelMenu.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.Button btnPasMenu;
        private System.Windows.Forms.Button btnRegMenu;
        private System.Windows.Forms.Button btnAuthMenu;
        private System.Windows.Forms.Panel panelForm;
        private System.Windows.Forms.Button btnUserGuide;
        private System.Windows.Forms.ImageList imgList;
    }
}

