using Microsoft.AspNetCore.Components.Builder;
using Microsoft.Extensions.DependencyInjection;
using Sotsera.Blazor.Toaster;
using Sotsera.Blazor.Toaster.Core.Models;
using ToasterTest.Shared;

namespace ToasterTest
{
    public class Startup
    {
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddToaster(config =>
            {
            //example customizations
            config.PositionClass = Defaults.Classes.Position.TopRight;
            config.PreventDuplicates = true;
            config.NewestOnTop = false;
            });

            services.AddSingleton<ITest, Test>();
        }

        public void Configure(IComponentsApplicationBuilder app)
        {
            app.AddComponent<App>("app");
        }
    }
}
