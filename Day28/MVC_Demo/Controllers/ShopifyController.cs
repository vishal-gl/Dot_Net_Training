using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVC_Demo.Controllers
{
    public class ShopifyController : Controller
    {
        // GET: Shopify
        public ActionResult ViewIndex()
        {
            return View();
        }
    }
}