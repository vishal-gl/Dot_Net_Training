using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Register_Api_1.Controllers
{
    public class RegisterController : ApiController
    {
        RegistrationEntities db = new RegistrationEntities();

        [HttpGet]
        [Route("DisplayData")]
        public List<Register> GetData()
        {
            return db.Registers.ToList();
        }

        [HttpPost]
        [Route("InsertData")]
        public void InsertData(Register r)
        {
            db.Registers.Add(r);
            db.SaveChanges();

        }
        [HttpGet]
        [Route("SelectData/{id}")]
        public Register SelectData(int id)
        {
            var res = db.Registers.FirstOrDefault(x => x.Id == id);
            return res;
        }



        [HttpPut]
        [Route("LoginData")]
        public Register logindata(Register r)
        {
            var res = db.Registers.FirstOrDefault(x => x.UserName == r.UserName && x.Password==r.Password);
            if (res == null)
            {
                return null;
            }
            else
            {
                return res;
            }
            

           

        }
        
        
    }
}
