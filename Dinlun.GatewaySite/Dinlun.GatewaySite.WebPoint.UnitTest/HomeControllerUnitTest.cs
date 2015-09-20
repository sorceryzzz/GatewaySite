using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Dinlun.GatewaySite.WebPoint.Controllers;

namespace Dinlun.GatewaySite.WebPoint.UnitTest
{
    /// <summary>
    /// HomeControllerUnitTest 的摘要说明
    /// </summary>
    [TestClass]
    public class HomeControllerUnitTest
    {

        [TestMethod]
        public void GetProdcutList()
        {
            HomeController homeController = new HomeController();
            var productList = homeController.GetProdcutList();

            Assert.AreEqual(productList.Count,0);

            //Assert.AreEqual(productList.Count>0, true);


        }
    }
}
