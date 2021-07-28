using Abp.UI.Bootstrap;
using Volo.Abp.Modularity;

namespace Abp.UI.Bootstrap.BasicTheme
{
    [DependsOn(
        typeof(AbpAspNetCoreComponentsWebThemingModule)
        )]
    public class AbpAspNetCoreComponentsWebBasicThemeModule : AbpModule
    {
        
    }
}