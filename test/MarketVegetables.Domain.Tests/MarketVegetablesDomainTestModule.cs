using MarketVegetables.EntityFrameworkCore;
using Volo.Abp.Modularity;

namespace MarketVegetables;

[DependsOn(
    typeof(MarketVegetablesEntityFrameworkCoreTestModule)
    )]
public class MarketVegetablesDomainTestModule : AbpModule
{

}
