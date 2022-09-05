using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using WebApiPractise.Models;
using System.Data.Entity;
using System.Web.Http;

namespace WebApiPractise.Controllers
{
    public class StudentController : ApiController
    {
        SAMPLESQLEntities db = new SAMPLESQLEntities();

        [HttpGet]
        [Route("DisplayData")]
        public List<StudentApi>GetData()
        {
            return db.StudentApis.ToList();
        }
       
        [HttpPost]
        [Route("InsertData")]
        public void InsertData(StudentApi std)
        {
            db.StudentApis.Add(std);
            db.SaveChanges();
            //return db.StudentApis.ToList();
        }


        [HttpGet]
        [Route("DeleteData/{id}")]
        public void DeleteData(int id)
        {
            var res = db.StudentApis.FirstOrDefault(x => x.ID == id);
            db.StudentApis.Remove(res);
            db.SaveChanges();
        }

        [HttpGet]
        [Route("SelectData/{id}")]
        public StudentApi SelectData(int id)
        {
            var res = db.StudentApis.FirstOrDefault(x => x.ID == id);
            return res;
        }
      
         [HttpPut]
        [Route("UpdateData")]
        public void UpdateData(StudentApi std)
        {
            var res = db.StudentApis.FirstOrDefault(x => x.ID == std.ID);
            res.Name = std.Name;
            res.grade = std.grade;
            res.Address = std.Address;
            res.Pin = std.Pin;
            res.PhoneNo = std.PhoneNo;
            res.CourseID = std.CourseID;
            db.SaveChanges();

        }
    }
}
