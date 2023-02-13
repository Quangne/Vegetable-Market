using MarketVegetables.Localization;
using Volo.Abp.Authorization.Permissions;
using Volo.Abp.Localization;

namespace MarketVegetables.Permissions;

public class MarketVegetablesPermissionDefinitionProvider : PermissionDefinitionProvider
{
    public override void Define(IPermissionDefinitionContext context)
    {
        var myGroup = context.AddGroup(MarketVegetablesPermissions.GroupName);
        //Define your own permissions here. Example:
        //myGroup.AddPermission(MarketVegetablesPermissions.MyPermission1, L("Permission:MyPermission1"));
    }

    private static LocalizableString L(string name)
    {
        return LocalizableString.Create<MarketVegetablesResource>(name);
    }
}
