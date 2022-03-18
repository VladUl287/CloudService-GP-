using System.Configuration;
using System.Reflection;
using Test.Models;

namespace Test
{
    public static class Reflection
    {
        private static readonly Configuration configuration = ConfigurationManager.OpenExeConfiguration(Assembly.GetExecutingAssembly().Location);

        public static void RefreshConfig(bool remember = false, bool authorize = false, bool admin = false, bool auto = false, string email = "", string password = "")
        {
            configuration.AppSettings.Settings["email"].Value = email;
            configuration.AppSettings.Settings["password"].Value = password;
            configuration.AppSettings.Settings["isAdmin"].Value = admin.ToString();
            configuration.AppSettings.Settings["isRemember"].Value = remember.ToString();
            configuration.AppSettings.Settings["isAutonomously"].Value = auto.ToString();
            configuration.AppSettings.Settings["isAuthorize"].Value = authorize.ToString();

            configuration.Save();
            ConfigurationManager.RefreshSection("appSettings");

            Config.Refresh();
        }

        public static void RefreshSettings(AppSettings appSettings)
        {
            configuration.AppSettings.Settings["pathStorage"].Value = appSettings.PathStorage;
            configuration.AppSettings.Settings["encryption"].Value = appSettings.Encryption.ToString();
            configuration.AppSettings.Settings["deleteInsert"].Value = appSettings.DeleteInsert.ToString();
            configuration.AppSettings.Settings["deleteExtract"].Value = appSettings.DeleteExtract.ToString();
            configuration.AppSettings.Settings["replaceInsertCloud"].Value = appSettings.ReplaceInsertCloud.ToString();
            configuration.AppSettings.Settings["replaceInsertLocal"].Value = appSettings.ReplaceInsertLocal.ToString();

            configuration.Save();
            ConfigurationManager.RefreshSection("appSettings");

            Settings.Refresh();
        }
    }
}