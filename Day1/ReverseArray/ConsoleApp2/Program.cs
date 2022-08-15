using System;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            int[] numArray = new int[8] { 0, 1, 3, 5, 7, 8, 9, 10 };
            


            Array.Reverse(numArray);
            for (int i = 0; i < numArray.Length; i++)
            {
                Console.WriteLine(numArray[i]);


                


            }
            Console.ReadLine();
        }
    }
}
