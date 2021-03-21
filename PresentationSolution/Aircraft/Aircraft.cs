using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aircraft
{
    public class Aircraft
    {
        private string Name;
        protected float Altitude;
        protected int Speed;
        protected int FuelPerHour;
        public string GetName()
        {
            get { return Name; }
        }
        public Aircraft(string Name, float Altitude, int Speed, int FuelPerHour)
        {
            this.Name = Name; this.Altitude = Altitude; 
            this.Speed = Speed; this.FuelPerHour = FuelPerHour;
        }

        public virtual float FuelNeeded(float Distance, float FuelPerHour, float Speed)
            => (Distance / Speed) * FuelPerHour;

        public float TimeNeeded(float Distance, float Speed)
            => Distance / Speed;
    }
}
