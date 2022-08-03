using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectReferencing
{
    class Example
    {
        int a;
        int b;

        public Example(int x,int y)
        {
            a = x;
            b = y;
        }
        public void display()
        {
            Console.WriteLine("{0} {1}", a, b);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Example e1 = new Example(10, 20);
            e1.display();
            Example e2 = new Example(10, 20);
            e2.display();
            Example e3 = e2;
            //the value of objects e1 and e2 are the same
            //But their refernce are different ,class is refernce type,
            //the comparision of objects are refernce type
            if (e1.Equals(e2))
                Console.WriteLine("Equal");
            else
                Console.WriteLine("Not Equal");
            //In case of e2 and e3 ,it refers to the same object
            //It will show Equal, it is similar as pointer concept in C/C++
            if (e2.Equals(e3))
                Console.WriteLine("Equal");
            else
                Console.WriteLine("Not Equal");
            Console.ReadLine();
               

        }
    }
}
