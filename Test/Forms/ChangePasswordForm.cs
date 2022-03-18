using System;
using System.Windows.Forms;
using Test.Logic;
using Test.Models;
using Test.Repositories;

namespace Test.Forms
{
    public partial class ChangePasswordForm : Form
    {
        private readonly UserRepository repository;

        public ChangePasswordForm()
        {
            InitializeComponent();
            repository = new UserRepository();
        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        private async void BtnChangePassword_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(tbOldPassword.Text) && !string.IsNullOrWhiteSpace(tbNewPassword.Text) &&
                tbOldPassword.Text.Length > 5 && tbNewPassword.Text.Length > 5)
            {
                var result = await repository.GetByIdent(Config.Email);
                var user = result.Item1;

                if (user != null)
                {
                    if (tbOldPassword.Text == user.Password)
                    {
                        if (tbOldPassword.Text == tbNewPassword.Text)
                        {
                            CustomBox.Show("Старый и новый пароль совпадают.");
                            return;
                        }
                        user.Password = tbNewPassword.Text;
                        await repository.Update(user);
                        tbNewPassword.Text = tbOldPassword.Text = string.Empty;
                    }
                    else
                    {
                        CustomBox.Show("Неверный старый пароль.");
                    }
                }
            }
        }
    }
}