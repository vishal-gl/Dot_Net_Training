using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IQueryable_Linq_Demo
{
    public class Student
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Gender { get; set; }
    }
    class Program
    {
        static void Main(string[] args)
        {
            List<Student> studentList = new List<Student>()
            {
                new Student(){ID=1,Name="Anmol",Gender="Male"} ,
                new Student(){ID=2,Name="Anusha",Gender="Female"} ,
                new Student(){ID=3,Name="Rishabh",Gender="Male"} ,
                new Student(){ID=4,Name="Ankit",Gender="Male"} ,
                new Student(){ID=5,Name="Ayushya",Gender="FeMmle"}
            };
            //Linq Query to Fetch All Students with Gender Male
            IQueryable<Student> MethodSyntax = studentList.AsQueryable().Where(std => std.Gender == "Male");

            //Iterate through the collection
            foreach(var student in MethodSyntax)
            {
                Console.WriteLine($"ID : {student.ID} Name : {student.Name}");
            }
            Console.ReadLine();
        }
    }
}
