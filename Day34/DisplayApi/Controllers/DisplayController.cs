using DisplayApi.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;

namespace DisplayApi.Controllers
{
    public class DisplayController : Controller
    {
        // GET: Display
        
        public ActionResult Index()
        {
            string url = "https://localhost:44342/GetEmployee";
            WebClient webClient = new WebClient();

            webClient.Headers.Add(HttpRequestHeader.ContentType, "application/json");
            webClient.Headers.Add("Accept:application/json");

            var response = webClient.DownloadString(url);
            var r = JsonConvert.DeserializeObject<List<Employee>>(response);

            return View(r);
           
        }
        public ActionResult Insert()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Insert(Employee e)
        {
            string url = "https://localhost:44342/PostInsertEmployee";
            WebClient webClient = new WebClient();

            webClient.Headers.Add(HttpRequestHeader.ContentType, "application/json");
            webClient.Headers.Add("Accept:application/json");

            var response = webClient.UploadString(url,JsonConvert.SerializeObject(e));
            

            return RedirectToAction("Index");

        }
        
        
        public ActionResult Delete1(string id)
        {
            string url = $"https://localhost:44342/api/Employees/Delete/{id}";
            WebClient webClient = new WebClient();

            webClient.Headers.Add(HttpRequestHeader.ContentType, "application/json");
            webClient.Headers.Add("Accept:application/json");

            var response = webClient.UploadString(url,"Delete","");


            return RedirectToAction("Index");

        }
        public ActionResult Edit(string id)
        {
            string url = $"https://localhost:44342/api/Employees/PutEmployee/{id}";
            WebClient webClient = new WebClient();

            webClient.Headers.Add(HttpRequestHeader.ContentType, "application/json");
            webClient.Headers.Add("Accept:application/json");

            var response = webClient.UploadString(url, "Edit", "");


            return RedirectToAction("Index");

        }
    }
}