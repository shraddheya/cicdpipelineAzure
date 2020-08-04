using System;
using Xunit;
using SimpleAPI.Controllers;

namespace SimpleAPI.Tests
{
    public class UnitTest1
    {
        WeatherForecastController controller = new WeatherForecastController();

        [Fact]
        public void GetReturnsWeather()
        {
            int count = 0;
            var returnvalue = controller.Get();
            foreach (var item in returnvalue)
            {
                count++;
            }
            Assert.Equal(5, count);
        }

        [Fact]
        public void GetSpecific()
        {
            var rns = (new Random()).Next(20);
            int count = 0;
            var returnvalue = controller.Get(rns);
            foreach (var item in returnvalue)
            {
                count++;
            }
            Assert.Equal(rns, count);
        }

        [Fact]
        public void Test1()
        {
        }

    }
}
