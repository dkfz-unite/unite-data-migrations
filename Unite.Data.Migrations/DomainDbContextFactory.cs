using Microsoft.EntityFrameworkCore.Design;
using Unite.Data.Migrations.Configuration.Options;
using Unite.Data.Services;

namespace Unite.Data.Migrations
{
    public class DomainDbContextFactory : IDesignTimeDbContextFactory<DomainDbContext>
    {
        public DomainDbContext CreateDbContext(string[] args)
        {
            var options = new SqlOptions();
            var dbContext = new DomainDbContext(options);

            return dbContext;
        }
    }
}
