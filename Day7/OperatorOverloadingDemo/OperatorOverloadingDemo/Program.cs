using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OperatorOverloadingDemo
{
    class Complex
    {
         int x;
         int y;
        //public Complex()
        //{
            //Console.WriteLine("This is default constructor");

        //}
        public Complex(int i,int j)
        {
            this.x = i;
            this.y = j;
        }
        public void display()
        {
            Console.WriteLine("Complex no is : " + x + "+ " + y + "i");
        }
        public static Complex operator +(Complex c1,Complex c2)
        {
            Complex c3=new Complex(0,0);
            c3.x=c1.x+c2.x;
            c3.y=c1.y+c2.y;
            return c3;



        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Complex c1 = new Complex(5,6);
            c1.display();
            Complex c2 = new Complex(7, 8);
            c2.display();
            Complex c3 = new Complex(0,0);
            c3 = c1 + c2;
            c3.display();
            Console.ReadKey();
        }
    }
}
