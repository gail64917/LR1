using System;
using Xunit;
using LR1.Controllers;
using LR1.Data;
using Moq;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WebApplication1;

namespace XUnitTestProject1
{
    public class UnitTest
    {
        [Fact]
        public void StudentRepositoryExistsTest()
        {
            var result = 0;
            Assert.Equal(result, Program.SuccesCode());

        }
    }
}
