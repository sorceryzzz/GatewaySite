﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dinlun.GatewaySite.Model.News
{
   public class ResultNewsMsgListModel
    {

       public IList<NewsMsgModel> NewsMsgList { set; get; }

       public int PageCount { set; get; }


    }
}
