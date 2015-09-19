using Dinlun.GatewaySite.Dal.News;
using Dinlun.GatewaySite.Model.News;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dinlun.GatewaySite.Bll.News
{
   public  class NewsMsgBll
   {
       private readonly NewsMsgDal _nesmsgDalInstance;


       public NewsMsgBll()
       {

           _nesmsgDalInstance = new NewsMsgDal();

       }




       #region - method -


        /// <summary>
       /// 查询新闻动态详情
       /// </summary>
       /// <param name="newsId"></param>
       /// <returns></returns>
       public NewsMsgModel GetNewsMsgDetail(int newsId)
       {
           return _nesmsgDalInstance.GetNewsMsgDetail(newsId);
       }
         /// <summary>
        /// 获取新闻动态
        /// </summary>
        /// <param name="newsType">新闻类别</param>
        /// <returns>新闻动态列表</returns>
       public IList<NewsMsgModel> GetNewsMsgList(int newsType, int pageIndex, int pageSize, out int pageCount)
       {
           return _nesmsgDalInstance.GetNewsMsgList(newsType, pageIndex, pageSize, out pageCount);
       }
       #endregion

   }
}
