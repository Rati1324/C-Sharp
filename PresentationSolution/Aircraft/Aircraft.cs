using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AircraftNspace
{
    public class Aircraft
    {
        protected string name;
        protected float altitude;
        protected int speedKm;
        protected float fuelPerHour;
        
        public int GetSpeed { get => speedKm; }
        public float GetFuel { get => fuelPerHour; }

        public Aircraft(string name, float altitude, int speedKm, float fuelPerHour)
        {
            this.name = name; 
            this.altitude = altitude; 
            this.speedKm = speedKm; 
            this.fuelPerHour = fuelPerHour;
        }

        public virtual string GetInfo()
            => $"Name: {name}\nAltitude: {altitude}\nSpeed Km/h: {speedKm}" +
            $"\nGallons per hour: {fuelPerHour}";

        public virtual float FuelNeeded(float distance, float fuelPerHour, float speedKm)
            => (distance / speedKm) * fuelPerHour;

        public float TimeNeeded(float distance, float speedKm)
            => distance / speedKm;

        public float KmToM()
            => speedKm * (float)0.62;
    }
}
