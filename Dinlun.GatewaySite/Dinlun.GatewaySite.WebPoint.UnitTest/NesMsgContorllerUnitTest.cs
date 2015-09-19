using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Dinlun.GatewaySite.WebPoint.Controllers;

namespace Dinlun.GatewaySite.WebPoint.UnitTest
{
    [TestClass]
    public class NesMsgContorllerUnitTest
    {
        NewsMsgController newsMsgController = new NewsMsgController();

        [TestMethod]
        public void GetNewsMsgList()
        {
            
            int newsType = 1;
            int pageIndex = 1;
            int pageSize = 10;
            var dataObj = newsMsgController.GetNewsMsgList(newsType,pageIndex,pageSize);
            Assert.IsNotNull(dataObj);
        }
        [TestMethod]
        public void GetNewsDetail()
        {
            int newsId = 0;

            var obj=  newsMsgController.GetNewsMsgDetail(newsId);
            Assert.IsNotNull(obj);

        }

    }
}
