using ConsumingApi.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;

namespace ConsumingApi.Controllers
{
    public class DisplayController : Controller
    {
        // GET: Display
        public ActionResult Index()
        {
            string url = "https://localhost:44383/GetEmployee";
            WebClient webClient = new WebClient();

            webClient.Headers.Add(HttpRequestHeader.ContentType, "application/json");
            webClient.Headers.Add("Accept:application/json");

            var response = webClient.DownloadString(url);
            var r = JsonConvert.DeserializeObject<List<Emp>>(response);

            return View(r);
            
        }

        public ActionResult Insert()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Insert(Emp e)
        {
            string url = "https://localhost:44383/InsertEmployee";
            WebClient webClient = new WebClient();

            webClient.Headers.Add(HttpRequestHeader.ContentType, "application/json");
            webClient.Headers.Add("Accept:application/json");

            var response = webClient.UploadString(url, JsonConvert.SerializeObject(e));


            return RedirectToAction("Index");

        }
        public ActionResult Edit(string id)
        {
            using (WebClient webclient = new WebClient())
            {
                webclient.Headers.Add("Content-type:application/json");
                webclient.Headers.Add("Accept:application/json");
                string response = webclient.DownloadString("https://localhost:44383/SingleEmployee/{id}");
                var r = JsonConvert.DeserializeObject<Emp>(response);
                return View(r);

            }

        }
        [HttpPost]
        
        public ActionResult Edit(Emp e)
        {
            using (WebClient webclient = new WebClient())
            {
                webclient.Headers.Add("Content-type:application/json");
                webclient.Headers.Add("Accept:application/json");
                string response = webclient.UploadString($"https://localhost:44383/UpdateEmployee","PUT",JsonConvert.SerializeObject(e));
                return RedirectToAction("Index");

            }
        }

        
        public ActionResult Delete1(string id)
        {
            string url = $"https://localhost:44383/Delete{id}";
            WebClient webClient = new WebClient();

            webClient.Headers.Add(HttpRequestHeader.ContentType, "application/json");
            webClient.Headers.Add("Accept:application/json");

            var response = webClient.DownloadString(url);


            return RedirectToAction("Index");

        }

    }
}