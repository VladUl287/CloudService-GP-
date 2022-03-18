using System;
using System.Configuration;
using System.IO;
using System.Reflection;

namespace Test
{
    public static class Settings
    {
        static Settings()
        {
            Refresh();
        }

        public static string PathStorage { get; private set; }
        public static bool Encryption { get; private set; }
        public static bool DeleteInsert { get; private set; }
        public static bool DeleteExtract { get; private set; }
        public static bool ReplaceInsertCloud { get; private set; }
        public static bool ReplaceInsertLocal { get; private set; }

        public static void Refresh()
        {
            var configuration = ConfigurationManager.OpenExeConfiguration(Assembly.GetExecutingAssembly().Location);
            var path = configuration.AppSettings.Settings["pathStorage"].Value;
            PathStorage = string.IsNullOrEmpty(path) ? Directory.GetCurrentDirectory() : path;
            Encryption = Convert.ToBoolean(configuration.AppSettings.Settings["encryption"].Value);
            DeleteInsert = Convert.ToBoolean(configuration.AppSettings.Settings["deleteInsert"].Value);
            DeleteExtract = Convert.ToBoolean(configuration.AppSettings.Settings["deleteExtract"].Value);
            ReplaceInsertCloud = Convert.ToBoolean(configuration.AppSettings.Settings["replaceInsertCloud"].Value);
            ReplaceInsertLocal = Convert.ToBoolean(configuration.AppSettings.Settings["replaceInsertLocal"].Value);
        }
    }
}