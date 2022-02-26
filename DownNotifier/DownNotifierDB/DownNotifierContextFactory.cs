using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using System;
using System.IO;

namespace DownNotifier.Migration
{
    public class DownNotifierContextFactory : IDesignTimeDbContextFactory<DownNotifierContext>
    {
        public DownNotifierContext CreateDbContext(string[] args)
        {
            string environmentVariable = Environment.GetEnvironmentVariable("ASPNETCORE_ENVIRONMENT");
            IConfigurationRoot configuration = new ConfigurationBuilder().SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile(@Directory.GetCurrentDirectory() + "../../DownNotifier/appsettings.json")
                .AddJsonFile(@Directory.GetCurrentDirectory() + "../../DownNotifier/appsettings" + environmentVariable + ".json", optional: false, reloadOnChange: false).Build();

            var builder = new DbContextOptionsBuilder<DownNotifierContext>();
            builder.EnableSensitiveDataLogging();
            var connentionString = configuration.GetConnectionString("PostgresqlConnection");
            builder.UseNpgsql(connentionString);

            return new DownNotifierContext(builder.Options);
     
        }
    }
}
