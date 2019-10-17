using System.Threading.Tasks;
using Volo.Abp.DependencyInjection;

namespace OwnedEntities.Data
{
    /* This is used if database provider does't define
     * IOwnedEntitiesDbSchemaMigrator implementation.
     */
    public class NullOwnedEntitiesDbSchemaMigrator : IOwnedEntitiesDbSchemaMigrator, ITransientDependency
    {
        public Task MigrateAsync()
        {
            return Task.CompletedTask;
        }
    }
}