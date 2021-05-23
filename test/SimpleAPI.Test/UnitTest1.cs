using System;
using Xunit;
using SimpleAPI;
using SimpleAPI.Controllers;
using System.Collections.Generic;
using System.Linq;
using Microsoft.Extensions.Logging;

namespace SimpleAPI.Test
{
    public class UnitTest1
    {

        WeatherForecastController controller = new WeatherForecastController();

        [Fact]
        public void GetReturnsValues()
        {

            var returnValue = controller.Get();           
            Assert.NotEmpty(returnValue);            
        }

        [Fact]
        public void Test1()
        {

        }
    }
}
