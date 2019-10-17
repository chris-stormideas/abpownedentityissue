using Microsoft.AspNetCore.Mvc.Localization;
using Microsoft.AspNetCore.Mvc.Razor.Internal;
using OwnedEntities.Localization;
using Volo.Abp.AspNetCore.Mvc.UI.RazorPages;

namespace OwnedEntities.Web.Pages
{
    /* Inherit your UI Pages from this class. To do that, add this line to your Pages (.cshtml files under the Page folder):
     * @inherits OwnedEntities.Web.Pages.OwnedEntitiesPage
     */
    public abstract class OwnedEntitiesPage : AbpPage
    {
        [RazorInject]
        public IHtmlLocalizer<OwnedEntitiesResource> L { get; set; }
    }
}
