using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExplicitInterfaceDemo
{
    class Program
    {
        interface IACT
        {
            void Network();
            void add();
        }
        
        interface IGlobal
        {
            void Network();
        }

        class ABC : IACT, IGlobal

        {
            public void add()
            {
                
                Console.WriteLine("This is add function of Iact");
            }

            void IACT.Network()
            {
                Console.WriteLine("This is from IACT");
                    
            }

            void IGlobal.Network()
            {
                Console.WriteLine("This is from IGlobal"); 
            }
        }

        static void Main(string[] args)
        {
            ABC obj = new ABC();
            IGlobal obj2 = new ABC();
            obj.add();
            obj2.Network();
            IACT obj1 = new ABC();
            obj1.Network();
            obj1.add();
            Console.ReadKey();

        }
    }
}
