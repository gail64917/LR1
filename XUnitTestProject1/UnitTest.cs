using System;
using Xunit;
using LR1.Controllers;
using LR1.Data;
using Moq;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WebApplication1;
using Microsoft.AspNetCore.TestHost;
using System.Net.Http;
using Microsoft.AspNetCore.Hosting;
using System.Threading.Tasks;
using Newtonsoft.Json;
using System.Net;
using System.Text;

namespace XUnitTest
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
