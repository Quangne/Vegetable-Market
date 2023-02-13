using System.Threading.Tasks;

namespace MarketVegetables.Data;

public interface IMarketVegetablesDbSchemaMigrator
{
    Task MigrateAsync();
}
