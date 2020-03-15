﻿using System;
using System.Collections.Generic;
using System.Text;

namespace DataBaseProject.Models
{
   public class Product
    {
        public int Id { get; set; }
        public string Style { get; set; }
        public string Colour { get; set; }
        public string Sku { get; set; }
        public string Title { get; set; }
        public decimal Price { get; set; }
        public int Stock { get; set; }
    }
}
