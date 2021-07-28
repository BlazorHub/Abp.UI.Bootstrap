using Volo.Abp.Bundling;

namespace Abp.UI.Bootstrap.WebAssembly.Theming
{
    public class BootstrapComponentsBundleContributor : IBundleContributor
    {
        public void AddScripts(BundleContext context)
        {
            context.Add("_content/Microsoft.AspNetCore.Components.WebAssembly.Authentication/AuthenticationService.js");
            context.Add("_content/BootstrapBlazor/js/bootstrap.blazor.bundle.min.js");
            context.Add("_content/Volo.Abp.AspNetCore.Components.Web/libs/abp/js/abp.js");
        }

        public void AddStyles(BundleContext context)
        {
            context.BundleDefinitions.Insert(0, new BundleDefinition
            {
                Source = "_content/Abp.UI.Bootstrap/css/font-awesome.min.css"
            });
            context.Add("_content/BootstrapBlazor/css/bootstrap.blazor.bundle.min.css");
        }
    }
}
