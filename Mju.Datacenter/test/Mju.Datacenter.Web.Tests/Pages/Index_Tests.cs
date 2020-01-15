using System.Threading.Tasks;
using Shouldly;
using Xunit;

namespace Mju.Datacenter.Pages
{
    public class Index_Tests : DatacenterWebTestBase
    {
        [Fact]
        public async Task Welcome_Page()
        {
            var response = await GetResponseAsStringAsync("/");
            response.ShouldNotBeNull();
        }
    }
}
