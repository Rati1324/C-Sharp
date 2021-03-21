using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geometry
{
    public class Perimeter
    {
        protected float A;
        protected float B;
        public Perimeter(float A, float B)
        {
            this.A = A; this.B = B;
        }

        public Perimeter(float A)
        {
            this.A = A; this.B = A;
        }

        public float CalcPerimeter()
            => (A + B) * 2;
    }
}
