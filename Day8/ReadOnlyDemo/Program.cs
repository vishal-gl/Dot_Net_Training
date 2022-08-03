using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReadOnlyDemo
{
    class user
    {
        public readonly string name = "Sharadhaha";
        public readonly string location;
        public readonly int age;
        public user()
        {
            location = "Banglore";
            age = 23;

        }
    }
    class Program
    {
       
        static void Main(string[] args)
        {
            user u = new user();

            Console.WriteLine("Name : {0}", u.name);
            Console.WriteLine("Location : {0}", u.location);
            Console.WriteLine("age : {0}", u.age);
            Console.WriteLine("\n Press Enter key to EXIT");
            Console.ReadLine();

        }
    }
}
