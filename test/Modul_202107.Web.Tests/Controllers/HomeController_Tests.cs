using System.Threading.Tasks;
using Modul_202107.Models.TokenAuth;
using Modul_202107.Web.Controllers;
using Shouldly;
using Xunit;

namespace Modul_202107.Web.Tests.Controllers
{
    public class HomeController_Tests: Modul_202107WebTestBase
    {
        [Fact]
        public async Task Index_Test()
        {
            await AuthenticateAsync(null, new AuthenticateModel
            {
                UserNameOrEmailAddress = "admin",
                Password = "123qwe"
            });

            //Act
            var response = await GetResponseAsStringAsync(
                GetUrl<HomeController>(nameof(HomeController.Index))
            );

            //Assert
            response.ShouldNotBeNullOrEmpty();
        }
    }
}