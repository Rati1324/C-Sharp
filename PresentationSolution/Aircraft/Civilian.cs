using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AircraftNspace
{
    public class Civilian : Aircraft
    {
        protected int maxPassengers;
        
        public Civilian(int maxPassengers, string name, float altitude, int speedKm, float fuelPerHour)
            : base(name, altitude, speedKm, fuelPerHour)
        {
            this.maxPassengers = maxPassengers;
        }

        public int GetPassengers { get => maxPassengers; }

        public override string GetInfo()
            => $"{base.GetInfo()}\nMax Number Of Passengers: {maxPassengers}\n";

        public override float FuelNeeded(float Distance, float FuelPerHour, float speedKm)
        {
            return base.FuelNeeded(Distance, FuelPerHour, speedKm) + (maxPassengers * 5);
        }
    }
}
