using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            string s, revs = "";
            Console.WriteLine("Entr string or number");
            s = Console.ReadLine();
            for (int i = s.Length - 1; i >= 0; i--)
            {
                revs += s[i];

            }
            if (revs == s)
            {
                Console.WriteLine("input is Pallindrom");
            }
            else
            {
                Console.WriteLine("input is not pallindrome");
            }
        }



    }





}
