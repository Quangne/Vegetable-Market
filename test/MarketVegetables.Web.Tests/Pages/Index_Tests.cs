using System.Threading.Tasks;
using Shouldly;
using Xunit;

namespace MarketVegetables.Pages;

public class Index_Tests : MarketVegetablesWebTestBase
{
    [Fact]
    public async Task Welcome_Page()
    {
        var response = await GetResponseAsStringAsync("/");
        response.ShouldNotBeNull();
    }
}
