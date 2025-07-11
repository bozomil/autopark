using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using System.Configuration;
using mariadb.Helpers;

namespace mariadb.Data
{
    public class AutoparkDbContextFactory : IDesignTimeDbContextFactory<AutoparkDbContext>
    {
        public AutoparkDbContext CreateDbContext(string[] args)
        {
            var connectionString = ConfigurationHelper.GetConnectionString("AutoparkContext");

            var optionsBuilder = new DbContextOptionsBuilder<AutoparkDbContext>();
            optionsBuilder.UseMySql(connectionString, ServerVersion.AutoDetect(connectionString));

            return new AutoparkDbContext(optionsBuilder.Options);
        }
    }
}
