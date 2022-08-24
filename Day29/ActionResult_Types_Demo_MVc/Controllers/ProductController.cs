using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ActionResult_Types_Demo_MVc.Models;


namespace ActionResult_Types_Demo_MVc.Controllers

{
    public class ProductController : Controller
    {
        // GET: Product
        public ActionResult Index()
        {
            List<Product> products = new List<Product>()
            {
                new Product{ProductId=1,Name="Chilli",Category="Category1",Description="Grocery",Price=23},
                new Product { ProductId = 2, Name = "Chilli", Category = "Category1", Description = "Grocery", Price = 23 },
                new Product{ProductId=3,Name="Chilli",Category="Category1",Description="Grocery",Price=23},
                new Product{ProductId=4,Name="Chilli",Category="Category1",Description="Grocery",Price=45}
            };
            return View(products);
        }
    }
}