using Volo.Abp.AspNetCore.Mvc.UI.Theme.Shared.Components;
using Volo.Abp.DependencyInjection;

namespace Mju.Datacenter.Web
{
    [Dependency(ReplaceServices = true)]
    public class DatacenterBrandingProvider : DefaultBrandingProvider
    {
        public override string AppName => "Datacenter";
    }
}
