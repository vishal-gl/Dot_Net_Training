using Newtonsoft.Json;
using RegisterMVC_1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;

namespace RegisterMVC_1.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            using (WebClient webClient = new WebClient())
            {
                webClient.Headers.Add("Contet-type:application/Json");
                webClient.Headers.Add("Accept:application/Json");
                string res = webClient.DownloadString("https://localhost:44396/DisplayData");
                var list = JsonConvert.DeserializeObject<List<RegisterMVC>>(res);
                return View(list);
            }

        }

        public ActionResult InsertData()
        {

            return View();
        }


        [HttpPost]
        public ActionResult InsertData(RegisterMVC r)
        {
            try
            {
                using (WebClient webClient = new WebClient())
                {
                    webClient.Headers.Add("Content-type:application/Json");
                    webClient.Headers.Add("Accept:application/Json");
                    webClient.UploadString("https://localhost:44396/InsertData", JsonConvert.SerializeObject(r));

                }
            }
            catch (Exception ex)
            {
                Response.Write(ex.Message);

            }
            return RedirectToAction("Index");
        }

        [HttpGet]
        public ActionResult Login()
        {
            return View();
            


        }


        [HttpPost]
        public ActionResult Login(RegisterMVC std)
        {
            using (WebClient webClient = new WebClient())
            {
                webClient.Headers.Add("Content-type:application/Json");
                webClient.Headers.Add("Accept:application/Json");
                webClient.UploadString("https://localhost:44396/LoginData", "PUT", JsonConvert.SerializeObject(std));
                return RedirectToAction("SuccsesFullyLogin");
            }


        }
        public ActionResult SuccsesFullyLogin()
        {
            return View();
        }

    }
}