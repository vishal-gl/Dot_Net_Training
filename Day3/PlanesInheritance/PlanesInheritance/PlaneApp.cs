using System;

namespace PlanesInheritance
{
    class PlaneApp
    {
        static void Main(string[] args)
        {
            CargoPlane cp = new CargoPlane();
            FighterPalne fp = new FighterPalne();
            Airport ap1 = new Airport();
            //Airport ap2 = new Airport();
            ap1.AcceptPlane(cp);
            ap1.AcceptPlane(fp);
            Plane p = new Plane();
            p.Fly();
            p.TakeOff();
            p.Land();
            Console.ReadLine();
        }
    }
}
