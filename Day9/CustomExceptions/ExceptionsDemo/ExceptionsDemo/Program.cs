using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionsDemo
{
    class MyException : ApplicationException
    {
        public void MyExceptiona()
        {
            Console.WriteLine("An exception occured");
        }
        public void MyDivideException()
        {
            Console.WriteLine("Exception occured, divisor should not be zero");
        }

    }
    class Program
    {
        static void Main(string[] args)
        { 

            int d, div, res;
            div = Int32.Parse(Console.ReadLine());
            d = Int32.Parse(Console.ReadLine());
           
            try
            {
                if (div == 0)
                {
                    throw new MyException();
                }
            }
            catch (MyException e)
            {
                e.MyDivideException();
            }
            res = d / div;

            Console.WriteLine("Result:{0}", res);
        }
    }
}
