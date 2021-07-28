using System.Threading.Tasks;

namespace Abp.UI.Bootstrap.PageToolbars
{
    public interface IPageToolbarManager
    {
        Task<PageToolbarItem[]> GetItemsAsync(PageToolbar toolbar);
    }
}
