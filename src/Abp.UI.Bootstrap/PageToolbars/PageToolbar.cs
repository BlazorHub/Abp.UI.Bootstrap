namespace Abp.UI.Bootstrap.PageToolbars
{
    public class PageToolbar
    {
        public PageToolbarContributorList Contributors { get; set; }

        public PageToolbar()
        {
            Contributors = new PageToolbarContributorList();
        }
    }
}
