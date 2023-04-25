using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using BackEnd.Models;
using BackEnd.Service;
namespace BackEnd.Controllers
{
    public class StockController : ApiController
    {
        StockService ss = new StockService();
        public IEnumerable<Stock> Get()
        {
            return ss.GetAllStocks();
        }

        public Object Get(int id)
        {
            try
            {
               return ss.GetStockById(id);

            }catch(Exception ex)
            {
                return ex.Message;
            }
        }
        public String Post(Stock stock)
        {
            try
            {
                 ss.AddStock(stock);
                return "stock added successfully";
            }catch(Exception ex)
            {
                return ex.Message;
            }
          

        }

        public Object Delete(int id)
        {
            try
            {
               return ss.DeleteStockById(id);
            }catch(Exception ex)
            {
                return ex.Message;
            }

        }
    }
}
