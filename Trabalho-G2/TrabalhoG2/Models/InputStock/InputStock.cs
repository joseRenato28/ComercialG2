using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace TrabalhoG2.Models
{
    public class InputStock
    {
        [Key]
        public int id_input_stock { get; set; }
        public string supplier { get; set; }
        public DateTime entry_date { get; set; }

        public virtual IEnumerable<InputStockProduct> InputStockProducts { get; set; }
    }
}