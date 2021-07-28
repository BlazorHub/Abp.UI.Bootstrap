using Abp.UI.Bootstrap.BasicTheme;
using Abp.UI.Bootstrap.WebAssembly.Theming;
using Abp.UI.Bootstrap.Routing;
using Abp.UI.Bootstrap.Toolbars;
using Volo.Abp.Http.Client.IdentityModel;
using Volo.Abp.Http.Client.IdentityModel.WebAssembly;
using Volo.Abp.Modularity;

namespace Abp.UI.Bootstrap.WebAssembly.BasicTheme
{
    [DependsOn(
        typeof(AbpAspNetCoreComponentsWebBasicThemeModule),
        typeof(AbpUiBootstrapWebAssemblyTheming),
        typeof(AbpHttpClientIdentityModelModule)
        )]
    public class AbpAspNetCoreComponentsWebAssemblyBasicThemeModule : AbpModule
    {
        public override void ConfigureServices(ServiceConfigurationContext context)
        {
            Configure<AbpRouterOptions>(options =>
            {
                options.AdditionalAssemblies.Add(typeof(AbpAspNetCoreComponentsWebAssemblyBasicThemeModule).Assembly);
            });

            Configure<AbpToolbarOptions>(options =>
            {
                options.Contributors.Add(new BasicThemeToolbarContributor());
            });
        }
    }
}
