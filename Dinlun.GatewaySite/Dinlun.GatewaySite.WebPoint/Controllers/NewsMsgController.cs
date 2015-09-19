using Dinlun.GatewaySite.Bll.News;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Dinlun.GatewaySite.WebPoint.Controllers
{
    public class NewsMsgController : Controller
    {

        public  NewsMsgBll _newsMsgBllInstance=new NewsMsgBll();


        public NewsMsgController()
        {



        }



        // GET: NewsMsg
        public ActionResult Index()
        {

            return View();
        }

        /// <summary>
        /// 获取新闻动态详情
        /// </summary>
        /// <param name="newsId"></param>
        /// <returns></returns>
        public ContentResult GetNewsMsgDetail(int newsId)
        {

            #region - check paras -
            if (newsId<0)
            {
                return Content("Error");
                
            }
            #endregion

            #region - excute  -
            var obj = _newsMsgBllInstance.GetNewsMsgDetail(newsId);
            #endregion

            return Content(JsonConvert.SerializeObject(obj));
        }

        /// <summary>
        /// 获取新闻动态
        /// </summary>
        /// <param name="newsType"></param>
        /// <param name="pageIndex"></param>
        /// <param name="pageSize"></param>
        /// <returns></returns>
        public ContentResult GetNewsMsgList(int newsType, int pageIndex, int pageSize)
        {
            int pageCount=0;

            #region - check paras-
            int tmpInt = 0;

            if (tmpInt<=0&&pageIndex<=0&&pageSize<10)
            {
                return Content("Error") ;
            }
            #endregion


            #region - excute -
            var newsMsgList = _newsMsgBllInstance.GetNewsMsgList(newsType, pageIndex, pageSize, out  pageCount);

            var obj=new{
                pageCount=pageCount,
                dataObj=newsMsgList
            };
            return Content(JsonConvert.SerializeObject(obj));
            #endregion
        }



    }
}