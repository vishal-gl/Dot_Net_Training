using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentApp_Collection
{
    class Program
    {

        static int num = 0;

        static List<Student> student = new List<Student>();
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
                    if (n > 6)
                    {
                        throw new MyException();
                    }
                    switch (n)
                    {
                        case 1: 
                            flag = S.Add(ref student, ref num); 
                            break;
                        case 2: 
                            flag = S.disp(ref student);
                            break;
                        case 3: 
                            flag = S.delete(ref student);
                            break;
                        case 4: 
                            flag = S.findV(ref student); 
                            break;
                        case 5: 
                            flag = S.updated(ref student); 
                            break;
                        case 6:
                            flag = false;
                            break;
                        default: 
                            
                            Console.WriteLine("Thanks for using Us");
                            break;
                    }
                }
                catch(MyException e)
                {
                    e.CustomEx();
                    Console.WriteLine();
                }
                catch(FormatException)
                {

                    Console.WriteLine("Please! Enter a VALID DATA TYPE");
                    Console.WriteLine();
                }

               


            }

        }


        
    }
}
