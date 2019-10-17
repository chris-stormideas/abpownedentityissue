using System;
using System.Collections.Generic;
using System.Text;
using OwnedEntities.Localization;
using Volo.Abp.Application.Services;

namespace OwnedEntities
{
    /* Inherit your application services from this class.
     */
    public abstract class OwnedEntitiesAppService : ApplicationService
    {
        protected OwnedEntitiesAppService()
        {
            LocalizationResource = typeof(OwnedEntitiesResource);
        }
    }
}
