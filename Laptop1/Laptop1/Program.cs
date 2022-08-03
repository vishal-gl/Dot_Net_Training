using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laptop1
{
    class LaptopApp
    {
        static Laptop[] laptopArray = new Laptop[0];
        static void Main(string[] args)
        {
            Boolean flag = true;
            do
            {
                DisplayMenu();
                Console.WriteLine("Please enter your Choice");
                byte choice = byte.Parse(Console.ReadLine());
                flag =SelectionOperation(choice);
            } while (flag);


        }

        static void DisplayMenu()
        {
            Console.WriteLine("press 1: to add elemts");
            Console.WriteLine("press 2: to dispaly all elemts");
            Console.WriteLine("press 3: EXIT");
        }

        static Boolean SelectionOperation(byte choice)
        {
            switch (choice)
            {
                case 1: laptopArray = DynamicArray(laptopArray);
                    laptopArray = AddElements(laptopArray);
                    return true;

                case 2: Display(laptopArray);
                    return true;

                case 3:
                    return false;

                default:
                    Console.WriteLine("Thank You for using us" + "");
                    return true;

            }


        }

        static Laptop[] DynamicArray(Laptop[] arr)
        {
            Laptop[] temp = new Laptop[arr.Length + 1];
            for (int i = 0; i < arr.Length; i++)
            {
                temp[i] = arr[i];
            }
            return temp;
        }

        static Laptop[] AddElements(Laptop[] arr)
        {
            Console.WriteLine("Please enter the elements ");
            for(int i=arr.Length - 1; i < arr.Length; i++)
            {

                arr[i] = new Laptop();
                Console.WriteLine("enter the laptop name");
                String name = Console.ReadLine();
                arr[i].SetLaptopName(name);
                Console.WriteLine("eneter the model no");
                int modelNumber = int.Parse(Console.ReadLine());
                arr[i].SetModelNumber(modelNumber);
                Console.WriteLine("enerter the amount");
                float amount = float.Parse(Console.ReadLine());
                arr[i].SetAmount(amount);
                Console.WriteLine("please enter the ram size");
                byte ram = byte.Parse(Console.ReadLine());
                arr[i].SetRam(ram);

            }
            return arr;
        }

        static void Display(Laptop[] arr)
        {
            for(int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine(arr[i].GetLaptopName() + "   " + arr[i].GetModelNumber() + "   " + arr[i].GetAmount() + "   " + arr[i].GetRam());
            }
        }

    }
}
