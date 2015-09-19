using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dinlun.GatewaySite.Model.News
{
   public  class NewsMsgModel
   {
       #region - feild -
       private int _ID;
       private string _title;
       private string _content;
       private int _newsType;
       private string _imageUrl;
       private DateTime _insertTime;
       private string _avg1;
       private string _avg2;
       #endregion

       #region - property -
       /// <summary>
       /// 主键
       /// </summary>
       public int ID { set { _ID = value; } get { return _ID; } }
       /// <summary>
       /// 新闻标题
       /// </summary>
       public string Title { set { _title = value; } get { return _title; } }
       /// <summary>
       /// 新闻内容
       /// </summary>
       public string Content { set { _content = value; } get { return _content; } }
       /// <summary>
       /// 新闻类别
       /// </summary>
       public int NewsType { set { _newsType = value; } get { return _newsType; } }
       /// <summary>
       /// 图片链接
       /// </summary>
       public string ImageUrl { set { _imageUrl = value; } get { return _imageUrl; } }
       /// <summary>
       ///记录生成时间
       /// </summary>
       public DateTime InsertTime { set { _insertTime = value; } get { return _insertTime; } }
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
