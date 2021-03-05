using System;

namespace Unite.Data.Migrations.Configuration
{
    public static class EnvironmentConfig
    {
        private static string _defaultSqlHost = "localhost";
        private static string _defaultSqlDatabase = "unite";
        private static string _defaultSqlUser = "root";
        private static string _defaultSqlPassword = "Long-p@55w0rd";

        public static string SqlHost => GetEnvironmentVariable("UNITE_SQL_HOST", _defaultSqlHost);
        public static string SqlDatabase = GetEnvironmentVariable("UNITE_SQL_DATABASE", _defaultSqlDatabase);
        public static string SqlUser => GetEnvironmentVariable("UNITE_SQL_USER", _defaultSqlUser);
        public static string SqlPassword = GetEnvironmentVariable("UNITE_SQL_PASSWORD", _defaultSqlPassword);

        private static string GetEnvironmentVariable(string variable, string defaultValue = null)
        {
            var value = Environment.GetEnvironmentVariable(variable);

            return value ?? defaultValue;
        }
    }
}
