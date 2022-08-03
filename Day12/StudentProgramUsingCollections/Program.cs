using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentProgramUsingCollections
{
    #region Custom Exception
    class MyException : ApplicationException
    {

        public void MyWrongException()
        {
            Console.WriteLine("Exception occured, Choice should not be above mentioned options");

            Console.WriteLine();
            Console.WriteLine("Please Select Valid Option !!! ");
            Console.WriteLine();
        }

    }

    #endregion
    class Program
    {


        static int num = 0;

        static List<Student> st = new List<Student>();

        static void DisplayMenu()
        {
            Console.WriteLine("Enter 1: To Create Student Profile");
            Console.WriteLine("Enter 2: To Display Details of Students ");
            Console.WriteLine("Enter 3: To Delete Details of Students ");
            Console.WriteLine("Enter 4: To Find Details of Students ");

            Console.WriteLine("press 5: EXIT");
        }
        static void Main(string[] args)
        {
            bool flag = true;

            while (flag)
            {
                DisplayMenu();
                

                try
                {
                    int n = int.Parse(Console.ReadLine());
                    if (n > 5)
                    {
                        throw new MyException();
                    }
                    switch (n)
                    {
                        case 1: flag = Add();
                                break;
                        case 2: flag = disp(); 
                                break;
                        case 3: flag = delete();
                                break;
                        case 4: flag = findV();
                                break;
                        case 5: flag = false;
                                break;
                        default:    
                                Console.WriteLine("Thanks for Using Us"); 
                                flag = true; 
                                break;

                    }

                }
                catch (MyException e)
                {
                    e.MyWrongException();
                    Console.WriteLine();
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }

                Console.WriteLine();
                Console.WriteLine("==============================================");
                Console.WriteLine();





            }

        }




        public static bool Add()
        {

            Console.Write("Enter id: ");
            int n = int.Parse(Console.ReadLine());
            Console.Write("Enter name : ");
            string s = Console.ReadLine();
            //Console.WriteLine("----------------------");
            st.Add(new Student());
            st[num]._id = n;
            st[num++]._name = s;
            Console.WriteLine();
            Console.WriteLine("==============================================");
            Console.WriteLine();
            return true;



        }
        public static bool disp()
        {
            Console.WriteLine("---------Result-------------");

            foreach (Student ob in st)
            {
                Console.WriteLine("Id : " + ob.Gid() + " Name : " + ob.Gname());
            }
            //Console.WriteLine("----------------------");
            Console.WriteLine();
            Console.WriteLine("==============================================");
            Console.WriteLine();

            return true;
        }


        public static bool delete()
        {
            Console.Write("Enter 1 to Id\n Enter 2 to Name\nEnter Choice : ");
            try
            {
                int n = int.Parse(Console.ReadLine());
                int i = 0, k = -1;
                if (n > 2)
                {
                    throw new MyException();
                }
                switch (n)
                {
                    
                
                    case 1:
                        Console.Write("Enter Id  to Delete : ");
                        int res = int.Parse(Console.ReadLine());
                        foreach (Student obj in st)
                        {
                            if (obj.Gid() == res)
                            {
                                k = i;
                            }
                            i++;
                        }
                        Console.WriteLine("---------Result-------------");
                        if (k != -1)
                        {
                            st.RemoveAt(k);
                            Console.WriteLine("Deleted Succcessfull");
                        }
                        else
                            Console.WriteLine("Id not found");
                        //Console.WriteLine("-------------------------");
                        Console.WriteLine();
                        Console.WriteLine("==============================================");
                        Console.WriteLine();
                        break;
                    case 2:
                        Console.Write("Enter Name to delete: ");
                        string ress = Console.ReadLine();
                        foreach (Student obj in st)
                        {
                            if (obj.Gname() == ress)
                            {
                                k = i;
                            }
                            i++;
                        }
                        Console.WriteLine("---------Result-------------");
                        if (k != -1)
                        {
                            st.RemoveAt(k);
                            Console.WriteLine("Deleted Succcessfull");

                        }
                        else
                            Console.WriteLine("Name not found");


                        //Console.WriteLine("------------------------");
                        Console.WriteLine();
                        Console.WriteLine("==============================================");
                        Console.WriteLine();
                        break;
                    case 3:
                        return true;


                }
                

            }
            catch (MyException e)
            {
                e.MyWrongException();
                Console.WriteLine();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

            return true;

        }



        public static bool findV()
        {
            Console.Write("Enter 1 to Id\nEnter 2 to Name\nEnter your Choice : ");
            try
            {
                int n = int.Parse(Console.ReadLine());
                int i = 0, k = -1;
                if (n > 3)
                {
                    throw new MyException();
                }
                switch (n)
                {
                    case 1:
                        Console.WriteLine("Enter Id  to find : ");
                        int res = int.Parse(Console.ReadLine());
                        foreach (Student obj in st)
                        {
                            if (obj.Gid() == res)
                            {
                                k = i;
                            }
                            i++;
                        }
                        Console.WriteLine("---------Result-------------");
                        Student s = new Student();
                        if (k != -1)
                        {
                            Console.WriteLine("Id Available at {0} index", k);
                        }
                        //Console.WriteLine("Name of student of given id is : " + st.ElementAt(k)); }
                        else
                            Console.WriteLine("Id not found");
                        //Console.WriteLine("-------------------------");
                        Console.WriteLine();
                        Console.WriteLine("==============================================");
                        Console.WriteLine();
                        break;
                    case 2:
                        Console.Write("Enter Name to find: ");
                        string ress = Console.ReadLine();
                        foreach (Student obj in st)
                        {
                            if (obj.Gname() == ress)
                            {
                                k = i;
                            }
                            i++;
                        }
                        Console.WriteLine("---------Result-------------");
                        if (k != -1)
                            Console.WriteLine("Name Available at {0} index", k);
                        else
                            Console.WriteLine("Name not found");
                        //Console.WriteLine("------------------------");
                        Console.WriteLine();
                        Console.WriteLine("==============================================");
                        Console.WriteLine();
                        break;
                    case 3:
                        return true;




                }

            }

            catch (MyException e)
            {
                e.MyWrongException();
                Console.WriteLine();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }



            return true;
        

        }

            

    }
}


