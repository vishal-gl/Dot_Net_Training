using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentAppwithInterface
{
    

    class Program
    {
        public static  Student[] array = new Student[0];
       


        static void DisplayMenu()
        {
            Console.WriteLine("Enter 1: To Create Student Profile");
            Console.WriteLine("Enter 2: To Update Details of Students ");
            Console.WriteLine("Enter 3: To Display Details of Students ");
            Console.WriteLine("Enter 4: To Delete Details of Students ");

            Console.WriteLine("press 5: EXIT");
        }

        static Boolean Process(byte choice)
        {
            try
            {
                if (choice > 5)
                {
                    throw new MyException();
                }

            }
            catch (MyException e)
            {
                e.MyWrongException();

            }

            Methods m1 = new Methods();
            
            switch (choice)
            {
                case 1:
                    array = m1.DynamicArray(array);
                    array = m1.createContact(array);
                    return true;

                case 2:
                    m1.Update(array);
                    //Display(array);
                    return true;

                case 3:
                    m1.Display(array);
                    return true;

                case 4:
                    m1.Delete1(array);
                    return true;
                case 5:
                    return false;

                default:
                    Console.WriteLine("Thank You for using us" + "");
                    Console.WriteLine();
                    return true;

            }


        }
        static void Main(string[] args)
        {
            Boolean flag = true;
            do
            {
                DisplayMenu();
                Console.WriteLine();
                Console.WriteLine("Please Enter Your Choice");
                
                try
                {
                    byte choice = byte.Parse(Console.ReadLine());
                    flag = Process(choice);

                }
                catch(FormatException e)
                {
                    Console.WriteLine(e.Message);
                    Console.WriteLine();
                }
                catch(Exception e)
                {
                    Console.WriteLine(e.Message);
                    Console.WriteLine();
                }
                Console.WriteLine();
                Console.WriteLine("==============================================");
                Console.WriteLine();

                //byte choice = byte.Parse(Console.ReadLine());
                //flag = Process(choice);
            } while (flag);
        }
    }
}
