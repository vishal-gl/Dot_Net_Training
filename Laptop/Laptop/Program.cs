using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laptop
{
    class Program
    {
        static void Main(string[] args)
        {
            Program p = new Program();
            Console.WriteLine("Available Laptops: ");
            p.name();
            
            Console.WriteLine("Enter a name to know information about it :");

            string n = Console.ReadLine();
            
            
            switch (n)
            {
                case "Hp":
                    p.Hp();
                    break;

                case "Dell":
                    p.Dell();
                    break;

                case "Lenovo":
                    p.Lenovo();
                    break;

                case null:
                    Console.WriteLine("Thank You for Using");
                    break;

           

            }

           

        }

        private void name()
        {
            Console.WriteLine("Hp");
            Console.WriteLine("Dell");
            Console.WriteLine("Lenovo");
            Console.WriteLine("Avita");
            Console.WriteLine("Asus");
            Console.WriteLine("Mi");
            Console.ReadLine();
            

        }

        private void Hp()

        {
            Console.WriteLine("Hp PaviLion I5 11th Gen 512 SSD");
            Console.WriteLine("Hp Pro Notebook G86 I5 11th Gen 512SSD with Windows 11");
            Console.WriteLine("Hp Elite Book I5 8th Gen 1TB Harddrive with Windows 11");
            Console.WriteLine("Hp Elite Book I5 8th Gen 512SSd Nividia $Gb Graphics Card with Windows 11");
            Console.ReadLine();
        }

        private void Dell()

        {
            Console.WriteLine("Dell Inspiron I5 11th Gen 512 SSD");
            Console.WriteLine("Dell Fast Pro I5 11th Gen 512SSD with Windows 11");
            Console.WriteLine("Dell Elite Book I5 8th Gen 1TB Harddrive with Windows 11");
            Console.WriteLine("Dell Elite Book I5 8th Gen 512SSd Nividia $Gb Graphics Card with Windows 11");
            Console.ReadLine();
        }

        private void Lenovo()

        {
            Console.WriteLine("Lenovo PaviLion I5 11th Gen 512 SSD");
            Console.WriteLine("Lenovo Notebook G86 I5 11th Gen 512SSD with Windows 11");
            Console.WriteLine("Lenovo Elite Book I5 8th Gen 1TB Harddrive with Windows 11");
            Console.WriteLine("Lenovo Elite Book I5 8th Gen 512SSd Nividia $Gb Graphics Card with Windows 11");
            Console.ReadLine();
        }
    }
}
