using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace StudentApp
{
    class Program
    {
        static Student[] array = new Student[0];


        static void DisplayMenu()
        {
            Console.WriteLine("Enter 1: To Create Student Profile");
            Console.WriteLine("Enter 2: To Update Details of Students ");
            Console.WriteLine("Enter 3: To Display Details of Students ");
            Console.WriteLine("Enter 4: To Delete Details of Students ");

            Console.WriteLine("press 5: EXIT");
        }

        static Student[] DynamicArray(Student[] arr)
        {
            Student[] temp = new Student[arr.Length + 1];
            for (int i = 0; i < arr.Length; i++)
            {
                temp[i] = arr[i];
            }
            return temp;
        }


        static Student[] AddDetails(Student[] arr)
        {
            Console.WriteLine("Please Enter the Student Information ");
            Console.WriteLine();
            for (int i = arr.Length - 1; i < arr.Length; i++)
            {

                arr[i] = new Student();
                Console.WriteLine("Enter the Student Full Name :");
                String name = Console.ReadLine();
                arr[i].SetName(name);
                Console.WriteLine("Enter the School Id : ");
                int id = int.Parse(Console.ReadLine());
                arr[i].SetId(id);
                Console.WriteLine("Enter the Total Marks = ");
                int marks = int.Parse(Console.ReadLine());
                arr[i].SetMarks(marks);
                Console.WriteLine("Enter the Address or City : ");
                string address = Console.ReadLine();
                arr[i].SetAddress(address);

            }
            return arr;
            //Console.WriteLine("=================================");
            //Console.ReadLine();
        }

        static void Update()
        {
            Console.WriteLine("Enter 1. To Update the the Id ");
            Console.WriteLine("Enter 2. To Update the the Name ");
            Console.WriteLine("Enter 3. To Update the the Total Marks ");
            Console.WriteLine("Enter 4. To Update the the Address ");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine();

            try
            {
                if (n> 4)
                {
                    throw new MyException();
                }

            }
            catch (MyException e)
            {
                e.MyWrongException();


            }
            //Student obj = new Student();

            //Student[] UpdatedArray;
            //UpdatedArray = array;
            //obj = array;
            switch (n)
            {
                case 1:
                    Console.WriteLine("Enter Your Id");
                    int p = int.Parse(Console.ReadLine());

                    array[0].SetId(p);
                    break;
                case 2:
                    Console.WriteLine("Enter Your Name");
                    string s = Console.ReadLine();

                    array[1].SetName(s);
                    break;
                case 3:
                    Console.WriteLine("Enter Your Total Marks");
                    int m = int.Parse(Console.ReadLine());

                    array[2].SetMarks(m);
                    break;
                case 4:
                    Console.WriteLine("Enter Your Address");
                    string s1= Console.ReadLine();

                    array[3].SetAddress(s1);
                    break;

                default:
                    Console.WriteLine("Thank You for updating information");
                    break;



            }
        }

        class MyException : ApplicationException
        {
           
            public void MyWrongException()
            {
                Console.WriteLine("Exception occured, Choice should not be above mentioned options");
                Console.WriteLine();
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

                byte choice = byte.Parse(Console.ReadLine());
                flag = Process(choice);
            } while (flag);
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
            catch(MyException e)
            {
                e.MyWrongException();

            }
            switch (choice)
            {
                case 1:
                    array = DynamicArray(array);
                    array = AddDetails(array);
                    return true;

                case 2:
                    Update();
                    //Display(array);
                    return true;

                case 3:
                    Display(array);
                    return true;

                case 4:
                    Delete(array);
                    return true;
                case 5:
                    return false;

                default:
                    Console.WriteLine("Thank You for using us" + "");
                    Console.WriteLine();
                    return true;

            }


        }
        static void Delete(Student[] array)
        {
            array = null;
            
        }

        static void Display(Student[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine(arr[i].GetName() + "   " + arr[i].GetID() + "   " + arr[i].GetMarks() + "   " + arr[i].GetAddress());
            }
            Console.WriteLine();
        }

    }
}
