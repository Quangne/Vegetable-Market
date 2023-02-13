using MarketVegetables.EntityFrameworkCore;
using Volo.Abp.Autofac;
using Volo.Abp.Modularity;

namespace MarketVegetables.DbMigrator;

[DependsOn(
    typeof(AbpAutofacModule),
    typeof(MarketVegetablesEntityFrameworkCoreModule),
    typeof(MarketVegetablesApplicationContractsModule)
    )]
public class MarketVegetablesDbMigratorModule : AbpModule
{

}
