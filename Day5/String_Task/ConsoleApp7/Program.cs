using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp7
{
    class Program
    {
        static void Main(string[] args)
        {
            Program p = new Program();
            //p.Sample();

            //p.StringLength();

            //p.Join();

            //p.Comparision();

            //p.Escape();

            //p.Contain();

            //p.Clone();

            //p.Endswith_startswith();

            //p.FindIndex();

            //p.Reverse();

            //p.lower_upper();
            float a = 10.553f;
            long b = 12L;
            int c;
            c = Convert.ToInt32(a + b);
            Console.WriteLine(c);
            Console.ReadLine();

        }

        #region Creat
        private void Sample()
        {
            string str1 = "Vishal";
            string str2 = "GlobalLogic";

            // print string
            Console.WriteLine(str1);
            Console.WriteLine(str2);

            Console.ReadLine();

        }
        #endregion

        #region StringLength

        private void StringLength()
        {
            string str3 = "GlobalLogic";
            string str4 = "Global Logic";

            // length of string
            int len1 = str3.Length;
            int len2 = str4.Length;

            Console.WriteLine("Length of string " + str3 + " is :"+len1);
            Console.WriteLine("Length of string " + str4 + " is :" + len2);
            Console.ReadLine();


        }

        #endregion

        #region Join Of two strings
        
        private void Join()
        {
            string str1 = "Vishal";
            string str2 = " Rathore";
            Console.WriteLine("First String/ First name is :" + str1);
            Console.WriteLine("Second String/ Second name is :" + str2);
            //Concatening two strings
            //Method1
            string fullname = string.Concat(str1, str2);
            //Method 2
            string fullname2 = str1+str2;
            Console.WriteLine("Joined String/ Full name is :" + fullname);
            Console.WriteLine("Joined String/ Full name is :" + fullname2);
            Console.ReadLine();
        }

        #endregion

        #region Comparision Of two strings

        private void Comparision()
        {
            string str1 = "Vishal";
            string str2 = "Vishaa";
            string str3 = "Vishal";
            Console.WriteLine("First String is :" + str1);
            Console.WriteLine("Second Stringis :" + str2);
            Console.WriteLine("Third String is :" + str3);
            //Comparision two strings
            Boolean result1 = str1.Equals(str2);
            Console.WriteLine("String "+str1+ " and " +str2+" are equal or not : " + result1);
            //Example 2
            Boolean result2 = str1.Equals(str3);
            //Console.WriteLine("string str1 and str3 are equal or not : " + result2);
            Console.WriteLine("String " + str1 + " and " + str3 + " are equal or not : " + result2);

            Console.ReadLine();
        }

        #endregion

        #region Escape Concept


        private void Escape()
        {
            //string str1 = "Global Logic is "Reputated" Company";
            //this give an error in double quoted 
            string str2 = "Global Logic is \"Reputated\" Company.";
            //Console.WriteLine("First String is :" + str1);
            Console.WriteLine("String with double quotated"+str2);
            
            Console.ReadLine();
        }

        #endregion

        #region check whether string contain substring

        private void Contain()
        {
            string str1 = "Vishal";
            string str2 = "ish";
            Console.WriteLine("First Stringis :" + str1);
            Console.WriteLine("Second String is :" + str2);
            //Check wheteher it contain substring or not
            //Method1
            
            bool result1 = str1.Contains(str2);
            Console.WriteLine("String contain "+str2+" or not in "+str1+" is :"+result1);
            
            Console.ReadLine();
        }

        #endregion

        #region Clone

        private void Clone()
        {
            string str1 = "Vishal";
            string str2;
            Console.WriteLine("First Stringis :" + str1);
            //clone of str1 in str2
            str2 = (string)str1.Clone();
            //print clone string
            Console.WriteLine("Second String is :" + str2);
            

         
            Console.ReadLine();
        }

        #endregion

        #region Endswith 

        private void Endswith_startswith()
        {
            string str1 = "Gorgeous";
            string str2="ous";
            string str3 = "Gor";
            string str4 = "gor";
            Console.WriteLine("First Stringis :" + str1);
            Console.WriteLine("End String is :" + str2);
            Console.WriteLine("Start String is :" + str3);
            Console.WriteLine("Start String is :" + str4);
            //check whether str1 is end with str2 or not
            bool result1 = str1.EndsWith(str2);
            bool result2 = str1.EndsWith(str3);
            bool result3 = str1.StartsWith(str3);
            bool result4 = str1.StartsWith(str4);
            //print result
            Console.WriteLine("String "+str1+" ends with given string "+str2+" is :"+ result1);
            Console.WriteLine("String " + str1 + " ends with given string " + str3 + " is :" + result2);
            Console.WriteLine("String " + str1 + " starts with given string " + str3 + " is :" + result3);
            Console.WriteLine("String " + str1 + " starts with given string " + str4 + " is :" + result4);



            Console.ReadLine();
        }

        #endregion

        #region Find Index of character

        private void FindIndex()
        {
            string str1 = "Gorgeous";
            
            
            Console.WriteLine("String is :" + str1);
            
            //check whether index of character
            int result1 = str1.IndexOf('o');
            int  result2 = str1.IndexOf('a');
            //print result
            Console.WriteLine("In String " + str1 + " the index of 'o' is :" + result1);
            //print the index of repeated character when its first come
            Console.WriteLine("In String " + str1 + " the index of 'a' is :" + result2);
            



            Console.ReadLine();
        }

        #endregion

        #region Reverse Of String

        private void Reverse()
        {
            string str1 = "Gorgeous";


            Console.WriteLine("String is :" + str1);

            //Reverse
            string result1 = str1.Reverse().ToString();
            //result
            Console.WriteLine("Reverse of String " + str1 + " is the :" + result1);

            //Double Reverse
            string result2 = result1.Reverse().ToString();
            //print result
            Console.WriteLine("Double Reverse of String " + str1 + " is the :" + result2);

            




            Console.ReadLine();
        }

        #endregion

        #region convert to lowercase and Uppercase

        private void lower_upper()
        {
            string str1 = "GorgEouS";


            Console.WriteLine("String is :" + str1);

            //Lowercase
            string result1 = str1.ToLower();
            //result
            Console.WriteLine("Lowercase of String " + str1 + " is the :" + result1);

            //Uppercase
            string result2 = str1.ToUpper();
            //print result
            Console.WriteLine("Uppercase of String " + str1 + " is the :" + result2);






            Console.ReadLine();
        }

        #endregion



    }


}
