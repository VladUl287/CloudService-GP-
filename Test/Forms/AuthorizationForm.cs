using System;
using System.Windows.Forms;
using Test.Logic;
using Test.Repositories;
using Test.Validation;

namespace Test
{
    public partial class AuthorizationForm : Form
    {
        private readonly UserRepository userRepository;

        public AuthorizationForm()
        {
            InitializeComponent();
            userRepository = new UserRepository();
        }

        private void BtnShowPassword_Click(object sender, EventArgs e)
        {
            if (!tbPassword.UseSystemPasswordChar)
            {
                tbPassword.UseSystemPasswordChar = true;
                btnTooglePass.BackgroundImage = Properties.Resources.iconShowPassword;
            }
            else
            {
                tbPassword.UseSystemPasswordChar = false;
                btnTooglePass.BackgroundImage = Properties.Resources.iconHidePassword;
            }
        }

        private async void BtnLogin_Click(object sender, EventArgs e)
        {
            if (cbAutonomously.Checked)
            {
                AutrorizeAutonomously();
                return;
            }

            if (!InternetConnetion.Check())
            {
                var autonomously = CustomBox.ShowDialog(this, "Нет подключения к интернету. Хотите попробовать авторизироваться автономно?", typeBtn: TypeButton.YesNo);
                if (autonomously == DialogResult.Yes)
                {
                    AutrorizeAutonomously();
                }
                return;
            }

            var result = await userRepository.Get(tbUsername.Text, tbPassword.Text).ConfigureAwait(false);

            var user = result.Item1;
            var exception = result.Item2;

            if (user != null)
            {
                Reflection.RefreshConfig(cbRemember.Checked, true, user.IsAdmin, false, user.Email, user.Password);
                Application.Restart();
            }
            else if (exception)
            {
                CustomBox.Show("Ошибка авторизации. Проверьте подключение к интернету.");
            }
            else
            {
                CustomBox.Show("Неверный логин/email или пароль.");
            }
        }

        private void AutrorizeAutonomously()
        {
            Reflection.RefreshConfig(cbRemember.Checked, true, false, true, tbUsername.Text, tbPassword.Text);
            Application.Restart();
        }
    }
}