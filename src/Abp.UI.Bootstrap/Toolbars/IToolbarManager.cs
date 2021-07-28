using System.Threading.Tasks;

namespace Abp.UI.Bootstrap.Toolbars
{
    public interface IToolbarManager
    {
        Task<Toolbar> GetAsync(string name);
    }
}
