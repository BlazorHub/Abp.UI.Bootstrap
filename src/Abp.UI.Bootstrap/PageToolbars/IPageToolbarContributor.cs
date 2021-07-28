using System.Threading.Tasks;

namespace Abp.UI.Bootstrap.PageToolbars
{
    public interface IPageToolbarContributor
    {
        Task ContributeAsync(PageToolbarContributionContext context);
    }
}
