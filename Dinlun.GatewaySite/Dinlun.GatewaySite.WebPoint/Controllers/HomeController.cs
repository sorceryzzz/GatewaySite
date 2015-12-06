using Dinlun.GatewaySite.Bll;
using Dinlun.GatewaySite.Bll.Type;
using Dinlun.GatewaySite.Bll.ZhaoPin;
using Dinlun.GatewaySite.Model.Prodcut;
using Dinlun.GatewaySite.Model.ZhaoPin;
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
        private ZhaoPinBll zhaoPinBll = new ZhaoPinBll();
        private TypeInfoBll typeInfoBll = new TypeInfoBll();



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
            ViewBag.ZhaoPinList = zhaoPinBll.GetZhaoPinList();

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
       [HttpGet]
       public ActionResult GetTypeInfo(int typeId,string name)
       {

          var tInfoModel= typeInfoBll.GetTypeInfoModel(typeId,name);
          ViewData.Model = tInfoModel;
          
           return View();
       }
    }
}