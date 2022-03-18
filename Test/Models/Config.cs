using System;
using System.Configuration;
using System.Reflection;

namespace Test.Models
{
    public static class Config
    {
        static Config()
        {
            Refresh();
        }

        public static string Email { get; private set; }
        public static string Password { get; private set; }
        public static bool IsAdmin { get; private set; }
        public static bool IsRemember { get; private set; }
        public static bool IsAuthorize { get; private set; }

        public static void Refresh()
        {
            var configuration = ConfigurationManager.OpenExeConfiguration(Assembly.GetExecutingAssembly().Location);
            Email = configuration.AppSettings.Settings["email"].Value;
            Password = configuration.AppSettings.Settings["password"].Value;
            IsAdmin = Convert.ToBoolean(configuration.AppSettings.Settings["isAdmin"].Value);
            IsRemember = Convert.ToBoolean(configuration.AppSettings.Settings["isRemember"].Value);
            IsAuthorize = Convert.ToBoolean(configuration.AppSettings.Settings["isAuthorize"].Value);
        }
    }
}