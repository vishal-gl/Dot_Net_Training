using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_on_Custom_Handling
{
    class BankAccountServices
    {
        public void DisplayMenu()
        {
            Console.WriteLine("Enter 1: To create Account");
            Console.WriteLine("Enter 2: To Display Details of Account ");
            Console.WriteLine("Enter 3: To Withdraw Money from Account ");


            Console.WriteLine("Press 4: EXIT");
        }
        public bool Add(ref List<BankAccount> B, ref int num)
        {

            Console.Write("Enter Your Account Number: ");
            string A = Console.ReadLine();
            Console.Write("Enter Your Name : ");
            string N = Console.ReadLine();
            Console.Write("Enter the Balance you want to Deposite: ");
            double b = Convert.ToDouble(Console.ReadLine());
            
            Console.WriteLine("----------------------");
            B.Add(new BankAccount());
            B[num]._accountNumber = A;
            B[num]._name = N;
            B[num++]._balance= b;
            
            return true;


        }
        public bool disp(ref List<BankAccount> B)
        {
            Console.WriteLine("---------Information-------------");

            foreach (BankAccount ob in B)
            {
                Console.WriteLine("AccountNumber : " + ob.GAccountNumber() + " Name : " + ob.GName() + " Your Balance : " + ob.GBalance());
            }
            Console.WriteLine("----------------------");

            return true;
        }

        public bool withdraw(ref List<BankAccount> B)
        {
            Console.WriteLine("Enter Your Account Number : ");
            string a = Console.ReadLine();

            Console.WriteLine("Enter the Amount you want to Withdraw !!!");
            double d = Convert.ToDouble(Console.ReadLine());
        
            try
            {
                
                foreach(BankAccount obj in B)
                {
                    if (obj.GAccountNumber() == a)
                    {
                        if (obj.GBalance() < 500)
                            throw new CustomException();
                        else
                        {
                            obj._balance = obj._balance - d;
                            Console.WriteLine("Your Transaction is Successful");
                        }

                    }
                }
                   
            }
            catch (CustomException e)
            {
                e.CheckBankCustomEx();
                
            }
            

            
            return true;
        }
    }
}
