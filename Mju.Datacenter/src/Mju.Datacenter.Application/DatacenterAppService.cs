using System;
using System.Collections.Generic;
using System.Text;
using Mju.Datacenter.Localization;
using Volo.Abp.Application.Services;

namespace Mju.Datacenter
{
    /* Inherit your application services from this class.
     */
    public abstract class DatacenterAppService : ApplicationService
    {
        protected DatacenterAppService()
        {
            LocalizationResource = typeof(DatacenterResource);
        }
    }
}
