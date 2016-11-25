using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace TrabalhoG2.Models
{
    public class InputStockProductRepository
    {
        MyDbContext db = new MyDbContext();

        public void Create(InputStockProduct inputStockProduct)
        {
            inputStockProduct.input_stock = db.InputStock.Find(inputStockProduct.input_stock.id_input_stock);
            inputStockProduct.product = db.Product.Find(inputStockProduct.product.id_product);
            db.InputStockProduct.Add(inputStockProduct);
            db.SaveChanges();
        }

        public IEnumerable<InputStockProduct> GetInputStockProduct(int id)
        {
            return db.InputStockProduct.Include(x => x.product).Where(x => x.input_stock.id_input_stock == id);
        }

        public InputStockProduct GetOne(int id)
        {
            return db.InputStockProduct.Find(id);
        }

        public void Delete(int id)
        {
            db.InputStockProduct.RemoveRange(GetInputStockProduct(id));
            db.SaveChanges();
        }

        public void DeleteOne(int id)
        {
            db.InputStockProduct.Remove(GetOne(id));
            db.SaveChanges();
        }

    }
}