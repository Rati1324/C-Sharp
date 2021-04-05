using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hw_4
{

    public abstract class Figure
    {
        public abstract float Perimeter(float a, float b, float c, float d);
    }

    public class Rectangle: Figure
    {
        public override float Perimeter(float a, float b, float c, float d)
            => a + b + c + d;
    }

    public class Triangle: Figure
    {
        public override float Perimeter(float a, float b, float c, float d = 0)
            => a + b + c;
    }

}