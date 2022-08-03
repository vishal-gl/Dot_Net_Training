using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_on_EVent_Delagate
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Your Name :- ");
            string s = Console.ReadLine();
            Display d = new Display();
            d.message += new Display.FireAlarm(EventMesage);
            d.show(s);
            Console.ReadLine();
        }

        static void EventMesage()
        {
            Console.WriteLine("Event is Executed");
            Console.WriteLine("You are ban from this organisation");
            Console.WriteLine("Sends an email to Adminstartion");
        }

        public class Display
        {
            //public delegate void FireAlarm;
            public delegate void FireAlarm();
            
            public event FireAlarm message;
            public void show(string s)
            {
                if ((s.ToLower() == "ram") || (s.ToLower()=="sham") ||(s.ToLower()== "naveen"))
                {
                    message();
                }
                else
                {
                    Console.WriteLine("Welcome to Organisation :- " + s);
                }
            }
        }
    }
}
