using Dinlun.GatewaySite.Bll.News;
using Dinlun.GatewaySite.Model.News;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Dinlun.GatewaySite.HouTaiManager.Controllers
{
    public class NewsController : Controller
    {
        #region - property -
        NewsMsgBll _newsMsgBll=new NewsMsgBll();
        #endregion



        #region - method -
        // GET: News
        public ActionResult Index()
        {
            return View();
        }

        /// <summary>
        /// 添加新闻信息
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public ActionResult InsertNewsInfo()
        {
            return View();
        }
        [HttpPost]
        public ContentResult InsertNewsInfoPost()
        {
            
                #region - paras -
                NewsMsgModel nmModel = new NewsMsgModel();


                nmModel.Title = Request.Form.Get("newsName");
                nmModel.NewsType=Request.Form.Get("newsType")==null?1:int.Parse(Request.Form.Get("newsType"));
                nmModel.ImageUrl=Request.Form.Get("imageUrl");
                nmModel.Content=Request.Form.Get("newsContent");
      
                #endregion


                var rltBool = _newsMsgBll.InsertNewsInfo(nmModel);

                return Content(rltBool ? "success" : "fail");

        }
        #endregion
       


    }
}