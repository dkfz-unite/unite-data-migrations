using Microsoft.EntityFrameworkCore.Design;
using Unite.Data.Migrations.Configuration.Options;
using Unite.Data.Services;

namespace Unite.Data.Migrations
{
    public class UniteDbContextFactory: IDesignTimeDbContextFactory<UniteDbContext>
    {
        public UniteDbContext CreateDbContext(string[] args)
        {
            var options = new SqlOptions();
            var dbContext = new UniteDbContext(options);

            return dbContext;
        }
    }
}
