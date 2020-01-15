using Microsoft.AspNetCore.Mvc.Localization;
using Microsoft.AspNetCore.Mvc.Razor.Internal;
using Mju.Datacenter.Localization;
using Volo.Abp.AspNetCore.Mvc.UI.RazorPages;

namespace Mju.Datacenter.Web.Pages
{
    /* Inherit your UI Pages from this class. To do that, add this line to your Pages (.cshtml files under the Page folder):
     * @inherits Mju.Datacenter.Web.Pages.DatacenterPage
     */
    public abstract class DatacenterPage : AbpPage
    {
        [RazorInject]
        public IHtmlLocalizer<DatacenterResource> L { get; set; }
    }
}
