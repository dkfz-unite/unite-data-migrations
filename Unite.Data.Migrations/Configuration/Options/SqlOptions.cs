﻿using Unite.Data.Services.Configuration.Options;

namespace Unite.Data.Migrations.Configuration.Options
{
    public class SqlOptions : ISqlOptions
    {
        public string Host => EnvironmentConfig.SqlHost;
        public string Database => EnvironmentConfig.SqlDatabase;
        public string User => EnvironmentConfig.SqlUser;
        public string Password => EnvironmentConfig.SqlPassword;
    }
}
