using System;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Volo.Abp;

namespace MarketVegetables;

public class MarketVegetablesWebTestStartup
{
    public void ConfigureServices(IServiceCollection services)
    {
        services.AddApplication<MarketVegetablesWebTestModule>();
    }

    public void Configure(IApplicationBuilder app, ILoggerFactory loggerFactory)
    {
        app.InitializeApplication();
    }
}
