using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using System.IO;

namespace PcColletion.Cms.IdentityCore
{


    public class DesignTimeIdentityDbContextFactory : IDesignTimeDbContextFactory<pcColletionDBContext>
    {


        public pcColletionDBContext CreateDbContext(string[] args)
        {
            IConfigurationRoot configuration = new ConfigurationBuilder()
              .SetBasePath(Directory.GetCurrentDirectory())
              .AddJsonFile("appsettings.json")
              .Build();

            var builder = new DbContextOptionsBuilder<pcColletionDBContext>();
            var connectionstring = configuration.GetConnectionString("DefaultConnection");
            builder.UseSqlServer(connectionstring);
            return new pcColletionDBContext(builder.Options);

        }
    }
}
