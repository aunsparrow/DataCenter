using Mju.Datacenter.Localization;
using Volo.Abp.AspNetCore.Mvc.UI.RazorPages;

namespace Mju.Datacenter.Web.Pages
{
    /* Inherit your PageModel classes from this class.
     */
    public abstract class DatacenterPageModel : AbpPageModel
    {
        protected DatacenterPageModel()
        {
            LocalizationResourceType = typeof(DatacenterResource);
        }
    }
}