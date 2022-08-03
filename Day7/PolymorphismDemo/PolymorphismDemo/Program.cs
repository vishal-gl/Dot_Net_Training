using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolymorphismDemo
{
    class Program
    {
        static double Area(double l,double b)
        {
            return l * b;
        }
        static double Area(double R)
        {
            const double PI = 3.14159;
            return PI * R * R;
        }
        static void Main(string[] args)
        {
            double length, width;
            double Radius;
            Console.WriteLine("Enter the sides of Reactangle :");
            Console.WriteLine("Length : ");
            length = double.Parse(Console.ReadLine());
            Console.WriteLine("Width : ");
            width = double.Parse(Console.ReadLine());
            Console.WriteLine("Area of reactangle :");
            Console.WriteLine(Area(length, width));

            Console.WriteLine("Enter the radius of Circle :");
            Radius = double.Parse(Console.ReadLine());
            Console.WriteLine("Area of Circle :");
            Console.WriteLine(Area(Radius));
            Console.ReadKey();



        }
    }
}
