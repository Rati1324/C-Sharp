using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geometry
{
    public class Area
    {
        protected float A;
        protected float B;
        public Area(float A, float B)
        {
            this.A = A;
            this.B = B;
        }

        public Area(float A)
        {
            this.A = A;
            this.B = A;
        }

        public float CalcArea()
            => A * B;
    }
}
