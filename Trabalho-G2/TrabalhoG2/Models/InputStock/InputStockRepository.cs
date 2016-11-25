using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TrabalhoG2.Models
{
    public class InputStockRepository
    {
        MyDbContext db = new MyDbContext();

        public void Create(InputStock inputStock)
        {
            db.InputStock.Add(inputStock);
            db.SaveChanges();
        }

        public IEnumerable<InputStock> GetAll()
        {
            return db.InputStock.ToList();
        }

        public InputStock GetOne(int id)
        {
            return db.InputStock.Find(id);
        }

        public void Delete(int id)
        {
            db.InputStock.Remove(GetOne(id));
            db.SaveChanges();
        }
    }
}