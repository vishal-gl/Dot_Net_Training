using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Partial_View.Models
{
    public class Product
    {
        public long ProductId { get; set; }

        public string Name { get; set; }

        public string Category { get; set; }

        public string Description { get; set; }

        public decimal Price { get; set; }
    }
}