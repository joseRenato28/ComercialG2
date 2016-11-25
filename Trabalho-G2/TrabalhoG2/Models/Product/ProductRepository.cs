using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TrabalhoG2.Models
{
    public class ProductRepository
    {
        MyDbContext db = new MyDbContext();

        public void Create(Product product)
        {
            db.Product.Add(product);
            db.SaveChanges();
        }

        public IEnumerable<Product> GetAll()
        {
            return db.Product.ToList();
        }

        public Product GetOne(int id)
        {
            return db.Product.Find(id);
        }

        public void Delete(int id)
        {
            db.Product.Remove(GetOne(id));
            db.SaveChanges();
        }

        public void Update(Product product)
        {
            var productUpdate = db.Product.FirstOrDefault(c => c.id_product == product.id_product);
            productUpdate.product_name = product.product_name;
            db.SaveChanges();
        }

    }
}