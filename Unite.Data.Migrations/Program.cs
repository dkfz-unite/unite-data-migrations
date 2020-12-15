using System;
using Microsoft.EntityFrameworkCore;
using Unite.Data.Migrations.Configuration.Options;
using Unite.Data.Services;

namespace Unite.Data.Migrations
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine($"[{DateTime.UtcNow}] - Migration service started");


            Console.WriteLine($"[{DateTime.UtcNow}] - Configuring migration service");

            var options = new MySqlOptions();

            Console.WriteLine($"[{DateTime.UtcNow}] - Host: {options.Host}");
            Console.WriteLine($"[{DateTime.UtcNow}] - Database: {options.Database}");



            Console.WriteLine($"[{DateTime.UtcNow}] - Creating database context...");

            var dbContext = new UniteDbContext(options);

            Console.WriteLine($"[{DateTime.UtcNow}] - Database context created");



            Console.WriteLine($"[{DateTime.UtcNow}] - Starting migration...");

            try
            {
                dbContext.Database.Migrate();

                Console.WriteLine($"[{DateTime.UtcNow}] - Migration completed successfully");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"[{DateTime.UtcNow}] - Migration failed");
                Console.WriteLine(ex.Message);
            }

            Console.WriteLine($"[{DateTime.UtcNow}] - Migration service stopped");
        }
    }
}
