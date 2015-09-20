using Dinlun.GatewaySite.Bll;
using Dinlun.GatewaySite.Model.Prodcut;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Dinlun.GatewaySite.WebPoint.Controllers
{
    public class HomeController : Controller
    {
        private ProdcutBll prodcutBll = new ProdcutBll();




        public ActionResult Index()
        {
            return View();
        }

        /// <summary>
        /// 获取产品信息
        /// </summary>
        /// <returns></returns>
        public IList<ProdcutModel> GetProdcutList()
        {
           return   prodcutBll.GetProductList();

        }
    }
}