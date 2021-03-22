using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace AircraftNspace
{
    public class Fighter : Aircraft
    {
        protected internal bool TwoSeats;
        protected internal int NumOfMissles;
        public Fighter(string Name, float Altitude, int speedKm, float FuelPerHour, bool TwoSeats, int NumOfMissles)
            : base(Name, Altitude, speedKm, FuelPerHour)
        {
            this.TwoSeats = TwoSeats;
            this.NumOfMissles = NumOfMissles;
        }

        public override string GetInfo()
            => base.GetInfo() + $"\nTwo Seats: {TwoSeats}\nNumber Of Missles: {NumOfMissles}\n";

        public float GetFuelPerHour()
            => fuelPerHour;
        public float GetFuelPerHour(float Num)
            => fuelPerHour * Num;

    }
}
