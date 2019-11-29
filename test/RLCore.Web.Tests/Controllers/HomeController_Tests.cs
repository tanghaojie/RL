using System.Threading.Tasks;
using RLCore.Web.Controllers;
using Shouldly;
using Xunit;

namespace RLCore.Web.Tests.Controllers
{
    public class HomeController_Tests: RLCoreWebTestBase
    {
        [Fact]
        public async Task Index_Test()
        {
            //Act
            var response = await GetResponseAsStringAsync(
                GetUrl<HomeController>(nameof(HomeController.Index))
            );

            //Assert
            response.ShouldNotBeNullOrEmpty();
        }
    }
}
