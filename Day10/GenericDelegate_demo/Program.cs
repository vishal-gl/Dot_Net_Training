using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericDelegate_demo
{
    class MyClass
    {
        public static bool IsDate(string date)
        {
            DateTime dt;
            return DateTime.TryParse(date, out dt);

        }
        public static int multi(int a,int b)
        {
            return a + b;
        }
        public static void sum(int num1,int num2)
        {
            int sum = num1 + num2;
            Console.WriteLine(sum);
        }
        public static void add(string fname,string lname)
        {
            string fullname = fname + " " + lname;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            //Action delegate
            Action<int, int> a = new Action<int, int>(MyClass.sum);
            a(15, 16);
            Action<string, string> b = new Action<string, string>(MyClass.
                add);
            b("shradha", "banglore");


            //Func delegate
            Func<int, int, int> ds = new Func<int, int, int>(MyClass.multi);
            Console.WriteLine(ds(25, 65));

            //Predicate Delegate

            Predicate<string> p = new Predicate<string>(MyClass.IsDate);
            if (p("10-05-2022"))
            {
                Console.WriteLine("valid");

            }
            else
            {
                Console.WriteLine("invalid");
            }
            Console.ReadKey();

        }
    }
}
