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



        [HttpGet]
        [Route("LoginData/{UserName}/{Password}")]
        public int logindata(string UserName,string Password)
        {
            var res = db.Registers.FirstOrDefault(x => x.UserName == UserName && x.Password==Password);
            if (res !=null)
            {
                return 1;
            }
            else
            {
                return 0;
            }
            

           

        }
        
        
    }
}
