using Volo.Abp.Modularity;

namespace OwnedEntities
{
    [DependsOn(
        typeof(OwnedEntitiesApplicationModule),
        typeof(OwnedEntitiesDomainTestModule)
        )]
    public class OwnedEntitiesApplicationTestModule : AbpModule
    {

    }
}