using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Windows.Forms;
using Test.Logic;
using Test.Models;
using Test.Repositories;
using Test.Validation;

namespace Test
{
    public partial class RegistrationForm : Form
    {
        private static readonly char[] numbersArray = new char[] { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9' };
        private static readonly Random random = new Random();
        private static readonly string ch = "⛔";
        private readonly UserRepository userRepository;
        private string code = string.Empty;
        private int seconds = 60;
        private User user = null;

        public RegistrationForm()
        {
            InitializeComponent();
            userRepository = new UserRepository();
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            seconds--;
            lbTime.Text = $"Код доступен: {seconds}с.";
            if (seconds <= 0)
            {
                timer.Stop();

                code = string.Empty;
                btnSend.Visible = btnSend.Enabled = true;
            }
        }

        private void BtnRegister_Click(object sender, EventArgs e)
        {
            btnRegister.Enabled = false;

            if (!InternetConnetion.Check())
            {
                CustomBox.Show("Необходимо подключение к интернету.");
                btnRegister.Enabled = true;
                return;
            }

            var cookie = webBrowserCapthca.Document.Cookie;
            if (cookie == null)
            {
                webBrowserCapthca.Refresh();
                btnRegister.Enabled = true;
                return;
            }

            var text = cookie.Substring(cookie.Length - 5);

            user = new User
            {
                Email = tbEmail.Text,
                Name = tbName.Text,
                Login = tbLogin.Text,
                Password = tbRegPassword.Text,
                Phone = string.IsNullOrEmpty(tbPhone.Text) ? null : tbPhone.Text
            };

            var results = new List<ValidationResult>();
            var context = new ValidationContext(user);
            if (!Validator.TryValidateObject(user, context, results, true) || tbConfirmPas.Text != tbRegPassword.Text)
            {
                lbValidation.Text = ch;

                string errors = string.Join("\n", results);

                if (tbConfirmPas.Text != tbRegPassword.Text)
                {
                    errors += "Пароли не совпадают.";
                }

                toolTipErrors.SetToolTip(lbValidation, errors);
                lbValidation.Visible = true;
                btnRegister.Enabled = true;

                return;
            }

            lbValidation.Visible = false;

            if (text != tbCaptcha.Text)
            {
                webBrowserCapthca.Refresh();
                btnRegister.Enabled = true;
                return;
            }

            codePanel.Visible = true;
            codePanel.Dock = DockStyle.Fill;
            codePanel.BringToFront();

            BtnSend_Click(null, null);
        }

        private void BtnCapchaReload_Click(object sender, EventArgs e)
        {
            webBrowserCapthca.Refresh();
        }

        private async void BtnAccept_Click(object sender, EventArgs e)
        {
            if (code == tbCode.Text)
            {
                var isCreate = await userRepository.Create(user);

                if (string.IsNullOrEmpty(isCreate))
                {
                    CustomBox.Show("Регистрация упешна.");

                    tbEmail.Text = tbName.Text = tbLogin.Text = tbRegPassword.Text =
                        tbConfirmPas.Text = tbPhone.Text = tbCaptcha.Text = string.Empty;

                    BtnCancel_Click(null, null);
                }
                else
                {
                    CustomBox.Show(isCreate);
                }

                tbCaptcha.Text = string.Empty;
                btnRegister.Enabled = true;
                webBrowserCapthca.Refresh();
            }
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            if (codePanel.Visible)
            {
                codePanel.Visible = false;
                tbCode.Text = code = string.Empty;
                btnRegister.Enabled = true;
            }

            lbTime.Text = "Код доступен: 60с.";
            timer.Stop();
        }

        private async void BtnSend_Click(object sender, EventArgs e)
        {
            timer.Stop();

            code = new string(Enumerable.Repeat(numbersArray, 4).Select(s => s[random.Next(s.Length)]).ToArray());

            string body = "<h1>Уведомление о регистрации в облачном хранилище CloudStoragePOU</h1><br>" +
                $"<p>Если вы не пытались зарегистрировать аккаунт, проигнорируёте это письмо.<br>Код авторизации {code}</p>";

            seconds = 60;
            timer.Start();

            btnSend.Visible = btnSend.Enabled = false;

            await EmailWorker.Send(user.Email, "Уведомление о регистрации", body).ConfigureAwait(false);
        }

        private void RegistrationForm_Shown(object sender, EventArgs e)
        {
            webBrowserCapthca.Refresh();
        }
    }
}