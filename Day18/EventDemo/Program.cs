using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventDemo
{
    public class Button
    {
        public delegate void EventHandler();
        public event EventHandler OnClick;//event name
        //Method
        public void Click()
        {
            OnClick();
        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            Button button = new Button();
            button.OnClick += new Button.EventHandler(Button_Click);
            //button.OnClick+=new Button.EventHandler(sum);
            button.OnClick += sum;
            button.Click();//to raising a event ,i just call the method
            Console.ReadLine();

        }
        public static void Button_Click()
        {
            Console.WriteLine("Button Clicked");
            Console.ReadLine();
        }
        public static void sum()
        {
            Console.WriteLine("I Am from Sum method");
            Console.ReadLine();
        }
    }
}
