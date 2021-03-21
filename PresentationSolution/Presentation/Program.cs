using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Aircraft;

namespace Presentation
{
    class Program
    {
        static void Main(string[] args)
        {
            Fighter Plane = new Fighter("name", 2000, 1000, 40, true);
            Console.WriteLine(Plane.Name);
        }
    }
}
