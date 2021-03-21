using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aircraft
{
    public class Aircraft
    {
        protected string Name;
        protected string Location;
        protected float Altitude;
        protected int Speed;
        
        public Aircraft(string Name, string Location, float Altitude, int Speed)
        {
            this.Name = Name; this.Location = Location;
            this.Altitude = Altitude; this.Speed = Speed;
        }

        public float FuelNeeded(float Distance, float FuelPerHour, float Speed)
            => (Distance / Speed) * FuelPerHour;

        public float TimeNeeded(float Distance, float Speed)
            => Distance / Speed;


    }
}
