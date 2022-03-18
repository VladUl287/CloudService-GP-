using System;
using System.Configuration;
using System.Reflection;
using System.Windows.Forms;

namespace Test
{
    internal static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        private static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            var configuration = ConfigurationManager.OpenExeConfiguration(Assembly.GetExecutingAssembly().Location);
            var isRemember = Convert.ToBoolean(configuration.AppSettings.Settings["isRemember"].Value);
            var isAuthorize = Convert.ToBoolean(configuration.AppSettings.Settings["isAuthorize"].Value);
            var isAutonomously = Convert.ToBoolean(configuration.AppSettings.Settings["isAutonomously"].Value);
            if (!isRemember && !isAuthorize)
            {
                Application.Run(new AuthenticationForm());
            }
            else if (isRemember || isAuthorize)
            {
                Application.Run(new MainForm(isAutonomously));
            }
        }
    }
}