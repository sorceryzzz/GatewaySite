using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dinlun.GatewaySite.Model.Contact
{
   public class ContactDescModel
   {

       #region - feild -
       private int _id;
       private string _contactWay;
       private string _place;
       private DateTime _inserTime;
       private DateTime _updateTime;
       private string _avg1;
       private string _avg2;
       #endregion

       #region - property -
       /// <summary>
       /// 主键
       /// </summary>
       public int ID { set { _id = value; } get{return _id;} }
       /// <summary>
       /// 联系方式
       /// </summary>
       public string ContactWay { set { _contactWay = value; } get { return _contactWay; } }
       /// <summary>
       /// 地理位置
       /// </summary>
       public string Place{set{_place=value;}get{return _place;}}
       /// <summary>
       /// 记录生成时间
       /// </summary>
       public DateTime InserTime { set { _inserTime = value; } get { return _inserTime; } }

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
