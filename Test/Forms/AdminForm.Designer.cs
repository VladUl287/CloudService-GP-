
namespace Test
{
    partial class AdminForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminForm));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgvUserList = new System.Windows.Forms.DataGridView();
            this.emailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.loginDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.passwordDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phoneDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IsAdmin = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.Delete = new System.Windows.Forms.DataGridViewButtonColumn();
            this.UpdateInfo = new System.Windows.Forms.DataGridViewButtonColumn();
            this.userBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tabControlAdmin = new System.Windows.Forms.TabControl();
            this.tabPageUsersInfo = new System.Windows.Forms.TabPage();
            this.tabPageCreateUser = new System.Windows.Forms.TabPage();
            this.lbAdmin = new System.Windows.Forms.Label();
            this.cbAdmin = new Test.CheckBoxControl.ControlCB();
            this.lbValidation = new System.Windows.Forms.Label();
            this.labelInformation = new System.Windows.Forms.Label();
            this.lbPhone = new System.Windows.Forms.Label();
            this.lbName = new System.Windows.Forms.Label();
            this.lbPassword = new System.Windows.Forms.Label();
            this.lbLogin = new System.Windows.Forms.Label();
            this.lbEmail = new System.Windows.Forms.Label();
            this.tbPhone = new System.Windows.Forms.TextBox();
            this.panelPhone = new System.Windows.Forms.Panel();
            this.tbName = new System.Windows.Forms.TextBox();
            this.panelName = new System.Windows.Forms.Panel();
            this.tbRegPassword = new System.Windows.Forms.TextBox();
            this.panelPassword = new System.Windows.Forms.Panel();
            this.tbLogin = new System.Windows.Forms.TextBox();
            this.panelLogin = new System.Windows.Forms.Panel();
            this.tbEmail = new System.Windows.Forms.TextBox();
            this.panelEmail = new System.Windows.Forms.Panel();
            this.btnRegister = new System.Windows.Forms.Button();
            this.pbLoading = new System.Windows.Forms.PictureBox();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.toolTipErrors = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbConnectionCheck)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUserList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.userBindingSource)).BeginInit();
            this.tabControlAdmin.SuspendLayout();
            this.tabPageUsersInfo.SuspendLayout();
            this.tabPageCreateUser.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbLoading)).BeginInit();
            this.SuspendLayout();
            // 
            // lbAppTitle
            // 
            this.lbAppTitle.Location = new System.Drawing.Point(3, 14);
            this.lbAppTitle.Size = new System.Drawing.Size(380, 31);
            this.lbAppTitle.Text = "Управление пользователями";
            // 
            // pictureBoxLogo
            // 
            this.pictureBoxLogo.Visible = false;
            // 
            // pbConnectionCheck
            // 
            this.pbConnectionCheck.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pbConnectionCheck.BackgroundImage")));
            this.pbConnectionCheck.Location = new System.Drawing.Point(664, 12);
            // 
            // dgvUserList
            // 
            this.dgvUserList.AllowUserToAddRows = false;
            this.dgvUserList.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(79)))), ((int)(((byte)(130)))));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            this.dgvUserList.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvUserList.AutoGenerateColumns = false;
            this.dgvUserList.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(60)))), ((int)(((byte)(99)))));
            this.dgvUserList.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvUserList.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvUserList.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(60)))), ((int)(((byte)(99)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.Info;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvUserList.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvUserList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUserList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.emailDataGridViewTextBoxColumn,
            this.loginDataGridViewTextBoxColumn,
            this.passwordDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn,
            this.phoneDataGridViewTextBoxColumn,
            this.IsAdmin,
            this.Delete,
            this.UpdateInfo});
            this.dgvUserList.DataSource = this.userBindingSource;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(101)))), ((int)(((byte)(161)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(109)))), ((int)(((byte)(228)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvUserList.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvUserList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvUserList.EnableHeadersVisualStyles = false;
            this.dgvUserList.Location = new System.Drawing.Point(3, 3);
            this.dgvUserList.Name = "dgvUserList";
            this.dgvUserList.RowHeadersVisible = false;
            this.dgvUserList.Size = new System.Drawing.Size(786, 350);
            this.dgvUserList.TabIndex = 0;
            this.dgvUserList.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvUserList_CellContentClick);
            // 
            // emailDataGridViewTextBoxColumn
            // 
            this.emailDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.emailDataGridViewTextBoxColumn.DataPropertyName = "Email";
            this.emailDataGridViewTextBoxColumn.HeaderText = "Email";
            this.emailDataGridViewTextBoxColumn.Name = "emailDataGridViewTextBoxColumn";
            // 
            // loginDataGridViewTextBoxColumn
            // 
            this.loginDataGridViewTextBoxColumn.DataPropertyName = "Login";
            this.loginDataGridViewTextBoxColumn.HeaderText = "Логин";
            this.loginDataGridViewTextBoxColumn.Name = "loginDataGridViewTextBoxColumn";
            // 
            // passwordDataGridViewTextBoxColumn
            // 
            this.passwordDataGridViewTextBoxColumn.DataPropertyName = "Password";
            this.passwordDataGridViewTextBoxColumn.HeaderText = "Пароль";
            this.passwordDataGridViewTextBoxColumn.Name = "passwordDataGridViewTextBoxColumn";
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Имя";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            // 
            // phoneDataGridViewTextBoxColumn
            // 
            this.phoneDataGridViewTextBoxColumn.DataPropertyName = "Phone";
            this.phoneDataGridViewTextBoxColumn.HeaderText = "Телефон";
            this.phoneDataGridViewTextBoxColumn.Name = "phoneDataGridViewTextBoxColumn";
            // 
            // IsAdmin
            // 
            this.IsAdmin.DataPropertyName = "IsAdmin";
            this.IsAdmin.HeaderText = "Администратор";
            this.IsAdmin.Name = "IsAdmin";
            // 
            // Delete
            // 
            this.Delete.DataPropertyName = "Id";
            this.Delete.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Delete.HeaderText = "";
            this.Delete.Name = "Delete";
            this.Delete.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Delete.Text = "Удалить";
            this.Delete.UseColumnTextForButtonValue = true;
            this.Delete.Width = 70;
            // 
            // UpdateInfo
            // 
            this.UpdateInfo.DataPropertyName = "Id";
            this.UpdateInfo.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.UpdateInfo.HeaderText = "";
            this.UpdateInfo.Name = "UpdateInfo";
            this.UpdateInfo.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.UpdateInfo.Text = "Обновить";
            this.UpdateInfo.UseColumnTextForButtonValue = true;
            this.UpdateInfo.Width = 70;
            // 
            // userBindingSource
            // 
            this.userBindingSource.DataSource = typeof(Test.Models.User);
            // 
            // tabControlAdmin
            // 
            this.tabControlAdmin.Controls.Add(this.tabPageUsersInfo);
            this.tabControlAdmin.Controls.Add(this.tabPageCreateUser);
            this.tabControlAdmin.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControlAdmin.DrawMode = System.Windows.Forms.TabDrawMode.OwnerDrawFixed;
            this.tabControlAdmin.Location = new System.Drawing.Point(0, 59);
            this.tabControlAdmin.Name = "tabControlAdmin";
            this.tabControlAdmin.SelectedIndex = 0;
            this.tabControlAdmin.Size = new System.Drawing.Size(800, 382);
            this.tabControlAdmin.TabIndex = 1;
            this.tabControlAdmin.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.TabControlAdmin_DrawItem);
            // 
            // tabPageUsersInfo
            // 
            this.tabPageUsersInfo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(60)))), ((int)(((byte)(99)))));
            this.tabPageUsersInfo.Controls.Add(this.dgvUserList);
            this.tabPageUsersInfo.ForeColor = System.Drawing.Color.White;
            this.tabPageUsersInfo.Location = new System.Drawing.Point(4, 22);
            this.tabPageUsersInfo.Name = "tabPageUsersInfo";
            this.tabPageUsersInfo.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageUsersInfo.Size = new System.Drawing.Size(792, 356);
            this.tabPageUsersInfo.TabIndex = 0;
            this.tabPageUsersInfo.Text = "Пользователи";
            // 
            // tabPageCreateUser
            // 
            this.tabPageCreateUser.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(60)))), ((int)(((byte)(99)))));
            this.tabPageCreateUser.Controls.Add(this.lbAdmin);
            this.tabPageCreateUser.Controls.Add(this.cbAdmin);
            this.tabPageCreateUser.Controls.Add(this.lbValidation);
            this.tabPageCreateUser.Controls.Add(this.labelInformation);
            this.tabPageCreateUser.Controls.Add(this.lbPhone);
            this.tabPageCreateUser.Controls.Add(this.lbName);
            this.tabPageCreateUser.Controls.Add(this.lbPassword);
            this.tabPageCreateUser.Controls.Add(this.lbLogin);
            this.tabPageCreateUser.Controls.Add(this.lbEmail);
            this.tabPageCreateUser.Controls.Add(this.tbPhone);
            this.tabPageCreateUser.Controls.Add(this.panelPhone);
            this.tabPageCreateUser.Controls.Add(this.tbName);
            this.tabPageCreateUser.Controls.Add(this.panelName);
            this.tabPageCreateUser.Controls.Add(this.tbRegPassword);
            this.tabPageCreateUser.Controls.Add(this.panelPassword);
            this.tabPageCreateUser.Controls.Add(this.tbLogin);
            this.tabPageCreateUser.Controls.Add(this.panelLogin);
            this.tabPageCreateUser.Controls.Add(this.tbEmail);
            this.tabPageCreateUser.Controls.Add(this.panelEmail);
            this.tabPageCreateUser.Controls.Add(this.btnRegister);
            this.tabPageCreateUser.Controls.Add(this.pbLoading);
            this.tabPageCreateUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tabPageCreateUser.ForeColor = System.Drawing.Color.White;
            this.tabPageCreateUser.Location = new System.Drawing.Point(4, 22);
            this.tabPageCreateUser.Name = "tabPageCreateUser";
            this.tabPageCreateUser.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageCreateUser.Size = new System.Drawing.Size(792, 356);
            this.tabPageCreateUser.TabIndex = 1;
            this.tabPageCreateUser.Text = "Создать";
            // 
            // lbAdmin
            // 
            this.lbAdmin.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbAdmin.AutoSize = true;
            this.lbAdmin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbAdmin.ForeColor = System.Drawing.Color.White;
            this.lbAdmin.Location = new System.Drawing.Point(229, 272);
            this.lbAdmin.Name = "lbAdmin";
            this.lbAdmin.Size = new System.Drawing.Size(131, 20);
            this.lbAdmin.TabIndex = 78;
            this.lbAdmin.Text = "Администратор";
            // 
            // cbAdmin
            // 
            this.cbAdmin.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.cbAdmin.AutoSize = true;
            this.cbAdmin.Location = new System.Drawing.Point(106, 268);
            this.cbAdmin.MinimumSize = new System.Drawing.Size(30, 22);
            this.cbAdmin.Name = "cbAdmin";
            this.cbAdmin.Size = new System.Drawing.Size(121, 28);
            this.cbAdmin.TabIndex = 77;
            this.cbAdmin.Text = "controlCB1";
            this.cbAdmin.UseVisualStyleBackColor = true;
            // 
            // lbValidation
            // 
            this.lbValidation.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lbValidation.AutoSize = true;
            this.lbValidation.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbValidation.ForeColor = System.Drawing.Color.Red;
            this.lbValidation.Location = new System.Drawing.Point(551, 308);
            this.lbValidation.Name = "lbValidation";
            this.lbValidation.Size = new System.Drawing.Size(0, 20);
            this.lbValidation.TabIndex = 76;
            // 
            // labelInformation
            // 
            this.labelInformation.AutoSize = true;
            this.labelInformation.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelInformation.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.labelInformation.Location = new System.Drawing.Point(5, 327);
            this.labelInformation.Name = "labelInformation";
            this.labelInformation.Size = new System.Drawing.Size(262, 20);
            this.labelInformation.TabIndex = 75;
            this.labelInformation.Text = "* - обязательное поле для ввода";
            // 
            // lbPhone
            // 
            this.lbPhone.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbPhone.AutoSize = true;
            this.lbPhone.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbPhone.ForeColor = System.Drawing.Color.White;
            this.lbPhone.Location = new System.Drawing.Point(10, 231);
            this.lbPhone.Name = "lbPhone";
            this.lbPhone.Size = new System.Drawing.Size(83, 20);
            this.lbPhone.TabIndex = 70;
            this.lbPhone.Text = "Телефон:";
            // 
            // lbName
            // 
            this.lbName.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbName.AutoSize = true;
            this.lbName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbName.ForeColor = System.Drawing.Color.White;
            this.lbName.Location = new System.Drawing.Point(49, 179);
            this.lbName.Name = "lbName";
            this.lbName.Size = new System.Drawing.Size(44, 20);
            this.lbName.TabIndex = 69;
            this.lbName.Text = "Имя:";
            // 
            // lbPassword
            // 
            this.lbPassword.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbPassword.AutoSize = true;
            this.lbPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbPassword.ForeColor = System.Drawing.Color.White;
            this.lbPassword.Location = new System.Drawing.Point(16, 128);
            this.lbPassword.Name = "lbPassword";
            this.lbPassword.Size = new System.Drawing.Size(77, 20);
            this.lbPassword.TabIndex = 67;
            this.lbPassword.Text = "Пароль*:";
            // 
            // lbLogin
            // 
            this.lbLogin.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbLogin.AutoSize = true;
            this.lbLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbLogin.ForeColor = System.Drawing.Color.White;
            this.lbLogin.Location = new System.Drawing.Point(28, 76);
            this.lbLogin.Name = "lbLogin";
            this.lbLogin.Size = new System.Drawing.Size(65, 20);
            this.lbLogin.TabIndex = 66;
            this.lbLogin.Text = "Логин*:";
            // 
            // lbEmail
            // 
            this.lbEmail.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbEmail.AutoSize = true;
            this.lbEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbEmail.ForeColor = System.Drawing.Color.White;
            this.lbEmail.Location = new System.Drawing.Point(35, 24);
            this.lbEmail.Name = "lbEmail";
            this.lbEmail.Size = new System.Drawing.Size(58, 20);
            this.lbEmail.TabIndex = 65;
            this.lbEmail.Text = "Email*:";
            // 
            // tbPhone
            // 
            this.tbPhone.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.tbPhone.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(60)))), ((int)(((byte)(99)))));
            this.tbPhone.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbPhone.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbPhone.ForeColor = System.Drawing.Color.White;
            this.tbPhone.Location = new System.Drawing.Point(106, 222);
            this.tbPhone.Multiline = true;
            this.tbPhone.Name = "tbPhone";
            this.tbPhone.Size = new System.Drawing.Size(675, 26);
            this.tbPhone.TabIndex = 64;
            // 
            // panelPhone
            // 
            this.panelPhone.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.panelPhone.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(109)))), ((int)(((byte)(228)))));
            this.panelPhone.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.panelPhone.ForeColor = System.Drawing.Color.White;
            this.panelPhone.Location = new System.Drawing.Point(107, 250);
            this.panelPhone.Name = "panelPhone";
            this.panelPhone.Size = new System.Drawing.Size(674, 1);
            this.panelPhone.TabIndex = 63;
            // 
            // tbName
            // 
            this.tbName.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.tbName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(60)))), ((int)(((byte)(99)))));
            this.tbName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbName.ForeColor = System.Drawing.Color.White;
            this.tbName.Location = new System.Drawing.Point(106, 170);
            this.tbName.MaxLength = 150;
            this.tbName.Multiline = true;
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(675, 26);
            this.tbName.TabIndex = 62;
            // 
            // panelName
            // 
            this.panelName.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.panelName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(109)))), ((int)(((byte)(228)))));
            this.panelName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.panelName.ForeColor = System.Drawing.Color.White;
            this.panelName.Location = new System.Drawing.Point(106, 198);
            this.panelName.Name = "panelName";
            this.panelName.Size = new System.Drawing.Size(675, 1);
            this.panelName.TabIndex = 61;
            // 
            // tbRegPassword
            // 
            this.tbRegPassword.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.tbRegPassword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(60)))), ((int)(((byte)(99)))));
            this.tbRegPassword.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbRegPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbRegPassword.ForeColor = System.Drawing.Color.White;
            this.tbRegPassword.Location = new System.Drawing.Point(106, 118);
            this.tbRegPassword.Multiline = true;
            this.tbRegPassword.Name = "tbRegPassword";
            this.tbRegPassword.Size = new System.Drawing.Size(671, 26);
            this.tbRegPassword.TabIndex = 58;
            this.tbRegPassword.UseSystemPasswordChar = true;
            // 
            // panelPassword
            // 
            this.panelPassword.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.panelPassword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(109)))), ((int)(((byte)(228)))));
            this.panelPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.panelPassword.ForeColor = System.Drawing.Color.White;
            this.panelPassword.Location = new System.Drawing.Point(106, 147);
            this.panelPassword.Name = "panelPassword";
            this.panelPassword.Size = new System.Drawing.Size(674, 1);
            this.panelPassword.TabIndex = 57;
            // 
            // tbLogin
            // 
            this.tbLogin.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.tbLogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(60)))), ((int)(((byte)(99)))));
            this.tbLogin.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbLogin.ForeColor = System.Drawing.Color.White;
            this.tbLogin.Location = new System.Drawing.Point(106, 66);
            this.tbLogin.Multiline = true;
            this.tbLogin.Name = "tbLogin";
            this.tbLogin.Size = new System.Drawing.Size(675, 26);
            this.tbLogin.TabIndex = 56;
            // 
            // panelLogin
            // 
            this.panelLogin.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.panelLogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(109)))), ((int)(((byte)(228)))));
            this.panelLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.panelLogin.ForeColor = System.Drawing.Color.White;
            this.panelLogin.Location = new System.Drawing.Point(106, 95);
            this.panelLogin.Name = "panelLogin";
            this.panelLogin.Size = new System.Drawing.Size(675, 1);
            this.panelLogin.TabIndex = 55;
            // 
            // tbEmail
            // 
            this.tbEmail.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.tbEmail.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(60)))), ((int)(((byte)(99)))));
            this.tbEmail.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbEmail.ForeColor = System.Drawing.Color.White;
            this.tbEmail.Location = new System.Drawing.Point(106, 14);
            this.tbEmail.MaxLength = 150;
            this.tbEmail.Multiline = true;
            this.tbEmail.Name = "tbEmail";
            this.tbEmail.Size = new System.Drawing.Size(675, 26);
            this.tbEmail.TabIndex = 54;
            // 
            // panelEmail
            // 
            this.panelEmail.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.panelEmail.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(109)))), ((int)(((byte)(228)))));
            this.panelEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.panelEmail.ForeColor = System.Drawing.Color.White;
            this.panelEmail.Location = new System.Drawing.Point(106, 43);
            this.panelEmail.Name = "panelEmail";
            this.panelEmail.Size = new System.Drawing.Size(675, 1);
            this.panelEmail.TabIndex = 53;
            // 
            // btnRegister
            // 
            this.btnRegister.AutoSize = true;
            this.btnRegister.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(109)))), ((int)(((byte)(228)))));
            this.btnRegister.FlatAppearance.BorderSize = 0;
            this.btnRegister.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegister.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnRegister.ForeColor = System.Drawing.Color.White;
            this.btnRegister.Location = new System.Drawing.Point(579, 313);
            this.btnRegister.Name = "btnRegister";
            this.btnRegister.Size = new System.Drawing.Size(204, 38);
            this.btnRegister.TabIndex = 27;
            this.btnRegister.Text = "Создать пользователя";
            this.btnRegister.UseVisualStyleBackColor = false;
            this.btnRegister.Click += new System.EventHandler(this.BtnCreate_Click);
            // 
            // pbLoading
            // 
            this.pbLoading.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.pbLoading.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(60)))), ((int)(((byte)(99)))));
            this.pbLoading.Image = global::Test.Properties.Resources.gifLoading;
            this.pbLoading.Location = new System.Drawing.Point(538, 313);
            this.pbLoading.Name = "pbLoading";
            this.pbLoading.Size = new System.Drawing.Size(38, 38);
            this.pbLoading.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbLoading.TabIndex = 47;
            this.pbLoading.TabStop = false;
            this.pbLoading.Visible = false;
            // 
            // timer
            // 
            this.timer.Interval = 3000;
            // 
            // toolTipErrors
            // 
            this.toolTipErrors.IsBalloon = true;
            // 
            // AdminForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(60)))), ((int)(((byte)(99)))));
            this.ClientSize = new System.Drawing.Size(800, 441);
            this.Controls.Add(this.tabControlAdmin);
            this.Name = "AdminForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AdminForm";
            this.Shown += new System.EventHandler(this.AdminForm_Shown);
            this.Controls.SetChildIndex(this.tabControlAdmin, 0);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbConnectionCheck)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUserList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.userBindingSource)).EndInit();
            this.tabControlAdmin.ResumeLayout(false);
            this.tabPageUsersInfo.ResumeLayout(false);
            this.tabPageCreateUser.ResumeLayout(false);
            this.tabPageCreateUser.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbLoading)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvUserList;
        private System.Windows.Forms.TabControl tabControlAdmin;
        private System.Windows.Forms.TabPage tabPageUsersInfo;
        private System.Windows.Forms.TabPage tabPageCreateUser;
        private System.Windows.Forms.Button btnRegister;
        private System.Windows.Forms.PictureBox pbLoading;
        private System.Windows.Forms.Label lbPhone;
        private System.Windows.Forms.Label lbPassword;
        private System.Windows.Forms.Label lbLogin;
        private System.Windows.Forms.Label lbEmail;
        private System.Windows.Forms.TextBox tbPhone;
        private System.Windows.Forms.Panel panelPhone;
        private System.Windows.Forms.Panel panelName;
        private System.Windows.Forms.TextBox tbRegPassword;
        private System.Windows.Forms.Panel panelPassword;
        private System.Windows.Forms.TextBox tbLogin;
        private System.Windows.Forms.Panel panelLogin;
        private System.Windows.Forms.TextBox tbEmail;
        private System.Windows.Forms.Panel panelEmail;
        private System.Windows.Forms.Label labelInformation;
        private System.Windows.Forms.Label lbName;
        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.Label lbValidation;
        private System.Windows.Forms.BindingSource userBindingSource;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.ToolTip toolTipErrors;
        private System.Windows.Forms.Label lbAdmin;
        private CheckBoxControl.ControlCB cbAdmin;
        private System.Windows.Forms.DataGridViewTextBoxColumn emailDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn loginDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn passwordDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn phoneDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn IsAdmin;
        private System.Windows.Forms.DataGridViewButtonColumn Delete;
        private System.Windows.Forms.DataGridViewButtonColumn UpdateInfo;
    }
}