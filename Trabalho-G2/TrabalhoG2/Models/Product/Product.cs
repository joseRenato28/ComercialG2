using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace TrabalhoG2.Models
{
    public class Product
    {
        [Key]
        public int id_product { get; set; }
        public string product_name { get; set; }
        public double amount { get; set; }

        public virtual IEnumerable<InputStockProduct> InputStockProducts { get; set; }
        public virtual IEnumerable<OutputStockProduct> OutputStockProduct { get; set; }
    }
}