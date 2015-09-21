using Dinlun.GatewaySite.Bll;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Dinlun.GatewaySite.WebPoint.Controllers
{
    public class ProdcutController : Controller
    {
        private ProdcutBll prodcutBll = new ProdcutBll();

        // GET: Prodcut
        public ActionResult Index()
        {
            return View();
        }
        /// <summary>
        /// 获取产品详情
        /// </summary>
        /// <param name="prodcutID"></param>
        /// <returns></returns>
        public ContentResult GetProdcutDetail(int  prodcutID)
        {
            #region - check paras -
            if (prodcutID<=0)
            {
                return Content("Error");
                
            }
            #endregion


            #region - excute -
            var prdDetail= prodcutBll.GetProdcutDetailBy(prodcutID);
            #endregion

            return Content(JsonConvert.SerializeObject(prdDetail));

        }

    }
}