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

        

        [HttpPost]
        [Route("LoginData/username/password")]
        public Register logindata(string username,string password)
        {
            var res = db.Registers.FirstOrDefault(x => x.UserName == username && x.Password==password);
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
