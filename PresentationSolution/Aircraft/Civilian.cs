using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aircraft
{
    public class Civilian : Aircraft
    {
        protected int MaxPassengers;
        public Civilian(int MaxPassengers, string Name, float Altitude, int Speed, int FuelPerHour)
            : base(Name, Altitude, Speed, FuelPerHour)
        {
            this.MaxPassengers = MaxPassengers;
        }

        public override float FuelNeeded(float Distance, float FuelPerHour, float Speed)
        {
            return (Distance / Speed) * FuelPerHour + (MaxPassengers * 5);
        }

        public void test()
        {
            Console.WriteLine(GetName());
        }
    }
}
