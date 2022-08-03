using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceDemo
{
    interface Iact
    {
        void Network();
    }
    class ABC : Interface1,Iact,ICommunication
    {
        public void add()
        {
            Console.WriteLine("I am from Interface1 Interface");
        }

        public int calc()
        {
            int result;
            result = 55;
            return result;
        }

        public void CNN()
        {
            Console.WriteLine("This is from class abc and ICommunication");
        }

        public void Network()
        {
            Console.WriteLine("This is from Iact Interface");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            ABC obj = new ABC();
            obj.add();
            Console.WriteLine(obj.calc());
            obj.CNN();
            obj.Network();
            XYZ obj1 = new XYZ();
            Console.WriteLine(obj1.calc());
            obj1.add();

            Console.ReadKey();
        }
    }
}
