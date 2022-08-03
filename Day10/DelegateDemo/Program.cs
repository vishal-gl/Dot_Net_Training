using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegateDemo
{
    public delegate string FirstDelegate(int x);
    //Delegate are used to reference method by datatype and parameters
    //we always declare delegate outside the class
    class Program
    {
        string name;
        static string StaticMethod(int i)
        {
            return string.Format("stattic method : {0}", i);
        }
        string InstanceMethod(int i)
        {
            return string.Format("{0} : {1}", name, i);
        }
        public void SumMethod(int i)
        {

        }
        static void Main(string[] args)
        {
            FirstDelegate d1 = new FirstDelegate(Program.StaticMethod);

            Program instance = new Program();
            instance.name = "My instance";
            FirstDelegate d2 = new FirstDelegate(instance.InstanceMethod);
            //FirstDelegate d3 = new FirstDelegate(instance.SumMethod);

            Console.WriteLine(d1(10));//static output
            Console.WriteLine(d2(5));//instance method
            Console.ReadLine();

        }
    }
}
