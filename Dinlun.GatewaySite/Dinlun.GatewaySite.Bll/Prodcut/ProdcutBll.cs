using Dinlun.GatewaySite.Dal.Prodcut;
using Dinlun.GatewaySite.Model.Prodcut;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dinlun.GatewaySite.Bll
{
   public  class ProdcutBll
    {
       private  ProdcutDal _prodcutInstance=new ProdcutDal();


       public ProdcutBll() { }

        #region - method -
              /// <summary>
       /// 获取产品详情
       /// </summary>
       /// <param name="prodcutID">产品ID</param>
       /// <returns></returns>
       public ProductDetailModel GetProdcutDetailBy(int prodcutID)
       {
           return _prodcutInstance.GetProdcutDetailBy(prodcutID);
       }
       /// <summary>
       /// 获取产品信息
       /// </summary>
       /// <returns></returns>
       public IList<ProdcutModel> GetProductList()
       {
           return _prodcutInstance.GetProductList();
       }

        #endregion
    }
}
