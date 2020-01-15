using System.Threading.Tasks;
using Volo.Abp.DependencyInjection;

namespace Mju.Datacenter.Data
{
    /* This is used if database provider does't define
     * IDatacenterDbSchemaMigrator implementation.
     */
    public class NullDatacenterDbSchemaMigrator : IDatacenterDbSchemaMigrator, ITransientDependency
    {
        public Task MigrateAsync()
        {
            return Task.CompletedTask;
        }
    }
}