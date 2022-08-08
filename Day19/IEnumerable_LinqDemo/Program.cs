using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IEnumerable_LinqDemo
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
            //Linq Query to fetch all students with Gender Male
            IEnumerable<Student> QuerySyntax = from obj in studentList where obj.Gender == "male" select obj;

            //iterate through the collection
            foreach(var student in QuerySyntax)
            {
                Console.WriteLine($"ID :  {student.ID}  Name is :  {student.Name}  Gender is :  {student.Gender}");
                    
            }
            Console.ReadLine();
        }
    }
}
