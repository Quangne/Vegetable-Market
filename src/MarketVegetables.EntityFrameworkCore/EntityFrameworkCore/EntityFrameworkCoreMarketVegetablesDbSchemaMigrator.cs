using System;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using MarketVegetables.Data;
using Volo.Abp.DependencyInjection;

namespace MarketVegetables.EntityFrameworkCore;

public class EntityFrameworkCoreMarketVegetablesDbSchemaMigrator
    : IMarketVegetablesDbSchemaMigrator, ITransientDependency
{
    private readonly IServiceProvider _serviceProvider;

    public EntityFrameworkCoreMarketVegetablesDbSchemaMigrator(
        IServiceProvider serviceProvider)
    {
        _serviceProvider = serviceProvider;
    }

    public async Task MigrateAsync()
    {
        /* We intentionally resolving the MarketVegetablesDbContext
         * from IServiceProvider (instead of directly injecting it)
         * to properly get the connection string of the current tenant in the
         * current scope.
         */

        await _serviceProvider
            .GetRequiredService<MarketVegetablesDbContext>()
            .Database
            .MigrateAsync();
    }
}
