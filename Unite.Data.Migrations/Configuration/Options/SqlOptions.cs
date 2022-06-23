using Unite.Data.Services.Configuration.Options;

namespace Unite.Data.Migrations.Configuration.Options;

public class SqlOptions : ISqlOptions
{
    public string Host => EnvironmentConfig.SqlHost;
    public string Port => EnvironmentConfig.SqlPort;
    public string User => EnvironmentConfig.SqlUser;
    public string Password => EnvironmentConfig.SqlPassword;
}
