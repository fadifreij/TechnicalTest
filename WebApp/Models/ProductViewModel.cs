using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebApp.Models
{
    public class ProductViewModel
    {
        [Required]
        public string Style { get; set; }
         [Required]
        public string Colour { get; set; }
        public string Sku { get; set; }
        [Required]
        public string Title { get; set; }
        [Required]
        public decimal Price { get; set; }
        [Required]
        public int Stock { get; set; }
    }
}
