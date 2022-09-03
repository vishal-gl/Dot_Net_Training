using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
namespace Task_Prod_Catagory.Models
{
    public class ShopContext7:DbContext
    {
        public ShopContext7() : base("Default")
        {

        }


        public DbSet<Product> Products { get; set; }

        public DbSet<Category> Categories { get; set; }
    }
}