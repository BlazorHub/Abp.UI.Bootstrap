using Abp.UI.Bootstrap.BasicTheme;
using Volo.Abp.AspNetCore.Components.Server.BasicTheme.Bundling;
using Volo.Abp.AspNetCore.Components.Server.Theming;
using Volo.Abp.AspNetCore.Components.Server.Theming.Bundling;
using Abp.UI.Bootstrap.Routing;
using Abp.UI.Bootstrap.Toolbars;
using Volo.Abp.AspNetCore.Mvc.UI.Bundling;
using Volo.Abp.Modularity;

namespace Volo.Abp.AspNetCore.Components.Server.BasicTheme
{
    [DependsOn(
        typeof(AbpAspNetCoreComponentsWebBasicThemeModule),
        typeof(AbpAspNetCoreComponentsServerThemingModule)
        )]
    public class AbpAspNetCoreComponentsServerBasicThemeModule : AbpModule
    {
        public override void ConfigureServices(ServiceConfigurationContext context)
        {
            Configure<AbpToolbarOptions>(options =>
            {
                options.Contributors.Add(new BasicThemeToolbarContributor());
            });
            
            Configure<AbpBundlingOptions>(options =>
            {
                options
                    .StyleBundles
                    .Add(BlazorBasicThemeBundles.Styles.Global, bundle =>
                    {
                        bundle
                            .AddBaseBundles(BlazorStandardBundles.Styles.Global)
                            .AddContributors(typeof(BlazorBasicThemeStyleContributor));
                    });

                options
                    .ScriptBundles
                    .Add(BlazorBasicThemeBundles.Scripts.Global, bundle =>
                    {
                        bundle
                            .AddBaseBundles(BlazorStandardBundles.Scripts.Global)
                            .AddContributors(typeof(BlazorBasicThemeScriptContributor));
                    });
            });
        }
    }
}
