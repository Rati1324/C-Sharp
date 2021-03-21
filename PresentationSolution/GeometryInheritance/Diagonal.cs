using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeometryInheritance
{
    public class Diagonal : Rectangle
    {
        public Diagonal(float A, float B): base(A, B){}

        public float CalcDiagonal()
            => (float)Math.Sqrt((A * A) + (B * B));
    }
    
}
