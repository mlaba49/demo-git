using DockerDemo.Client.Controllers;
using Microsoft.Extensions.Logging;
using Xunit;

namespace DockerDemo.Testing {
    public class HomeControllerTest {
        [Fact]
        public void Test_Constructor() {
            var sut = new HomeController();

            Assert.NotNull(sut);
        }
    }
}