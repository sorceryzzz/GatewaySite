﻿using Dinlun.GatewaySite.Common;
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
        /// 获取新闻动态
        /// </summary>
        /// <param name="newsType">新闻类别</param>
        /// <returns>新闻动态列表</returns>
       public IList<NewsMsgModel> GetNewsMsgList(int newsType, int pageIndex, int pageSize,out int pageCount)
       {

           IList<NewsMsgModel> newsMsgList = new List<NewsMsgModel>();

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
                                 AND (newsmsg.ID >=(
                                        SELECT MAX(newsmsgtmp.ID) FROM (
                                            SELECT newsA.ID FROM `dinlun`.`newsmsg` AS newsA ORDER BY newsA.ID LIMIT @PageIndex,@PageSize) AS newsmsgtmp
                                        ) )
                                 ORDER BY newsmsg.ID DESC";
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
