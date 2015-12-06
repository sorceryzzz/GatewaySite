using Dinlun.GatewaySite.Common;
using Dinlun.GatewaySite.Model.News;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dinlun.GatewaySite.Dal.News
{
   public  class NewsMsgDal
    {

        #region - method -


       /// <summary>
       /// 添加新闻信息
       /// </summary>
       /// <param name="nmModel"></param>
       /// <returns></returns>
       public bool InsertNewsInfo(NewsMsgModel nmModel)
       {
           #region - sql qy -
           string insertSql = @"INSERT INTO `dinlun`.`newsmsg`
                                       (
                                        `Title`,
                                        `Content`,
                                        `NewsType`,
                                        `ImgUrl`,
                                        `InsertTime`,
                                        `avg1`,
                                        `avg2`)
                                VALUES (
                                        @Title,
                                        @Content,
                                        @NewsType,
                                        @ImgUrl,
                                        @InsertTime,
                                        @avg1,
                                        @avg2);";
           #endregion

           #region - paras -
           MySqlParameter[] paras = { 
                                new MySqlParameter("@Title",nmModel.Title),   
                                new MySqlParameter("@Content",nmModel.Content),
                                new MySqlParameter("@NewsType",nmModel.NewsType),
                                new MySqlParameter("@ImgUrl",nmModel.ImageUrl),
                                new MySqlParameter("@InsertTime",DateTime.Now),
                                new MySqlParameter("@Avg1",nmModel.Avg1),
                                new MySqlParameter("@Avg2",nmModel.Avg2)
                                   };
           #endregion

           #region - excute -
           try
           {

               //记录查询
               int rlt = DbHelperMySql.ExecuteNonQuery(DbHelperMySql.connectionStringManager, CommandType.Text, insertSql, paras);

               return rlt > 0;
           }
           catch (Exception ex)
           {

               return false;
           }
           #endregion
       }

       /// <summary>
       /// 查询新闻动态详情
       /// </summary>
       /// <param name="newsId"></param>
       /// <returns></returns>
       public NewsMsgModel GetNewsMsgDetail(int newsId)
       {
           NewsMsgModel newsMsgModel = null;


           #region - sql qy -
           string selectDetailQy = @"SELECT
                                       `ID`,
                                       `Title`,
                                       `Content`,
                                       `NewsType`,
                                       `ImgUrl`,
                                       `InsertTime`,
                                       `avg1`,
                                       `avg2`
                                     FROM `dinlun`.`newsmsg` AS newsmsg
                                     WHERE newsmsg.`ID`=@ID";
           #endregion

           #region - paras -
           MySqlParameter[] paras = 
           {
               new MySqlParameter("@ID",newsId)
           };
           #endregion

           #region - Excute -
           try
           {
               //记录查询
               DataTable dataTable = DbHelperMySql.GetDataSet(DbHelperMySql.connectionStringManager, selectDetailQy, paras).Tables[0];

               if (dataTable != null)
               {

                   foreach (DataRow row in dataTable.Rows)
                   {
                       newsMsgModel=TransNewsMsgModel(row);
                   }
               }
           }
           catch (Exception ex)
           {

               throw;
           }

           #endregion


           return newsMsgModel;

       }
        /// <summary>
        /// 获取新闻动态
        /// </summary>
        /// <param name="newsType">新闻类别</param>
        /// <returns>新闻动态列表</returns>
       public IList<NewsMsgModel> GetNewsMsgList(int newsType, int pageIndex, int pageSize,out int pageCount)
       {

           IList<NewsMsgModel> newsMsgList = new List<NewsMsgModel>();
           pageIndex = pageSize * (pageIndex - 1);
           #region - sql qy -

           string selectpageCountSql = @"SELECT  COUNT(1)
                                        FROM `dinlun`.`newsmsg` AS newsmsg
                                        WHERE newsmsg.`NewsType`=@NewsType";

           string selectSql = @"SELECT
                                   `ID`,
                                   `Title`,
                                   `Content`,
                                   `NewsType`,
                                   `ImgUrl`,
                                   `InsertTime`,
                                   `avg1`,
                                   `avg2`
                                 FROM `dinlun`.`newsmsg` AS newsmsg
                                 WHERE newsmsg.`NewsType`=@NewsType    
                                 ORDER BY newsmsg.ID DESC limit @PageIndex,@PageSize";
           #endregion

           #region - paras -
           MySqlParameter[] paras = 
           {
               new MySqlParameter("@NewsType",newsType),
               new MySqlParameter("@PageIndex",pageIndex),
               new MySqlParameter("@PageSize",pageSize)
           };
           #endregion


           #region - Excute -
           try
           {
               var o = DbHelperMySql.ExecuteScalar(DbHelperMySql.connectionStringManager, CommandType.Text, selectpageCountSql, paras);
               pageCount = int.Parse(o.ToString());
               //记录查询
               DataTable dataTable = DbHelperMySql.GetDataSet(DbHelperMySql.connectionStringManager, selectSql, paras).Tables[0];

               if (dataTable != null)
               {

                   foreach (DataRow row in dataTable.Rows)
                   {
                       newsMsgList.Add(TransNewsMsgModel(row));
                   }
               }
           }
           catch (Exception ex)
           {
               
               throw;
           }

           #endregion

           return newsMsgList;
       }
        #region - trans model -
        
        #endregion
        /// <summary>
        /// DataRow 转换至 NewsMsgModel 
        /// </summary>
        /// <param name="row">记录行</param>
        /// <returns>NewsMsgModel 实体</returns>
        public NewsMsgModel TransNewsMsgModel(DataRow row)
        {
            NewsMsgModel newsMsgModel = new NewsMsgModel();

            newsMsgModel.ID = row["ID"] != null ? (int)row["ID"]: 0;
            newsMsgModel.Title = row["Title"] != null ? row["Title"].ToString() : string.Empty;
            newsMsgModel.Content = row["Content"] != null ? row["Content"].ToString() : string.Empty;
            newsMsgModel.NewsType = row["NewsType"] != null ? (int)row["NewsType"] : 0;
            newsMsgModel.ImageUrl = row["ImgUrl"] != null ? row["ImgUrl"].ToString() : string.Empty;
            newsMsgModel.InsertTime = row["InsertTime"] != null ? Convert.ToDateTime(row["InsertTime"]) : DateTime.MinValue;
            newsMsgModel.Avg1 = row["avg1"] != null ? row["avg1"].ToString() : string.Empty;
            newsMsgModel.Avg2 = row["avg2"] != null ? row["avg2"].ToString() : string.Empty;

            return newsMsgModel;
        }
        #endregion


    }
}
