using OwnedEntities.Localization;
using Volo.Abp.AspNetCore.Mvc.UI.RazorPages;

namespace OwnedEntities.Web.Pages
{
    /* Inherit your PageModel classes from this class.
     */
    public abstract class OwnedEntitiesPageModel : AbpPageModel
    {
        protected OwnedEntitiesPageModel()
        {
            LocalizationResourceType = typeof(OwnedEntitiesResource);
        }
    }
}