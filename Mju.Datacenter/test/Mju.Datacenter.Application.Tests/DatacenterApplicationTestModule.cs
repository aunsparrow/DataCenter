using Volo.Abp.Modularity;

namespace Mju.Datacenter
{
    [DependsOn(
        typeof(DatacenterApplicationModule),
        typeof(DatacenterDomainTestModule)
        )]
    public class DatacenterApplicationTestModule : AbpModule
    {

    }
}