using System.Threading.Tasks;
using Volo.Abp.DependencyInjection;

namespace MarketVegetables.Data;

/* This is used if database provider does't define
 * IMarketVegetablesDbSchemaMigrator implementation.
 */
public class NullMarketVegetablesDbSchemaMigrator : IMarketVegetablesDbSchemaMigrator, ITransientDependency
{
    public Task MigrateAsync()
    {
        return Task.CompletedTask;
    }
}
