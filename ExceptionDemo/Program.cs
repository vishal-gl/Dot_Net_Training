using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionDemo
{
    class MyException : ApplicationException
    {
        public void MyExceptiona()
        {
            Console.WriteLine("An Exception Occurred");

        }
        public void MyDivideException()
        {
            Console.WriteLine("Exception occurred ,Divisor should not be zero");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            //int d, div, res;
            //div = Int32.Parse(Console.ReadLine());
            //d = Int32.Parse(Console.ReadLine());
            //(Console.ReadLine());
            try
            {
                int d, div, res;
                div = Int32.Parse(Console.ReadLine());
                d = Int32.Parse(Console.ReadLine());
                if (div == 0)
                {
                    throw new MyException();
                }
                res = d / div;
                Console.WriteLine("Result:{0}", res);

            }
            catch(InvalidOperationException e)
            {
                Console.WriteLine(e.Message);
                Console.ReadLine();
            }
            catch(FormatException e)
            {
                Console.WriteLine(e.Message);
            }

            catch(MyException e)
            {
                e.MyDivideException();

            }



            //res = d / div;
            //Console.WriteLine("Result:{0}", res);
            Console.ReadLine();
            


        }
    }
}
