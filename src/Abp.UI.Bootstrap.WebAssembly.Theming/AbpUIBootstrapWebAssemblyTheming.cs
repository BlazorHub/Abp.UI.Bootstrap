using Abp.UI.Bootstrap;
using Volo.Abp.AspNetCore.Components.WebAssembly;
using Volo.Abp.Modularity;

namespace Abp.UI.Bootstrap.WebAssembly.Theming
{
    [DependsOn(
        typeof(AbpAspNetCoreComponentsWebThemingModule),
        typeof(AbpAspNetCoreComponentsWebAssemblyModule)
    )]
    public class AbpUiBootstrapWebAssemblyTheming : AbpModule
    {

    }
}
