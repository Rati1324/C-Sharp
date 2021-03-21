using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeometryInheritance
{
    public class Perimeter: Rectangle
    {
        public Perimeter(float A, float B): base(A, B){}
        public float CalcPerimeter()
            => (A + B) * 2;
    }
}
