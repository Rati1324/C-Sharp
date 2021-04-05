using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hw_4
{
    public abstract class Figure
    {
        public abstract float Perimetri(float A, float B, float C, float D);
    }

    public class Rectangle : Figure
    {
        public override float Perimetri(float A, float B, float C, float D)
            => A + B + C + D;
    }
}
