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
        /// <summary>
        /// 公司简介
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public ActionResult About()
        {


            return View();
        }


        /// <summary>
        /// 招贤纳士
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public ActionResult ZhaoPin()
        {

            return View();
        }
        /// <summary>
        /// 联系我们
        /// </summary>
        /// <returns></returns>
       [HttpGet]
        public ActionResult ContactUs()
        {

            return View();
        }
    }
}