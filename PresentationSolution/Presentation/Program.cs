using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GeometryInheritance;
using Aircraft;

namespace Presentation
{
    class Program
    {
        static void Main(string[] args)
        {
            Civilian Plane = new Civilian("B-52 Stratofortress", "London", 19, 2230) { };
            Console.WriteLine(Plane.FuelNeeded(200, 2, 1000));
            Console.WriteLine(Plane.TimeNeeded(100, 50));
        }
    }
}
