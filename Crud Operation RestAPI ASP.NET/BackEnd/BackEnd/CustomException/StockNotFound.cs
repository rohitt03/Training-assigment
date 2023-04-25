using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BackEnd.CustomException
{
    public class StockNotFound:Exception
    {
        public StockNotFound(String msg):base(msg) { }
      
             
    }
}