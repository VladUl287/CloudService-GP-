using MySql.Data.MySqlClient;

namespace Test.Database
{
    public static class DatabaseContext
    {
        public static readonly MySqlConnection Connection;

        static DatabaseContext()
        {
            string server = "141.8.193.236";
            string database = "f0591567_groupProject";
            string uid = "f0591567_groupProject";
            string password = "emxuriveda";

            string connectionString = $"SERVER={server}; Port=3306; DATABASE={database}; UID={uid}; PASSWORD={password}; Connection Timeout=1";

            Connection = new MySqlConnection(connectionString);
        }
    }
}