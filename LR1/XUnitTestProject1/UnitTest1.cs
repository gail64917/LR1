using System;
using Xunit;
using LR1.Controllers;

namespace XUnitTestProject1
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            var controller = new HomeController();
            var result = controller.Kostuyl();
            Assert.Equal(result, 0);
        }
    }
}
