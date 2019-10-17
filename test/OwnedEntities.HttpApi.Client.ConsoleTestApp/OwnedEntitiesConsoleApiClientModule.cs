using Volo.Abp.Http.Client.IdentityModel;
using Volo.Abp.Modularity;

namespace OwnedEntities.HttpApi.Client.ConsoleTestApp
{
    [DependsOn(
        typeof(OwnedEntitiesHttpApiClientModule),
        typeof(AbpHttpClientIdentityModelModule)
        )]
    public class OwnedEntitiesConsoleApiClientModule : AbpModule
    {
        
    }
}
