using System;
using System.Collections.Generic;
using System.Text;
using MarketVegetables.Localization;
using Volo.Abp.Application.Services;

namespace MarketVegetables;

/* Inherit your application services from this class.
 */
public abstract class MarketVegetablesAppService : ApplicationService
{
    protected MarketVegetablesAppService()
    {
        LocalizationResource = typeof(MarketVegetablesResource);
    }
}
