using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using Test.Forms;
using Test.Logic;
using Test.Validation;

namespace Test
{
    public partial class AuthenticationForm : CustomForm
    {
        private Button currentButton;
        private Form activeForm;

        public AuthenticationForm()
        {
            InitializeComponent();
            BtnAuthMenu_Click(btnAuthMenu, null);
        }

        private void ActivateButton(object btnSender)
        {
            if (btnSender != null && currentButton != (Button)btnSender)
            {
                DisableButton();
                currentButton = (Button)btnSender;
                currentButton.BackColor = Color.FromArgb(242, 109, 228);
                currentButton.ForeColor = Color.White;
            }
        }

        private void DisableButton()
        {
            foreach (Control previousBtn in panelMenu.Controls)
            {
                if (previousBtn.GetType() == typeof(Button))
                {
                    previousBtn.BackColor = Color.FromArgb(51, 51, 76);
                    previousBtn.ForeColor = Color.Gainsboro;
                }
            }
        }

        private void OpenForm(Form childForm, object btnSender)
        {
            if (true)
            {
            }
            if (activeForm != null)
            {
                activeForm.Close();
                activeForm.Dispose();
                panelForm.Controls.Clear();
            }
            ActivateButton(btnSender);
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.Dock = DockStyle.Fill;
            panelForm.Controls.Add(childForm);
            childForm.Show();
        }

        private void BtnAuthMenu_Click(object sender, EventArgs e)
        {
            OpenForm(new AuthorizationForm(), sender);
        }

        private void BtnRegMenu_Click(object sender, EventArgs e)
        {
            if (!InternetConnetion.Check())
            {
                CustomBox.Show("Необходимо подключение к интернету.");
                return;
            }
            OpenForm(new RegistrationForm(), sender);
        }

        private void BtnPasMenu_Click(object sender, EventArgs e)
        {
            if (!InternetConnetion.Check())
            {
                CustomBox.Show("Необходимо подключение к интернету.");
                return;
            }
            OpenForm(new RestoreForm(), sender);
        }

        private void BtnUserGuide_Click(object sender, EventArgs e)
        {
            var form = new InfoForm("Руководство пользователя", $"{Directory.GetCurrentDirectory()}\\userGuide.rtf");
            form.ShowDialog();
        }
    }
}