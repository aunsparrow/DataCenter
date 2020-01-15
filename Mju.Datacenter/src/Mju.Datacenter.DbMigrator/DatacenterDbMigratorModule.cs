using Mju.Datacenter.EntityFrameworkCore;
using Volo.Abp.Autofac;
using Volo.Abp.BackgroundJobs;
using Volo.Abp.Modularity;

namespace Mju.Datacenter.DbMigrator
{
    [DependsOn(
        typeof(AbpAutofacModule),
        typeof(DatacenterEntityFrameworkCoreDbMigrationsModule),
        typeof(DatacenterApplicationContractsModule)
        )]
    public class DatacenterDbMigratorModule : AbpModule
    {
        public override void ConfigureServices(ServiceConfigurationContext context)
        {
            Configure<AbpBackgroundJobOptions>(options => options.IsJobExecutionEnabled = false);
        }
    }
}
