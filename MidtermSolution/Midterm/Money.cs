using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Midterm
{
    public class Money : Pair, IComparable
    {
        public Money(int gel, int coin) : base(gel, coin) { }
       
        public int CompareTo(object obj)
        {
            Money m = (Money)obj;
            if ((this.gel * 100 + this.coin) > (m.gel * 100 + m.coin))
                return 1;
            else if ((this.gel * 100 + this.coin) == (m.gel * 100 + m.coin))
                return 0;
            return -1;
        }

        public static bool operator >(Money m1, Money m2)
            => ((m1.gel * 100 + m1.coin) > (m1.gel * 100 + m2.coin));

        public static bool operator <(Money m1, Money m2)
            => ((m1.gel * 100 + m1.coin) < (m1.gel * 100 + m2.coin));

        public static Money operator ++(Money m1)
        {
            m1.gel = m1.gel++;
            return m1;
        }

        public static Money operator --(Money m1)
        {
            m1.gel = m1.gel--;
            return m1;
        }

        public override float[] Addition(Pair x)
        {
            float[] res = new float[2];
            res[0] = this.GetGel + x.GetGel;
            res[1] = this.GetCoin + x.GetCoin;
            return res;
        }

        public override float[] Subtraction(Pair x)
        {
            float[] res = new float[1];
            float coins = this.coin;
            if (this.coin + x.GetCoin > 99) coins = (this.coin + x.GetCoin) / 100;
            res[0] = (float)this.gel - coins;
            return res;
        }
        public override string ToString()
            => $"{gel} ლარი\n{coin} თეთრი";

    }
}
