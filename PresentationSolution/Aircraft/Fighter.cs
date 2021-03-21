using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aircraft
{
    public class Fighter:Aircraft
    {
        protected bool TwoSeats;
        public Fighter(string Name, float Altitude, int Speed, int FuelPerHour, bool TwoSeats)
            : base (Name, Altitude, Speed, FuelPerHour)
        {
            this.TwoSeats = TwoSeats;
        }

        public string GetInfo()
            => $"Name: {Name}\nAltitude: {Altitude}\nSpeed: {Speed}";

        public int GetInfo(int Num)
            => FuelPerHour * Num;

    }
}
