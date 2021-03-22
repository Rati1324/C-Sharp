using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cars
{
    public class Car
    {
        public static int CalcDis(int Capacity, int Distance)
            => Distance * Capacity;

        public static float CalcDis(float Speed, float Time)
            => Speed * Time;
    }
}
