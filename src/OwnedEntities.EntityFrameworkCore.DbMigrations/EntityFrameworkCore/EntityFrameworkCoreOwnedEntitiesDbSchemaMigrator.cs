using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using OwnedEntities.Data;
using Volo.Abp.DependencyInjection;

namespace OwnedEntities.EntityFrameworkCore
{
    [Dependency(ReplaceServices = true)]
    public class EntityFrameworkCoreOwnedEntitiesDbSchemaMigrator 
        : IOwnedEntitiesDbSchemaMigrator, ITransientDependency
    {
        private readonly OwnedEntitiesMigrationsDbContext _dbContext;

        public EntityFrameworkCoreOwnedEntitiesDbSchemaMigrator(OwnedEntitiesMigrationsDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task MigrateAsync()
        {
            await _dbContext.Database.MigrateAsync();
        }
    }
}