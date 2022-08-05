using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_on_Custom_Handling
{
    class Program
    {
        static int num = 0;

        static List<BankAccount> Bank = new List<BankAccount>();
        static void Main(string[] args)
        {
            BankAccountServices B = new BankAccountServices();
            Console.WriteLine("Hi, Welcome to Our Bank !!!");
            bool flag = true;
            
            while (flag)
            {

                B.DisplayMenu();

                try
                {

                    int n = int.Parse(Console.ReadLine());
                    
                    switch (n)
                    {
                        case 1:
                            flag = B.Add(ref Bank, ref num);
                            break;
                        case 2:
                            flag = B.disp(ref Bank);
                            break;
                        case 3:
                            flag = B.withdraw(ref Bank);
                            break;
                        
                        case 4:
                            flag = false;
                            break;
                        default:

                            Console.WriteLine("Thanks for using Us");
                            break;
                    }
                }
                catch (CustomException e)
                {
                    e.CheckBankCustomEx();
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
