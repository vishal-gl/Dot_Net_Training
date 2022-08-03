using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SealedClassDemo
{
    //we cant inherit the class but we can acces it from its object

    sealed class ClassDemo
    {
        public void add()
        {
            Console.WriteLine("I am from Sealed class");

        }
    }
    //we cant inherit class ClassDemo
    class B

    {

        //Console.WriteLine("Derived class);
        //ClassDemo obj1 = new ClassDemo();
        //obj1.add();

    }
    class Program
    {
        static void Main(string[] args)
        {
            ClassDemo obj = new ClassDemo();
            obj.add();
            Console.ReadLine();

        }
    }
}
