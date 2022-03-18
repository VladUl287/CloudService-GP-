using System.Net;
using System.Net.Mail;
using System.Threading.Tasks;

namespace Test.Logic
{
    public class EmailWorker
    {
        private static readonly string fromEmail = "cloudstoragepou@gmail.com";
        private static readonly string password = "cloudstorage111";

        public static async Task Send(string email, string subject, string bodyHtml)
        {
            var from = new MailAddress(fromEmail, "GroupProjectPOU");
            var to = new MailAddress(email);
            var m = new MailMessage(from, to)
            {
                Subject = subject,
                Body = bodyHtml,
                IsBodyHtml = true
            };

            var smtp = new SmtpClient("smtp.gmail.com", 587)
            {
                Credentials = new NetworkCredential(fromEmail, password),
                EnableSsl = true,
                Timeout = 5000
            };

            try
            {
                await smtp.SendMailAsync(m);
            }
            catch (System.Exception)
            {
                CustomBox.Show("Ошибка. Проверьте подключение к интернету.");
            }
        }
    }
}