using OwnedEntities.EntityFrameworkCore;
using Volo.Abp.Autofac;
using Volo.Abp.BackgroundJobs;
using Volo.Abp.Modularity;

namespace OwnedEntities.DbMigrator
{
    [DependsOn(
        typeof(AbpAutofacModule),
        typeof(OwnedEntitiesEntityFrameworkCoreDbMigrationsModule),
        typeof(OwnedEntitiesApplicationContractsModule)
        )]
    public class OwnedEntitiesDbMigratorModule : AbpModule
    {
        public override void ConfigureServices(ServiceConfigurationContext context)
        {
            Configure<BackgroundJobOptions>(options => options.IsJobExecutionEnabled = false);
        }
    }
}
