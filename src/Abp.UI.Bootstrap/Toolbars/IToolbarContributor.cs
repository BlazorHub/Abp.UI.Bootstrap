using System.Threading.Tasks;

namespace Abp.UI.Bootstrap.Toolbars
{
    public interface IToolbarContributor
    {
        Task ConfigureToolbarAsync(IToolbarConfigurationContext context);
    }
}