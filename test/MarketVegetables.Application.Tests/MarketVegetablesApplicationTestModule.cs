using Volo.Abp.Modularity;

namespace MarketVegetables;

[DependsOn(
    typeof(MarketVegetablesApplicationModule),
    typeof(MarketVegetablesDomainTestModule)
    )]
public class MarketVegetablesApplicationTestModule : AbpModule
{

}
