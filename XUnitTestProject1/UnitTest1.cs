using System;
using Xunit;
using ShopBridge_API_Core;
using ShopBridge_API_Core.Controllers;
using ShopBridge_API_Core.Models;
using System.Collections.Generic;

namespace XUnitTestProject1
{
    public class UnitTest1
    {
        MockTestController _controller;
        [Fact]
        public void Test1()
        {
            
        }

        [Fact]
        public void Calllist()
        {
           var Data= _controller.Get();
            Assert.IsType<List<InventoryItems> >(Data);
        }
    }
}
