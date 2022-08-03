using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReferenceAndOut
{
    class tryref
    {
        //pass by refernce using ref keyword
        public void mul(ref int i,ref int j)
        {
            j = i * j;
            Console.WriteLine("the valus of k {0} ", j);
        }

        //pass by value
        public void add(int x,int y)
        {
            int k = x + y;
            Console.WriteLine("the value of k is {0}  ", k);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            tryref tf = new tryref();
            int i = 5;
            int j = 10;
            Console.WriteLine("the value of i and j before the call : " + i + "," + j);
            tf.mul(ref i, ref j);
            tf.add(i, j);
            Console.WriteLine("the value of i and j after the call : " + i + "," + j);

            int m;

            //
            string text = GetNamebyOut(out m);
            Console.WriteLine("current value of integer m " + m.ToString());
            Console.ReadLine();
           
        }

        //pass by reference //OUT

        public static string GetNamebyOut(out int d)
        {
            d = 50;// Madatory intialisation if argument is passed by out and it return multiple values
            string returnText = d.ToString();
            return returnText;
        }
    }
}
