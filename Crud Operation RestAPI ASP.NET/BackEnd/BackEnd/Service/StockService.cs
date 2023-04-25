using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using BackEnd.Models;
using BackEnd.CustomException;
namespace BackEnd.Service

{
    public class StockService
    {
        DBConnection db = new DBConnection();

        public IEnumerable<Stock> GetAllStocks()
        {
            return db.Stocks.ToList();
        }
        public void AddStock(Stock stock)
        {
            Stock temp=db.Stocks.Add(stock);
            db.SaveChanges();
            
        }

        public Stock GetStockById(int id)
        {
           Stock stock=db.Stocks.Find(id);
            if (stock != null)
                return stock;
            throw new StockNotFound("Stock not Found please Enter Valid Id");
            
        }

        public Stock DeleteStockById(int id)
        {
         Stock stock= db.Stocks.Find(id);
            if (stock != null)
            {
                db.Stocks.Remove(stock);
                db.SaveChanges();
                return stock;
            }
            throw new StockNotFound("Stock not Found please Enter Valid Id");
        }
    }
}