using System.Threading.Tasks;
using Abp.UI.Bootstrap.Server.BasicTheme.Themes.Basic;
using Abp.UI.Bootstrap.Toolbars;

namespace Volo.Abp.AspNetCore.Components.Server.BasicTheme
{
    public class BasicThemeToolbarContributor : IToolbarContributor
    {
        public Task ConfigureToolbarAsync(IToolbarConfigurationContext context)
        {
            if (context.Toolbar.Name == StandardToolbars.Main)
            {
                context.Toolbar.Items.Add(new ToolbarItem(typeof(LanguageSwitch)));
                context.Toolbar.Items.Add(new ToolbarItem(typeof(LoginDisplay)));
            }

            return Task.CompletedTask;
        }
    }
}
