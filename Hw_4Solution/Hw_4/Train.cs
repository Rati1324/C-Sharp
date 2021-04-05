using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hw_4
{
    public abstract class Train
    {
        public abstract float Calc(float Speed, float Time);
    }

    public class Child1 : Train
    {
        public override float Calc(float Speed, float Time)
            => Speed * Time;
    }

    public class Child2 : Train
    {
        public override float Calc(float Km, float FuelPerKm)
            => Km * FuelPerKm;
    }
}