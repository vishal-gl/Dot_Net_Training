using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assessment_Hospital_Management_System
{
    class Program
    {
        static int num = 0;

        static List<Hospital> patient = new List<Hospital>();
        static void Main(string[] args)
        {
            bool flag = true;
            HospitalServices H = new HospitalServices();

            while (flag)
            {
                Console.WriteLine();

                H.DisplayMenu();
                Console.WriteLine();

                try
                {

                    int n = int.Parse(Console.ReadLine());
                    if (n > 5)
                    {
                        throw new CustomException();
                    }
                    switch (n)
                    {
                        case 1:
                            flag = H.Add(ref patient, ref num);
                            break;
                        case 2:
                            flag = H.Disp(ref patient);
                            break;
                        case 3:
                            flag = H.delete(ref patient);
                            break;
                        case 4:
                            flag = H.updated(ref patient);
                            break;
                        
                        case 5:
                            flag = false;
                            break;
                        default:
                            Console.WriteLine("Thanks for using Us");
                            break;
                    }
                }
                catch (CustomException e)
                {
                    e.CustomEx();
                    Console.WriteLine();
                }
                catch (FormatException)
                {

                    Console.WriteLine("*** Please !!! Enter a VALID DATA TYPE ***");
                    Console.WriteLine();

                }

            }

        }
    }
}
