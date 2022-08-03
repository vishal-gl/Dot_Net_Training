using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnumDemo
{
    //set of constant which are related logically , so we can use enum
    
    class Program
    {
        enum Week
        {
            Sunday,
            Monday,
            Tuesday,
            Wednesday,
            Thursday,
            Friday,
            Saturday
        }

        enum color
        {
            red = 3,
            yellow = 5,
            orange = 7,
        }
        enum dept
        {
            cs = 1,
            ec = 2,
            eee = 3
        }
        static void Main(string[] args)
        {
            int a = (int)Week.Sunday;
            int b = (int)Week.Monday;
            int x = (int)color.orange;
            int y = (int)dept.ec;
            Console.WriteLine("Week.Sunday"); // default index value
            Console.WriteLine("Sunday :{0}", a);
            Console.WriteLine("Monday :{0}", b);
            Console.WriteLine("Orange :{0}", x); // assigned value
            Console.WriteLine("EC :{0}", y);
            Console.ReadLine();
        }
    }
}
