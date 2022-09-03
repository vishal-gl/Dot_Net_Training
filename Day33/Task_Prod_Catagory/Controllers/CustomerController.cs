using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Task_Prod_Catagory.Controllers
{

    public class CustomerController : Controller
    {
        // GET: Customer
        public ActionResult Index(int i)
        {
            if (i == 0)
            {
                return View("View1");

            }
            else
            {
                return View("View2");
            }
            
        }
        public ActionResult Index2()
        {
            ViewData["MyKey"] = "SomeValue";
            return View("Index2");

        }
    }
}