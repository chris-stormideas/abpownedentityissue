using OwnedEntities.Localization;
using Volo.Abp.AspNetCore.Mvc;

namespace OwnedEntities.Controllers
{
    /* Inherit your controllers from this class.
     */
    public abstract class OwnedEntitiesController : AbpController
    {
        protected OwnedEntitiesController()
        {
            LocalizationResource = typeof(OwnedEntitiesResource);
        }
    }
}