using System;
using System.Collections.Generic;
using System.Text;

namespace PlanesInheritance
{
    class CargoPlane:Plane
    {
        internal override void TakeOff()
        {
            Console.WriteLine("wants long run way to take off");
            
        }
        public override void Fly()
        {
            Console.WriteLine("fly with low speed");
            
        }
        public override void Land()
        {
            Console.WriteLine("to land wants long run way");
            
        }
    }
}
