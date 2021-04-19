using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Midterm
{
    public class ComplexNumber : Pair
    {
        public ComplexNumber(float c1, float c2) : base(c1, c2) { }

        public static ComplexNumber operator --(ComplexNumber c1)
        {
            c1.gel = c1.gel--;
            return c1;
        }

        public override float[] Addition(Pair x)
        {
            float[] res = new float[2];
            res[0] = this.c1 + x.GetC1;
            res[1] = this.c2 + x.GetC2;
            return res;
        }

        public static ComplexNumber operator ++(ComplexNumber c1)
        {
            c1.gel = c1.gel--;
            return c1;
        }
        public override string ToString()
            => $"{c1} + {c2}* i";
    }
}
