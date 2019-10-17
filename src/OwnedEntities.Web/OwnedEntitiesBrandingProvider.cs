using Volo.Abp.AspNetCore.Mvc.UI.Theme.Shared.Components;
using Volo.Abp.DependencyInjection;

namespace OwnedEntities.Web
{
    [Dependency(ReplaceServices = true)]
    public class OwnedEntitiesBrandingProvider : DefaultBrandingProvider
    {
        public override string AppName => "OwnedEntities";
    }
}
