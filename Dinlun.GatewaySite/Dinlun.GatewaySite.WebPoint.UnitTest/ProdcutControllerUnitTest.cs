using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Dinlun.GatewaySite.WebPoint.Controllers;

namespace Dinlun.GatewaySite.WebPoint.UnitTest
{
    /// <summary>
    /// ProdcutControllerUnitTest 的摘要说明
    /// </summary>
    [TestClass]
    public class ProdcutControllerUnitTest
    {
       

        [TestMethod]
        public void GetProdcutDetail()
        {
            int prdID = 10;


            ProdcutController prodcutController = new ProdcutController();

            var obj = prodcutController.GetProdcutDetail(prdID);

            Assert.IsNotNull(obj);

        }
    }
}
