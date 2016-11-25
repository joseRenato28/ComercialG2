using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace TrabalhoG2.Models
{
    public class OutputStock
    {
        [Key]
        public int id_output_stock { get; set; }
        public string sector { get; set; }
        public DateTime output_date { get; set; }

        public virtual IEnumerable<OutputStockProduct> OutputStockProduct { get; set; }
    }
}