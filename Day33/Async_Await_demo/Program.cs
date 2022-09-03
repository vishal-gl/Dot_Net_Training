using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
namespace Async_Await_demo
{
    class Program
    {
        public async static void Method()
        {
            await Task.Run(new Action(longTask));//this waits fro 20 seconds
            Console.WriteLine("NewThread");
            Console.ReadLine();
        }
        public static void longTask()
        {
            Thread.Sleep(10000);
            Console.WriteLine("Second thread");
        }
        static void Main(string[] args)
        {
            Method();
            Console.WriteLine("Main Thread");
            Console.ReadLine();

        }
    }
}
