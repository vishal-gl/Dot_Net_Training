using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace DataAcessLayer
{
    public class StudentService
    {
        Sql_Connection std = new Sql_Connection();
        public void AddStudent(string Id, string Name, int Age, int standard, string city, string cid)
        {
            if (std.Insertdata(Id, Name, Age, standard, city, cid))
            {
                Console.WriteLine("Student Details Added Successfully!");
                Console.WriteLine();
            }
            else
            {
                Console.WriteLine("Failed To Add Student Details");
                Console.WriteLine();
            }
        }
        public void DeleteStudent(string Id)
        {
            if (std.DeleteData(Id))
            {
                Console.WriteLine("Student Record Successfully Deleted");


            }
            else
            {
                Console.WriteLine("Student Record Is Not DELETED");
            }
        }
    }
}
