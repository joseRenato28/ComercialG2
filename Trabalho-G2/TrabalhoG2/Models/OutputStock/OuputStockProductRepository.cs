using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace TrabalhoG2.Models
{
    public class OuputStockProductRepository
    {
        MyDbContext db = new MyDbContext();

        public void Create(OutputStockProduct outputStockProduct)
        {
            outputStockProduct.output_stock = db.OutputStock.Find(outputStockProduct.output_stock.id_output_stock);
            outputStockProduct.product = db.Product.Find(outputStockProduct.product.id_product);
            db.OutputStockProduct.Add(outputStockProduct);
            db.SaveChanges();
        }

        public IEnumerable<OutputStockProduct> GetOutputStockProduct(int id)
        {
            return db.OutputStockProduct.Include(x => x.product).Where(x => x.output_stock.id_output_stock == id);
        }

        public void Delete(int id)
        {
            db.OutputStockProduct.RemoveRange(GetOutputStockProduct(id));
            db.SaveChanges();
        }

        public OutputStockProduct GetOne(int id)
        {
            return db.OutputStockProduct.Find(id);
        }

        public void DeleteOne(int id)
        {
            db.OutputStockProduct.Remove(GetOne(id));
            db.SaveChanges();
        }
    }
}