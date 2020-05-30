using System;
using Xunit;
using simpleAPI.Controllers;

namespace simpleAPI.Test
{
    public class UnitTest1
    {
        ValuesController controller = new ValuesController();

        [Fact]
        public void GetReturnMyName() {
            var returnValue = controller.Get(1);
            Assert.Equal("value1",returnValue.Value);
        }
        [Fact]
        public void Test1()
        {
            Assert.Equal("un","un");
        }
    }
}
