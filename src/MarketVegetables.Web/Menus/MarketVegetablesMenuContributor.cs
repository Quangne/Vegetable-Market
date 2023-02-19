using System.Threading.Tasks;
using MarketVegetables.Localization;
using MarketVegetables.MultiTenancy;
using Volo.Abp.Identity.Web.Navigation;
using Volo.Abp.SettingManagement.Web.Navigation;
using Volo.Abp.TenantManagement.Web.Navigation;
using Volo.Abp.UI.Navigation;

namespace MarketVegetables.Web.Menus;

public class MarketVegetablesMenuContributor : IMenuContributor
{
    public async Task ConfigureMenuAsync(MenuConfigurationContext context)
    {
        if (context.Menu.Name == StandardMenus.Main)
        {
            await ConfigureMainMenuAsync(context);
        }
    }

    private async Task ConfigureMainMenuAsync(MenuConfigurationContext context)
    {
        var administration = context.Menu.GetAdministration();
        var l = context.GetLocalizer<MarketVegetablesResource>();

        context.Menu.Items.Insert(
            0,
            new ApplicationMenuItem(
                MarketVegetablesMenus.Home,
                l["Menu:Home"],
                "~/",
                icon: "fas fa-home",
                order: 0
            )
        );
        context.Menu.AddItem(
            new ApplicationMenuItem(
                MarketVegetablesMenus.Category,
                l["Category"],
                "/Categories",
                icon : "fas fa-solid fa-list",
                order: 1
            ));
        context.Menu.AddItem(
            new ApplicationMenuItem(
                MarketVegetablesMenus.Product,
                l["Product"],
                "/Products",
                icon: "fas fa-brands fa-product-hunt",
                order: 1
            ));
        context.Menu.AddItem(
            new ApplicationMenuItem(
                MarketVegetablesMenus.Order,
                l["Order List"],
                "/Orders",
                icon: "fa-brands fa-jedi-order",
                order: 1
            ));
        context.Menu.AddItem(
            new ApplicationMenuItem(
                MarketVegetablesMenus.Unit,
                l["Unit"],
                "/Units",
                icon: "fa-brands fa-jedi-order",
                order: 1
            ));
        if (MultiTenancyConsts.IsEnabled)
        {
            administration.SetSubItemOrder(TenantManagementMenuNames.GroupName, 1);
        }
        else
        {
            administration.TryRemoveMenuItem(TenantManagementMenuNames.GroupName);
        }

        administration.SetSubItemOrder(IdentityMenuNames.GroupName, 2);
        administration.SetSubItemOrder(SettingManagementMenuNames.GroupName, 3);
    }
}
