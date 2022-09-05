using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using StudentMVC.Models;
using System.Data.Entity;
using System.Net;
using Newtonsoft.Json;

namespace StudentMVC.Controllers
{
    public class HomeController : Controller
    {
        SAMPLESQLEntities db = new SAMPLESQLEntities();

        public ActionResult Index()
        {
            using (WebClient webClient = new WebClient())
            {
                webClient.Headers.Add("Contet-type:application/Json");
                webClient.Headers.Add("Accept:application/Json");
                string res = webClient.DownloadString("https://localhost:44374/DisplayData");
                var list = JsonConvert.DeserializeObject<List<StudentApi>>(res);
                return View(list);
            }
           
        }

        
        public ActionResult InsertData()
        {
           
            return View();
        }
       
        
        [HttpPost]
        public ActionResult InsertData(StudentApi std)
        {
            try
            {
                using (WebClient webClient = new WebClient())
                {
                    webClient.Headers.Add("Content-type:application/Json");
                    webClient.Headers.Add("Accept:application/Json");
                    webClient.UploadString("https://localhost:44374/InsertData", JsonConvert.SerializeObject(std));
                   
                }
            }
            catch(Exception ex)
            {

            }
            return RedirectToAction("Index");
        }

        public ActionResult Delete(int id)
        {
            using (WebClient webClient = new WebClient())
            {
                webClient.Headers.Add("Content-type:application/Json");
                webClient.Headers.Add("Accept:application/Json");
                string res = webClient.DownloadString("https://localhost:44374/DeleteData/"+id.ToString());
                return RedirectToAction("Index");
            }
        }

        public ActionResult Details(int id)
        {
            using (WebClient webClient = new WebClient())
            {
                webClient.Headers.Add("Content-type:application/Json");
                webClient.Headers.Add("Accept:application/Json");
                string res = webClient.DownloadString("https://localhost:44374/SelectData/" + id.ToString());
                var list = JsonConvert.DeserializeObject<StudentApi>(res);
                return View(list);
                
            }
            
        }

        [HttpGet]
        public ActionResult UpdateData(int id)
        {
            using (WebClient webClient = new WebClient())
            {
                webClient.Headers.Add("Content-type:application/Json");
                webClient.Headers.Add("Accept:application/Json");
                string res = webClient.DownloadString("https://localhost:44374/SelectData/" + id.ToString());
                return View(JsonConvert.DeserializeObject<StudentApi>(res));
            }

           
        }
        
        [HttpPost]
        public ActionResult UpdateData(StudentApi std)
        { 
                using (WebClient webClient = new WebClient())
                {
                    webClient.Headers.Add("Content-type:application/Json");
                    webClient.Headers.Add("Accept:application/Json");
                    webClient.UploadString("https://localhost:44374/UpdateData","PUT", JsonConvert.SerializeObject(std));
                    return RedirectToAction("Index");
            }
          
            
        }
    }
}