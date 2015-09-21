using Dinlun.GatewaySite.Common;
using Dinlun.GatewaySite.Model.Prodcut;
using MySql.Data.MySqlClient;
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
       /// 获取产品详情
       /// </summary>
       /// <param name="prodcutID">产品ID</param>
       /// <returns></returns>
       public ProductDetailModel GetProdcutDetailBy(int prodcutID)
       {
           ProductDetailModel productDetailModel = null;

           #region - sql qy -

           string selectQy = @"SELECT
                                 `ID`,
                                 `ProdcutID`,
                                 `Content`,
                                 `InsertTime`,
                                 `UpdateTime`,
                                 `Avg1`,
                                 `Avg2`
                               FROM `dinlun`.`prodcutdetail`  AS prdDetail
                               WHERE prdDetail.`ProdcutID`=@ProdcutID";

           #endregion

           #region - paras -
           MySqlParameter[] paras = 
           {
               new MySqlParameter("@ProdcutID",prodcutID)
           };
           #endregion

           #region - excute -
           try
           {
               //记录查询
               DataTable dataTable = DbHelperMySql.GetDataSet(DbHelperMySql.connectionStringManager, selectQy, paras).Tables[0];

               if (dataTable != null)
               {

                   foreach (DataRow row in dataTable.Rows)
                   {
                     productDetailModel=  TransProductDetailModel(row);
                   }
               }
           }
           catch (Exception ex)
           {
               
               throw;
           }
           #endregion

           return productDetailModel;
       }


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
       
         //<summary>
         //DataRow 转换至 ProdcutModel 
         //</summary>
         //<param name="row">记录行</param>
         //<returns>NewsMsgModel 实体</returns>
        public ProdcutModel TransProdcutModel(DataRow row)
        {
            ProdcutModel prodcutModel = new ProdcutModel();
            prodcutModel.ID = row["ID"] != null ? (int)row["ID"] : 0;
            prodcutModel.ProdcutName = row["ProductName"] != null ? row["ProductName"].ToString() : string.Empty;
            prodcutModel.ImageUrl = row["ImageUrl"] != null ? row["ImageUrl"].ToString() : string.Empty;
            prodcutModel.Description = row["Description"] != null ? row["Description"].ToString() : string.Empty;
            prodcutModel.InserTime = row["InsertTime"] != null ? Convert.ToDateTime(row["InsertTime"]) : DateTime.MinValue;
            prodcutModel.UpdateTime = row["UpdateTime"] != null ? Convert.ToDateTime(row["UpdateTime"]) : DateTime.MinValue;
            prodcutModel.Avg1 = row["avg1"] != null ? row["avg1"].ToString() : string.Empty;
            prodcutModel.Avg2 = row["avg2"] != null ? row["avg2"].ToString() : string.Empty;
            return prodcutModel;
        }

        /// <summary>
       /// DataRow 转换至 ProductDetailModel 
        /// </summary>
        /// <param name="row">记录行</param>
        /// <returns>NewsMsgModel 实体</returns>
       public ProductDetailModel TransProductDetailModel(DataRow row)
        {
            ProductDetailModel productDetailModel = new ProductDetailModel();
            productDetailModel.ID = row["ID"] != null ? (int)row["ID"] : -1;
            productDetailModel.ProdcutID = row["ProdcutID"] != null ? (int)row["ProdcutID"] : -1;
            productDetailModel.Content = row["Content"] != null ? row["Content"].ToString() : string.Empty;
            productDetailModel.UpdateTime = row["UpdateTime"] != null ? Convert.ToDateTime(row["UpdateTime"]) : DateTime.MinValue;
            productDetailModel.InserTime = row["InsertTime"] != null ? Convert.ToDateTime(row["InsertTime"]) : DateTime.MinValue;
            productDetailModel.Avg1 = row["avg1"] != null ? row["avg1"].ToString() : string.Empty;
            productDetailModel.Avg2 = row["avg2"] != null ? row["avg2"].ToString() : string.Empty;
            return productDetailModel;
        }


       #endregion



       #endregion
   }
}
