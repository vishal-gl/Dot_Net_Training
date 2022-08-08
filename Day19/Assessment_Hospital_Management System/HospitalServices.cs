using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assessment_Hospital_Management_System
{
    class HospitalServices
    {
        public HospitalServices()
        {

        }

        public void DisplayMenu()
        {
            Console.WriteLine("Enter 1: To Create Patient's Profile");
            Console.WriteLine("Enter 2: To Display Details of Patient ");
            Console.WriteLine("Enter 3: To Delete Details of Patient ");
            
            Console.WriteLine("Enter 4: To Edit Details of Patient ");

            Console.WriteLine("Press 5: EXIT");
        }
        public bool Add(ref List<Hospital> H, ref int num)
        {
            try
            {
                Console.Write("Enter Patient's Name : ");
                string s1 = Console.ReadLine();
                Console.Write("Enter Age : ");
                int n = int.Parse(Console.ReadLine());
                Console.Write("Enter your Address : ");
                string s2 = Console.ReadLine();
                Console.WriteLine("Enter Disease's Name : ");
                string s3 = Console.ReadLine();
                Console.WriteLine("Enter Doctor Incharge's Name : ");
                string s4 = Console.ReadLine();
                Console.WriteLine("Enter Alloted Room's No : ");
                string s5 = Console.ReadLine();
                Console.WriteLine("----------------------");
                H.Add(new Hospital());
                H[num]._name = s1;
                H[num]._age = n;
                H[num]._address = s2;
                H[num]._disease = s3;
                H[num]._doctorIncharge = s4;
                H[num++]._roomNo = s5;

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

            return true;


        }

        public bool Disp(ref List<Hospital> H)
        {
            Console.WriteLine("---------Result-------------");
            if (H.Count == 0)
            {
                Console.WriteLine("Database has no Records !");
            }

            foreach (Hospital ob in H)
            {
                Console.WriteLine("Name : " + ob.Gname() + " Age : " + ob.GAge() + " Address : " + ob.GAddress() + " Disease : " + ob.GDisease() + " Doctor's Incahrge : " + ob.GDoctorIncharge() + " Patient's Room No : " + ob.GRoomNo());
            }
            Console.WriteLine("----------------------");

            return true;
        }

        public bool delete(ref List<Hospital> H)
        {
            Console.WriteLine("---------Result-------------");
            if (H.Count == 0)
            {
                Console.WriteLine("Database has no Records !");
            }
            else
            {
                int i = 0, k = -1;
                Console.Write("Enter Full Name to find: ");
                string ress = Console.ReadLine();
                foreach (Hospital obj in H)
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
                    H.RemoveAt(k);
                    Console.WriteLine("Deleted Succcessfull");
                }
                else
                {
                    Console.WriteLine("Name not found");

                }

            }


            
            Console.WriteLine("------------------------");

            
            return true;
        }

        public bool updated(ref List<Hospital> H)
        {
            Console.WriteLine("---------Result-------------");
            if (H.Count == 0)
            {
                Console.WriteLine("Database has no Records !");
            }
            else
            {
                Console.Write("Enter the Name of Patient ,you want to update Information : ");
                String s = Console.ReadLine();
                int j = 0;
                int m = -1;

                foreach (Hospital obj in H)
                {
                    if (obj.Gname() == s)
                    {
                        m = j;
                        break;

                    }
                    j++;
                }
                if (m != -1)
                {
                    Console.Write("Enter 1 to Update Name\n Enter 2 to Update Age\n Enter 3 to Update Address\n Enter 4 to Update Disease\n Enter 5 to Update Doctor_Incharge\n Enter 6 to Update Patient's Room_No\nEnter Choice : ");
                    int n = int.Parse(Console.ReadLine());

                    switch (n)
                    {
                        case 1:

                            Console.Write("Enter new name to updated: ");
                            H[m]._name = Console.ReadLine();
                            Console.WriteLine("---------Updated-------------");
                            break;
                        case 2:

                            Console.Write("Enter Age to Updated: ");

                            H[m]._age = int.Parse(Console.ReadLine());
                            Console.WriteLine("---------Updated-------------");
                            break;
                        case 3:
                            Console.Write("Enter new Address to updated: ");
                            H[m]._address = Console.ReadLine();
                            Console.WriteLine("---------Updated-------------");
                            break;
                        case 4:
                            Console.Write("Enter new Disease to updated: ");
                            H[m]._disease = Console.ReadLine();
                            Console.WriteLine("---------Updated-------------");
                            break;
                        case 5:
                            Console.Write("Enter new name of Doctor_Incharge to updated: ");
                            H[m]._doctorIncharge = Console.ReadLine();
                            Console.WriteLine("---------Updated-------------");
                            break;
                        case 6:
                            Console.Write("Enter new Room_No to updated: ");
                            H[m]._roomNo = Console.ReadLine();
                            Console.WriteLine("---------Updated-------------");
                            break;
                        case 7:
                            return true;

                    }


                }
                else
                {
                    Console.WriteLine("Name not found,Pleas Enter Valid Name Which is Available in Record");

                }

            }
            
            
            
            return true;

        }
    }
}
