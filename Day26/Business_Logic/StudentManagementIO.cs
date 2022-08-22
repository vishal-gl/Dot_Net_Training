using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAcessLayer;

namespace Business_Logic
{
    public class StudentManagementIO
    {
        StudentService studentservice = new StudentService();
        public void AddStudent(String Id, String Name, int Age, int Standard, String city, String cid)
        {




            studentservice.AddStudent(Id, Name, Age, Standard, city, cid);

            Console.WriteLine();


        }
        public void DeleteStudent(String Id)
        {
            studentservice.DeleteStudent(Id);
            Console.WriteLine();
        }
    }
}
