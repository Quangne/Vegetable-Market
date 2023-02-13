using Volo.Abp.Ui.Branding;
using Volo.Abp.DependencyInjection;

namespace MarketVegetables.Web;

[Dependency(ReplaceServices = true)]
public class MarketVegetablesBrandingProvider : DefaultBrandingProvider
{
    public override string AppName => "MarketVegetables";
}
