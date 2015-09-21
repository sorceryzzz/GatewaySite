using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dinlun.GatewaySite.Model.Prodcut
{
   public  class ProductDetailModel
   {

       #region - feild -
       private int _id;
       private int _prodcutID;
       private string _content;
       private DateTime _insertTime;
       private DateTime _updateTime;
       private string _avg1;
       private string _avg2;
       #endregion


       #region - property -
       /// <summary>
       /// 主键
       /// </summary>
       public int ID { set { _id = value; } get { return _id; } }

       /// <summary>
       /// 产品ID
       /// </summary>
       public int ProdcutID { set { _prodcutID = value; } get { return _prodcutID; } }
       /// <summary>
       /// 产品描述
       /// </summary>
       public string Content { set { _content = value; } get { return _content; } }


       /// <summary>
       /// 记录生成时间
       /// </summary>
       public DateTime InserTime { set { _insertTime = value; } get { return _insertTime; } }

       /// <summary>
       /// 更新时间
       /// </summary>
       public DateTime UpdateTime { set { _updateTime = value; } get { return _updateTime; } }

       /// <summary>
       /// 扩展字段1
       /// </summary>
       public string Avg1 { set { _avg1 = value; } get { return _avg1; } }

       /// <summary>
       /// 扩展字段2
       /// </summary>
       public string Avg2 { set { _avg2 = value; } get { return _avg2; } }


       #endregion

    }
}
