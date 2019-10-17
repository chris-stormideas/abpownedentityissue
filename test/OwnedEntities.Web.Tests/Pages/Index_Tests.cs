using System.Threading.Tasks;
using Shouldly;
using Xunit;

namespace OwnedEntities.Pages
{
    public class Index_Tests : OwnedEntitiesWebTestBase
    {
        [Fact]
        public async Task Welcome_Page()
        {
            var response = await GetResponseAsStringAsync("/");
            response.ShouldNotBeNull();
        }
    }
}
