using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geometry
{
    public class Diagonal
    {
        protected float A;
        protected float B;
        public Diagonal(float A, float B)
        {
            this.A = A; this.B = B;;
        }

        public float CalcDiagonal()
            => (float)Math.Sqrt((A * A) + (B * B));
    }
}
