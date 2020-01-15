using Mju.Datacenter.Localization;
using Volo.Abp.AspNetCore.Mvc;

namespace Mju.Datacenter.Controllers
{
    /* Inherit your controllers from this class.
     */
    public abstract class DatacenterController : AbpController
    {
        protected DatacenterController()
        {
            LocalizationResource = typeof(DatacenterResource);
        }
    }
}