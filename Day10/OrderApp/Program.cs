using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderApp
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Enter the of furniture You Want : ");
            string s = Console.ReadLine();

            Chair c1 = new Chair();
            c1.getData();
            c1.showData();
            Coat c2 = new Coat();
            c2.getData();
            c2.showData();
            Console.ReadLine();
        }
    }
}
