using MarketVegetables.Localization;
using Volo.Abp.AspNetCore.Mvc.UI.RazorPages;

namespace MarketVegetables.Web.Pages;

/* Inherit your PageModel classes from this class.
 */
public abstract class MarketVegetablesPageModel : AbpPageModel
{
    protected MarketVegetablesPageModel()
    {
        LocalizationResourceType = typeof(MarketVegetablesResource);
    }
}
