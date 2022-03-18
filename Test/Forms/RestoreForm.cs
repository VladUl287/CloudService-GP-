using System;
using System.Windows.Forms;
using Test.Logic;
using Test.Repositories;
using Test.Validation;

namespace Test
{
    public partial class RestoreForm : Form
    {
        private readonly UserRepository userRepository;

        public RestoreForm()
        {
            InitializeComponent();
            userRepository = new UserRepository();
        }

        private async void BtnRestore_Click(object sender, EventArgs e)
        {
            if (!InternetConnetion.Check())
            {
                CustomBox.Show("Нет подключения к интернету.");
                return;
            }

            var result = await userRepository.GetByIdent(tbRestore.Text).ConfigureAwait(false);

            var user = result.Item1;
            var exception = result.Item2;

            if (user != null)
            {
                user.Password = PasswordWorker.Generate();
                await userRepository.Update(user);

                string subject = "Оповещение о восстановлении пароля.";
                string body = $"<h2>Ваш пароль был сброшен.</h2><br><p>Ваш новый пароль: {user.Password}</p>";
                await EmailWorker.Send(user.Email, subject, body);
                CustomBox.Show("На почту отправлено сообщение о восстановлении пароля.");
            }
            else if (exception)
            {
                CustomBox.Show("Ошибка восстановления пароля. Проверьте подключение к интернету.");
            }
            else
            {
                CustomBox.Show("Пользователь с таким email/логин не найден.");
            }
        }
    }
}