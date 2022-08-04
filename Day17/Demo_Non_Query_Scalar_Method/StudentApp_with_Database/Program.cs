using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace StudentApp_with_Database
{
    class Program
    {
        static List<Student> student = new List<Student>();
        static int num=0;
        

        
        static void Main(string[] args)
        {
            bool flag = true;
            StudentServices S = new StudentServices();

            
            while (flag)
            {

                S.DisplayMenu();

                try
                {

                    int n = int.Parse(Console.ReadLine());
                    if (n > 5)
                    {
                        throw new MyException();
                    }
                    switch (n)
                    {
                        case 1:
                            flag = S.Add(ref student,ref num);
                            break;
                        case 2:
                            flag = S.disp();
                            break;
                        case 3:
                            flag = S.delete();
                            break;
                        
                        case 4:
                            flag = S.updated();
                            break;
                        case 5:
                            flag = false;
                            break;
                        default:

                            Console.WriteLine("Thanks for using Us");
                            break;
                    }
                }
                catch (MyException e)
                {
                    e.CustomEx();
                    Console.WriteLine();
                }
                catch (FormatException)
                {

                    Console.WriteLine("Please! Enter a VALID DATA TYPE");
                    Console.WriteLine();
                }



            }
        }
        
    }
}
