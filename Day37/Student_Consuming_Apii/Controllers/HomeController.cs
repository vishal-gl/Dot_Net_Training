using Newtonsoft.Json;
using Student_Consuming_Apii.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;

namespace Student_Consuming_Apii.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            using (WebClient webClient = new WebClient())
            {
                webClient.Headers.Add("Contet-type:application/Json");
                webClient.Headers.Add("Accept:application/Json");
                string res = webClient.DownloadString("https://localhost:44332/DisplayData");
                var list = JsonConvert.DeserializeObject<List<Student>>(res);
                return View(list);
            }
            
        }

        public ActionResult InsertData()
        {

            return View();
        }


        [HttpPost]
        public ActionResult InsertData(Student std)
        {
            try
            {
                using (WebClient webClient = new WebClient())
                {
                    webClient.Headers.Add("Content-type:application/Json");
                    webClient.Headers.Add("Accept:application/Json");
                    webClient.UploadString("https://localhost:44332/InsertData", JsonConvert.SerializeObject(std));

                }
            }
            catch (Exception ex)
            {
                Response.Write(ex.Message);

            }
            return RedirectToAction("Index");
        }
        public ActionResult Details(int id)
        {
            using (WebClient webClient = new WebClient())
            {
                webClient.Headers.Add("Content-type:application/Json");
                webClient.Headers.Add("Accept:application/Json");
                string res = webClient.DownloadString("https://localhost:44332/SelectData/" + id.ToString());
                var list = JsonConvert.DeserializeObject<Student>(res);
                return View(list);

            }

        }
        public ActionResult Delete(int id)
        {
            using (WebClient webClient = new WebClient())
            {
                webClient.Headers.Add("Content-type:application/Json");
                webClient.Headers.Add("Accept:application/Json");
                string res = webClient.DownloadString("https://localhost:44332/DeleteData/" + id.ToString());
                return RedirectToAction("Index");
            }
        }
        [HttpGet]
        public ActionResult UpdateData(int id)
        {
            using (WebClient webClient = new WebClient())
            {
                webClient.Headers.Add("Content-type:application/Json");
                webClient.Headers.Add("Accept:application/Json");
                string res = webClient.DownloadString("https://localhost:44332/SelectData/" + id.ToString());
                return View(JsonConvert.DeserializeObject<Student>(res));
            }


        }

        [HttpPost]
        public ActionResult UpdateData(Student std)
        {
            using (WebClient webClient = new WebClient())
            {
                webClient.Headers.Add("Content-type:application/Json");
                webClient.Headers.Add("Accept:application/Json");
                webClient.UploadString("https://localhost:44332/UpdateData", "PUT", JsonConvert.SerializeObject(std));
                return RedirectToAction("Index");
            }


        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}