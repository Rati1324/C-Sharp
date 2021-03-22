using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hw_3
{
    class Program
    {
        
        static void Main(string[] args)
        {
            // statikuri metodebia da gadaecemat obieqtebi
            Triangle tri = new Triangle(20, 30, 10);
            Triangle_child tri2 = new Triangle_child(30, 50, 5);
            Console.WriteLine(Triangle_child.this_peri(tri2));
            Console.WriteLine(Triangle_child.parent_peri(tri));

            Console.WriteLine(Car.CalcDis(20, 40));
            Console.WriteLine(Car.CalcDis((float)20.3, 40));
        }
    }
}
