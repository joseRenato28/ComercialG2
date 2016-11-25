using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace TrabalhoG2.Models
{
    public class OutputStockProduct
    {
        [Key]
        public int id_output_stock_product { get; set; }
        public double value { get; set; }
        public double amount { get; set; }
        public OutputStock output_stock { get; set; }
        public Product product { get; set; }
    }
}