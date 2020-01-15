using Microsoft.Extensions.DependencyInjection;
using Volo.Abp.Modularity;

namespace Mju.Datacenter.EntityFrameworkCore
{
    [DependsOn(
        typeof(DatacenterEntityFrameworkCoreModule)
        )]
    public class DatacenterEntityFrameworkCoreDbMigrationsModule : AbpModule
    {
        public override void ConfigureServices(ServiceConfigurationContext context)
        {
            context.Services.AddAbpDbContext<DatacenterMigrationsDbContext>();
        }
    }
}
