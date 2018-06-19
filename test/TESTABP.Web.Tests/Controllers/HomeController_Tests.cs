using System.Threading.Tasks;
using TESTABP.Web.Controllers;
using Shouldly;
using Xunit;

namespace TESTABP.Web.Tests.Controllers {
    public class HomeController_Tests : TESTABPWebTestBase {
        [Fact]
        public async Task<string> Index_Test() {
            //Act
            var response = await GetResponseAsStringAsync(
                GetUrl<HomeController>(nameof(HomeController.Index))
            );
            //Assert
            response.ShouldNotBeNullOrEmpty();
            return  response;
        }
    }
}
