using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TrabalhoG2.Models
{
    public class OutputStockRepository
    {
        MyDbContext db = new MyDbContext();

        public void Create(OutputStock outputStock)
        {
            db.OutputStock.Add(outputStock);
            db.SaveChanges();
        }

        public IEnumerable<OutputStock> GetAll()
        {
            return db.OutputStock.ToList();
        }

        public OutputStock GetOne(int id)
        {
            return db.OutputStock.Find(id);
        }

        public void Delete(int id)
        {
            db.OutputStock.Remove(GetOne(id));
            db.SaveChanges();
        }
    }
}