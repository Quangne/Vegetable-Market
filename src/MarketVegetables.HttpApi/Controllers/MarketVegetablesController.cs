using MarketVegetables.Localization;
using Volo.Abp.AspNetCore.Mvc;

namespace MarketVegetables.Controllers;

/* Inherit your controllers from this class.
 */
public abstract class MarketVegetablesController : AbpControllerBase
{
    protected MarketVegetablesController()
    {
        LocalizationResource = typeof(MarketVegetablesResource);
    }
}
