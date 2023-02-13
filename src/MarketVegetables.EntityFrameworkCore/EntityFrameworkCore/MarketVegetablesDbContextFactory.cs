using System;
using System.IO;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;

namespace MarketVegetables.EntityFrameworkCore;

/* This class is needed for EF Core console commands
 * (like Add-Migration and Update-Database commands) */
public class MarketVegetablesDbContextFactory : IDesignTimeDbContextFactory<MarketVegetablesDbContext>
{
    public MarketVegetablesDbContext CreateDbContext(string[] args)
    {
        MarketVegetablesEfCoreEntityExtensionMappings.Configure();

        var configuration = BuildConfiguration();

        var builder = new DbContextOptionsBuilder<MarketVegetablesDbContext>()
            .UseSqlServer(configuration.GetConnectionString("Default"));

        return new MarketVegetablesDbContext(builder.Options);
    }

    private static IConfigurationRoot BuildConfiguration()
    {
        var builder = new ConfigurationBuilder()
            .SetBasePath(Path.Combine(Directory.GetCurrentDirectory(), "../MarketVegetables.DbMigrator/"))
            .AddJsonFile("appsettings.json", optional: false);

        return builder.Build();
    }
}
