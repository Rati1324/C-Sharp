using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hw_4
{
    public abstract class Tv
    {
        public abstract float Method(float Time, float Energy);
    }

    public class TvChild : Tv
    {
        public override float Method(float Time, float Energy)
            => Time * Energy;
    }
}
