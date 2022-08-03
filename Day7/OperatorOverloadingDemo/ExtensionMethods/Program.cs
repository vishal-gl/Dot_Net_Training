using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtensionMethods
{
    public static class StringExtension
    {
        public static int GetWordCount(this string inputstring)
        {
            if (!string.IsNullOrEmpty(inputstring))
            {
                string[] strarray = inputstring.Split(' ');
                return strarray.Count();
            }
            else
            {
                return 0;
            }
        }
        public static int Addition(int a,int b)
        {
            return 0;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            string myWord = "Welcome to eLearning tutors by Global Logivc training";
            int wordCount = myWord.GetWordCount();

            //StringExtension.GetWordCount(myWord);
            Console.WriteLine("string is : " + myWord);
            Console.WriteLine("count is : " + wordCount);
            Console.ReadLine();


        }
    }
}
