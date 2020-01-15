using Volo.Abp.Http.Client.IdentityModel;
using Volo.Abp.Modularity;

namespace Mju.Datacenter.HttpApi.Client.ConsoleTestApp
{
    [DependsOn(
        typeof(DatacenterHttpApiClientModule),
        typeof(AbpHttpClientIdentityModelModule)
        )]
    public class DatacenterConsoleApiClientModule : AbpModule
    {
        
    }
}
