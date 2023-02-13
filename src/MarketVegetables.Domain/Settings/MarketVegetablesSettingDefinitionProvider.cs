using Volo.Abp.Settings;

namespace MarketVegetables.Settings;

public class MarketVegetablesSettingDefinitionProvider : SettingDefinitionProvider
{
    public override void Define(ISettingDefinitionContext context)
    {
        //Define your own settings here. Example:
        //context.Add(new SettingDefinition(MarketVegetablesSettings.MySetting1));
    }
}
