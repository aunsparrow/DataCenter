using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Mju.Datacenter.Data;
using Volo.Abp.DependencyInjection;

namespace Mju.Datacenter.EntityFrameworkCore
{
    [Dependency(ReplaceServices = true)]
    public class EntityFrameworkCoreDatacenterDbSchemaMigrator 
        : IDatacenterDbSchemaMigrator, ITransientDependency
    {
        private readonly DatacenterMigrationsDbContext _dbContext;

        public EntityFrameworkCoreDatacenterDbSchemaMigrator(DatacenterMigrationsDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task MigrateAsync()
        {
            await _dbContext.Database.MigrateAsync();
        }
    }
}