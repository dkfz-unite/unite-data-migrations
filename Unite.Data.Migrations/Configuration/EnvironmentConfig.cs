using System;

namespace Unite.Data.Migrations.Configuration
{
    public static class EnvironmentConfig
    {
        private static string _defaultMySqlHost = "localhost";
        private static string _defaultMySqlDatabase = "unite";
        private static string _defaultMySqlUser = "root";
        private static string _defaultMySqlPassword = "12345";

        public static string MySqlHost => GetEnvironmentVariable("UNITE_MYSQL_HOST", _defaultMySqlHost);
        public static string MySqlDatabase = GetEnvironmentVariable("UNITE_MYSQL_DATABASE", _defaultMySqlDatabase);
        public static string MySqlUser => GetEnvironmentVariable("UNITE_MYSQL_USER", _defaultMySqlUser);
        public static string MySqlPassword = GetEnvironmentVariable("UNITE_MYSQL_PASSWORD", _defaultMySqlPassword);

        private static string GetEnvironmentVariable(string variable, string defaultValue = null)
        {
            var value = Environment.GetEnvironmentVariable(variable);

            return value ?? defaultValue;
        }
    }
}
