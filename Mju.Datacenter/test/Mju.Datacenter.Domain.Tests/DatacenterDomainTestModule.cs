using Mju.Datacenter.EntityFrameworkCore;
using Volo.Abp.Modularity;

namespace Mju.Datacenter
{
    [DependsOn(
        typeof(DatacenterEntityFrameworkCoreTestModule)
        )]
    public class DatacenterDomainTestModule : AbpModule
    {

    }
}