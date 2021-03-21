using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeometryInheritance
{
    class Area : Rectangle
    {
        public Area(float A, float B): base (A, B){}
        public float CalcArea()
            => A * B;
    }
}
