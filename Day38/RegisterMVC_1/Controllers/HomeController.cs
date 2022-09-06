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
            return RedirectToAction("Login");
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
                string url = std.UserName+"/"+std.Password;
                webClient.Headers.Add("Content-type:application/Json");
                webClient.Headers.Add("Accept:application/Json");
                string response = webClient.DownloadString("https://localhost:44396/LoginData/"+url);
                var res = JsonConvert.DeserializeObject<int>(response);
                if (res != 0)
                {
                    return View("SuccsesFullyLogin");
                }
                else
                {
                    return View("FailedLogin");
                }
                
                

                
               

            }
                    

           
            


        }
        public ActionResult SuccsesFullyLogin()
        {
            return View();
        }
        public ActionResult FailedLogin()
        {
            return View();
        }
    }
}