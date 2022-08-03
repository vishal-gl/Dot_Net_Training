using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_on_OOps_Concept
{
    public class HRManagement
    {
        public void Manage()
        {
            Console.WriteLine("Harshit Deshpande from Management Team");
            Console.WriteLine("I'm Managing your Project ");

        }
    }
    public class Employement:HRManagement
    {
        string _name;
        string _age;
        
        public Employement(string Name, string age)
        {
            this._name = Name;
            this._age = age;
            
        }


        public void ShowWork()

        {
            Console.WriteLine("Our Project is on C#");

        }
        public void work()
        {
            Console.WriteLine("I m working as Software Developer");
        }
        public string GetName()
        {
            return _name;
        }

        public string GetAge()
        {
            return _age;
        }

    }
    public class Department: HRManagement
    {
        public void Location()
        {
            string _location = "Nagpur";
            Console.WriteLine("Your location is : " + _location);
        }
        public void Setwork()
        {
            string _work="Software Developement";
            Console.WriteLine(_work);


        }
    }

    
    class Program
    {
        static void Main(string[] args)
        {
            //HRManagement h = new HRManagement();
            //h.Manage();
            //Employement e = new Employement();
            Console.WriteLine("Enter Your Name :");
            
            String name = Console.ReadLine();
            Console.WriteLine();

            Console.WriteLine("Enter the age");
            string age = Console.ReadLine();
            Employement e = new Employement(name,age);
            Console.WriteLine();

            Console.WriteLine("Your Manager Name is : ");
            e.Manage();
            Console.WriteLine();
            Console.WriteLine("Project : ");
            e.ShowWork();
            Console.WriteLine();
            Console.WriteLine("Pervious Status  : ");
            e.work();
            Console.WriteLine();
            Department d = new Department();
            //if we want to find manager from department class
            //d.Manage();
            Console.WriteLine("What is my working  location ? ");
            d.Location();
            Console.WriteLine();
            Console.WriteLine("What work would you assign ? ");
            d.Setwork();
            Console.ReadLine();
        }
    }
}
