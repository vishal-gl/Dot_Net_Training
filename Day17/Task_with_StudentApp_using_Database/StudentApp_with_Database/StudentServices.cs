using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentApp_with_Database
{
    class StudentServices
    {
        public void DisplayMenu()
        {
            Console.WriteLine("Enter 1: To Create Student Profile");
            Console.WriteLine("Enter 2: To Display Details of Students ");
            Console.WriteLine("Enter 3: To Delete Details of Students ");
            
            Console.WriteLine("Enter 4: To Update Details of Students ");

            Console.WriteLine("Press 5: EXIT");
        }
        public bool Add(ref List<Student> st,ref int num)
        {

            Console.Write("Enter id: ");
            int n = int.Parse(Console.ReadLine());
            Console.Write("Enter name : ");
            var s = Console.ReadLine();
            Console.Write("Enter Standard: ");
            var s2 = Console.ReadLine();
            Console.WriteLine("Enter your Address :");
            var s3 = Console.ReadLine();
            Console.WriteLine("----------------------");
            IDatabase scd = new IDatabase();
            scd.Insertdata(n,s,s2,s3);
            st.Add(new Student());
            st[num]._id = n;
            st[num]._name = s;
            st[num]._standard = s2;
            st[num++]._address = s3;
            return true;


        }

        public bool disp()
        {
            Console.WriteLine("---------Result-------------");

            IDatabase scd = new IDatabase();
            scd.ReadData();
            Console.WriteLine("----------------------");

            return true;
        }
        public bool delete()
        {
        
            Console.Write("Eneter Id to delete record of student : ");
            IDatabase scd = new IDatabase();

            try
            {
                int n = int.Parse(Console.ReadLine());
                
                scd.DeleteData(n);
                Console.WriteLine();
                Console.WriteLine("Deleted Successfully");
                Console.WriteLine();

            }
            catch (MyException e)
            {
                e.CustomEx();
                
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }
            
            return true;
        }

        public bool updated()
        {
            Console.Write("Enter 1 to Update Id\nEnter 2 to Name\nEnter 3 to update Standard\nEnter 4 to update Address\nEnter Your Choice : ");
            int n = int.Parse(Console.ReadLine());
            try
            {
                if (n>4)
                {
                    throw new MyException();
                }
            }
            catch(MyException e)
            {
                e.CustomEx();
            }

            
            IDatabase scd = new IDatabase();
            Console.WriteLine("Enter Student Id whose you want to Update Id : ");
            int res = Convert.ToInt32(Console.ReadLine());
            switch (n)
            {
                case 1:
                    Console.WriteLine("Enter the new Id : ");
                    string m = Console.ReadLine();
                    scd.UpdateData(n, res, m);
                    Console.WriteLine("-------------------------");
                    break;
                case 2:
                    Console.Write("Enter the New Name  : ");
                    string m1 = Console.ReadLine();
                    scd.UpdateData(n, res, m1);
                    break;
                case 3:
                    Console.Write("Enter the New Standard  : ");
                    string m2 = Console.ReadLine();
                    scd.UpdateData(n, res, m2);
                    break;
                case 4:
                    Console.Write("Enter the New Address  : ");
                    string m3 = Console.ReadLine();
                    scd.UpdateData(n, res, m3);
                    break;
                    





            }
            Console.WriteLine();
            Console.WriteLine("Updated Successfully");
            Console.WriteLine();

            return true;

        }
    }
}
