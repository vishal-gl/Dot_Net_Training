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
        public ActionResult Login()
        {
            RegisterMVC obj = new RegisterMVC();
            return View(obj);
        }
        

        public ActionResult Login(string username,string password)
        {
            using (WebClient webClient = new WebClient())
            {
                webClient.Headers.Add("Content-type:application/Json");
                webClient.Headers.Add("Accept:application/Json");
                string res = webClient.DownloadString("https://localhost:44332/LoginData/" + username+password);
                var list = JsonConvert.DeserializeObject<RegisterMVC>(res);
                return View(list);

            }

        }

    }
}