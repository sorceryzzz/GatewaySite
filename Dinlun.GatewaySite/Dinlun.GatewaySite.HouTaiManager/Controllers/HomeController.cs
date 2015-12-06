using Dinlun.GatewaySite.Bll.Type;
using Dinlun.GatewaySite.Model.Type;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Dinlun.GatewaySite.HouTaiManager.Controllers
{
    public class HomeController : Controller
    {
        private TypeInfoBll tInfoBll = new TypeInfoBll();


        public ActionResult Index()
        {
            return View();
        }

        /// <summary>
        /// 添加type信息
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public ActionResult InserTypeInfo()
        {
            return View();
        }
        /// <summary>
        /// 添加type信息
        /// </summary>
        /// <returns></returns>
        [HttpPost]
        public ContentResult InserTypeInfoPost()
        {   
            var typeID = Request.Form.Get("typeID");
            var typeName = Request.Form.Get("typeName");
            var imageUrl = Request.Form.Get("imageUrl");
            var newsContent = Request.Form.Get("newsContent");

            TypeInfoModel tInfoModel = new TypeInfoModel();
            tInfoModel.Name = typeName;
            tInfoModel.Type = int.Parse(typeID);
            tInfoModel.Desc = newsContent;
            tInfoModel.ImgUrl = imageUrl;

            bool rltBool=  tInfoBll.InsertTypeInfo(tInfoModel);
            return Content(rltBool ? "success" : "fail");
        }
    }
}