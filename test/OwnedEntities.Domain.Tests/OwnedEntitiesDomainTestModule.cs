using OwnedEntities.EntityFrameworkCore;
using Volo.Abp.Modularity;

namespace OwnedEntities
{
    [DependsOn(
        typeof(OwnedEntitiesEntityFrameworkCoreTestModule)
        )]
    public class OwnedEntitiesDomainTestModule : AbpModule
    {

    }
}