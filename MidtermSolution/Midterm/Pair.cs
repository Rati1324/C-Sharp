using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Midterm
{
    public abstract class Pair
    {
        protected int gel;
        protected int coin;
        protected float c1;
        protected float c2;
        public float GetCoin { get => coin; }
        public float GetGel { get => gel; }

        public float GetC1 { get => c1; }
        public float GetC2 { get => c2; }
        public Pair(int gel, int coin)
        {
            this.gel = gel;
            this.coin = coin;
        }

        public Pair(float c1, float c2)
        {
            this.c1 = c1;
            this.c2 = c2;
        }

        public virtual float[] Addition(Pair x)
        {

            float[] res = new float[4];
            res[0] = this.gel + x.gel;
            res[1] = this.coin + x.coin;
            res[2] = this.c1 + x.c1;
            res[3] = this.c2 + x.c2;
            return res;
        }

        public virtual float[] Subtraction(Pair x)
        {
            float[] res = new float[4];
            res[0] = this.gel - x.gel;
            res[1] = this.c1 - this.c2 - x.c1 - x.c2;
            return res;
        }


    }
}
