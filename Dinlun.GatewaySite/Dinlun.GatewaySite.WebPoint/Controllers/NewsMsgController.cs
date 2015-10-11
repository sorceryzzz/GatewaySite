using Dinlun.GatewaySite.Bll.News;
using Dinlun.GatewaySite.Model.News;
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

        /// <summary>
        /// 获取新闻列表
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        // GET: NewsMsg
        public ActionResult Index(int newsType,int pageIndex,int pageSize)
        {

            ViewBag.ResultNewsMsgListModel = GetNewsMsgList(newsType, pageIndex, pageSize);
            ViewBag.PageIndex = pageIndex;
            ViewBag.NewsType = newsType;
            return View();
        }
        /// <summary>
        /// 获取新闻详情
        /// </summary>
        /// <param name="newsId"></param>
        /// <param name="newsType"></param>
        /// <returns></returns>
        [HttpGet]
        public ActionResult NewsDetail(int newsId, int newsType)
        {



            return View();
        }
        /// <summary>
        /// 获取新闻动态详情
        /// </summary>
        /// <param name="newsId"></param>
        /// <returns></returns>
        public ContentResult GetNewsMsgDetail(int newsId,int newsType)
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
        public ResultNewsMsgListModel GetNewsMsgList(int newsType, int pageIndex, int pageSize)
        {
            int pageCount=0;

            #region - check paras-
            int tmpInt = 0;

            //if (tmpInt<=0&&pageIndex<=0&&pageSize<10)
            //{
            //    return null ;
            //}
            #endregion


            #region - excute -
            var newsMsgList = _newsMsgBllInstance.GetNewsMsgList(newsType, pageIndex, pageSize, out  pageCount);


            ResultNewsMsgListModel rlModel = new ResultNewsMsgListModel();
            rlModel.NewsMsgList = newsMsgList;
            rlModel.PageCount = pageCount;



            return rlModel;
            #endregion
        }
    }
}