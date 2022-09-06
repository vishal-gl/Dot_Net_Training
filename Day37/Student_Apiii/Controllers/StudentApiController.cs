using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Student_Apiii.Controllers
{
    public class StudentApiController : ApiController
    {
        StudentEntities db = new StudentEntities();

        [HttpGet]
        [Route("DisplayData")]
        public List<Student> GetData()
        {
            return db.Students.ToList();
        }

        [HttpGet]
        [Route("SelectData/{id}")]
        public Student SelectData(int id)
        {
            var res = db.Students.FirstOrDefault(x => x.Id == id);
            return res;
        }

        [HttpPost]
        [Route("InsertData")]
        public int InsertData(Student std)
        {
            db.Students.Add(std);
            int res=db.SaveChanges();
            return res;
           
        }

        [HttpGet]
        [Route("DeleteData/{id}")]
        public void DeleteData(int id)
        {
            var res = db.Students.FirstOrDefault(x => x.Id == id);
            db.Students.Remove(res);
            db.SaveChanges();
        }

        [HttpPut]
        [Route("UpdateData")]
        public void UpdateData(Student std)
        {
            var res = db.Students.FirstOrDefault(x => x.Id == std.Id);
            res.Name = std.Name;
            res.Age = std.Age;
            res.City = std.City;
            res.CId = std.CId;
            res.Standard = std.Standard;
            
            db.SaveChanges();

        }

    }
}
