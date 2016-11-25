using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace TrabalhoG2.Models
{
    public class InputStockProduct
    {
        [Key]
        public int id_input_stock_product { get; set; }
        public double value { get; set; }
        public double amount { get; set; }
        public InputStock input_stock { get; set; }
        public Product product { get; set; }


    }
}