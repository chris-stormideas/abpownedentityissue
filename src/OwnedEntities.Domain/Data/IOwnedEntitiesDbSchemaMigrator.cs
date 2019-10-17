using System.Threading.Tasks;

namespace OwnedEntities.Data
{
    public interface IOwnedEntitiesDbSchemaMigrator
    {
        Task MigrateAsync();
    }
}
