using System.Threading.Tasks;

namespace Mju.Datacenter.Data
{
    public interface IDatacenterDbSchemaMigrator
    {
        Task MigrateAsync();
    }
}
