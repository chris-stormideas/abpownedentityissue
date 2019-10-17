using Microsoft.Extensions.DependencyInjection;
using Volo.Abp.Modularity;

namespace OwnedEntities.EntityFrameworkCore
{
    [DependsOn(
        typeof(OwnedEntitiesEntityFrameworkCoreModule)
        )]
    public class OwnedEntitiesEntityFrameworkCoreDbMigrationsModule : AbpModule
    {
        public override void ConfigureServices(ServiceConfigurationContext context)
        {
            context.Services.AddAbpDbContext<OwnedEntitiesMigrationsDbContext>();
        }
    }
}
