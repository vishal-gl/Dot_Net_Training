using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentAppwithInterface
{

    public class Methods : Interface1, Interface2, Interface3
    {
        public Student[] array = new Student[0];

        #region update
        public  void Update(Student[] array)

        {
            Console.WriteLine();

            Console.WriteLine("Enter 1. To Update the the Id ");
            Console.WriteLine("Enter 2. To Update the the Name ");
            Console.WriteLine("Enter 3. To Update the the Total Marks ");
            Console.WriteLine("Enter 4. To Update the the Address ");
           
            try
            {
                int n = int.Parse(Console.ReadLine());
                Console.WriteLine();

                if (n > 4)
                {
                    throw new MyException();
                }

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

                        array[0].SetName(s);
                        break;
                    case 3:
                        Console.WriteLine("Enter Your Total Marks");
                        int m = int.Parse(Console.ReadLine());

                        array[0].SetMarks(m);
                        break;
                    case 4:
                        Console.WriteLine("Enter Your Address");
                        string s1 = Console.ReadLine();

                        array[0].SetAddress(s1);
                        break;

                    default:
                        Console.WriteLine("Thank You for updating information");
                        break;



                }

            }
            catch (MyException e)
            {
                e.MyWrongException();
                Console.WriteLine();


            }
            catch(FormatException e)
            {
                Console.WriteLine(e.Message);
                Console.WriteLine();

            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                Console.WriteLine();

            }


        }

        #endregion

        #region Delete



        public void Delete1(Student[] array)

        {
            Console.WriteLine();
            //throw new NotImplementedException();
            Console.WriteLine("Enter 1. To Delete the the Id ");
            Console.WriteLine("Enter 2. To Delete the the Name ");
            Console.WriteLine("Enter 3. To Delete the the Total Marks ");
            Console.WriteLine("Enter 4. To Delete the the Address ");
            
            try
            {
                int n = int.Parse(Console.ReadLine());
                Console.WriteLine();
                if (n > 4)
                {
                    throw new MyException();
                    
                }

                switch (n)
                {
                    case 1:
                        //Console.WriteLine("Enter Your Id");
                        //int p = int.Parse(Console.ReadLine());

                        array[0].SetId(0);
                        break;
                    case 2:
                        //Console.WriteLine("Enter Your Name");
                        //string s = Console.ReadLine();

                        array[1].SetName(null);
                        break;
                    case 3:
                        //Console.WriteLine("Enter Your Total Marks");
                        //int m = int.Parse(Console.ReadLine());

                        array[2].SetMarks(0);
                        break;
                    case 4:
                        //Console.WriteLine("Enter Your Address");
                        //string s1 = Console.ReadLine();

                        array[3].SetAddress(null);
                        break;

                    default:
                        Console.WriteLine("Thank You for updating information");
                        break;
                }

            }
            catch (MyException e)
            {
                e.MyWrongException();
                Console.WriteLine();


            }

            catch (FormatException e)
            {
                Console.WriteLine(e.Message);
                Console.WriteLine();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                Console.WriteLine();

            }



        }

        #endregion

        #region CreateContact

        public Student[] createContact(Student[] arr)
        {
            Console.WriteLine();
            //throw new NotImplementedException();
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

        public Student[] DynamicArray(Student[] arr)
        {
            Student[] temp = new Student[arr.Length + 1];
            for (int i = 0; i < arr.Length; i++)
            {
                temp[i] = arr[i];
            }
            return temp;
        }

        #endregion

        #region Display


        public void Display(Student[] arr)
        {
            Console.WriteLine();
            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine(arr[i].GetName() + "   " + arr[i].GetID() + "   " + arr[i].GetMarks() + "   " + arr[i].GetAddress());
            }
            Console.WriteLine();
        }

        #endregion


    }
}
