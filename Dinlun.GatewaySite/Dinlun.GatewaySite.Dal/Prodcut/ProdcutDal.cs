using Dinlun.GatewaySite.Common;
using Dinlun.GatewaySite.Model.Prodcut;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dinlun.GatewaySite.Dal.Prodcut
{
   public class ProdcutDal
   {
       public ProdcutDal() { }

       #region - method -
       /// <summary>
       /// 获取产品信息
       /// </summary>
       /// <returns></returns>
       public IList<ProdcutModel> GetProductList()
       {
           IList<ProdcutModel> prdocutList = new List<ProdcutModel>();


           #region - sql qy-
           string selectQy = @"SELECT
                                 `ID`,
                                 `ProductName`,
                                 `ImageUrl`,
                                 `Description`,
                                 `InserTime`,
                                 `UpdateTime`,
                                 `Avg1`,
                                 `Avg2`
                               FROM `dinlun`.`product`";
           #endregion


           #region - paras -
           
           #endregion

           #region - excute -
           try
           {

               //记录查询
               DataTable dataTable = DbHelperMySql.GetDataSet(DbHelperMySql.connectionStringManager, selectQy).Tables[0];

               if (dataTable != null)
               {

                   foreach (DataRow row in dataTable.Rows)
                   {
                       prdocutList.Add(TransProdcutModel(row));
                   }
               }
           }
           catch (Exception ex)
           {

               throw;
           }
           #endregion

           return prdocutList;
       }

       #region - trans model -
       
         /// <summary>
        /// DataRow 转换至 ProdcutModel 
        /// </summary>
        /// <param name="row">记录行</param>
        /// <returns>NewsMsgModel 实体</returns>
        public ProdcutModel TransProdcutModel(DataRow row)
        {
            ProdcutModel prodcutModel = new ProdcutModel();

            //newsMsgModel.ID = row["ID"] != null ? (int)row["ID"]: 0;
            //newsMsgModel.Title = row["Title"] != null ? row["Title"].ToString() : string.Empty;
            //newsMsgModel.Content = row["Content"] != null ? row["Content"].ToString() : string.Empty;
            //newsMsgModel.NewsType = row["NewsType"] != null ? (int)row["NewsType"] : 0;
            //newsMsgModel.ImageUrl = row["ImgUrl"] != null ? row["ImgUrl"].ToString() : string.Empty;
            //newsMsgModel.InsertTime = row["InsertTime"] != null ? Convert.ToDateTime(row["InsertTime"]) : DateTime.MinValue;
            //newsMsgModel.Avg1 = row["avg1"] != null ? row["avg1"].ToString() : string.Empty;
            //newsMsgModel.Avg2 = row["avg2"] != null ? row["avg2"].ToString() : string.Empty;

            //ret


            return prodcutModel;
        }
       #endregion



       #endregion
   }
}
