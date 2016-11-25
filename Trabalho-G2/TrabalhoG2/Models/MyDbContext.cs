using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace TrabalhoG2.Models
{
    public class MyDbContext: DbContext
    {
        public MyDbContext()
            : base("MyDbContext")
        {

        }

        public DbSet<Product> Product { get; set; }
        public DbSet<InputStock> InputStock { get; set; }
        public DbSet<InputStockProduct> InputStockProduct { get; set; }
        public DbSet<OutputStock> OutputStock { get; set; }
        public DbSet<OutputStockProduct> OutputStockProduct { get; set; }
    }
}