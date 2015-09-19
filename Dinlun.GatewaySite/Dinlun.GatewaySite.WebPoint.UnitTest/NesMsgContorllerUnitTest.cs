using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Dinlun.GatewaySite.WebPoint.Controllers;

namespace Dinlun.GatewaySite.WebPoint.UnitTest
{
    [TestClass]
    public class NesMsgContorllerUnitTest
    {

        [TestMethod]
        public void GetNewsMsgList()
        {
            NewsMsgController newsMsgController = new NewsMsgController();
            int newsType = 1;
            int pageIndex = 1;
            int pageSize = 10;
            var dataObj = newsMsgController.GetNewsMsgList(newsType,pageIndex,pageSize);
            Assert.IsNotNull(dataObj);
        }

    }
}
