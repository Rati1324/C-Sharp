using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AircraftNspace
{
    public class Flight
    {
        protected string location;
        protected string destination;
        protected string airline;
        protected string flightNumber;
        protected int distance;
        protected Aircraft plane;

        public Aircraft Plane
        {
            get => plane;
        }
        public string Airline { get => airline; set { airline = value; } }
        public string FlightNumber { get => flightNumber; set { flightNumber = value; } }
        public int Distance { get => distance; set { distance = value; } }
        public Flight(string location, string destination, Civilian plane)
        {
            Console.WriteLine("Civilian!");
            this.location = location;
            this.destination = destination;
            this.plane = plane;
        }
<<<<<<< HEAD
=======

        public Flight(string location, string destination, Fighter plane)
        {
            Console.WriteLine("Fighter!");
          
        }

>>>>>>> test
        public float GetTime()
            => plane.TimeNeeded(Distance, plane.GetSpeed);

        public float GetFuel()
            => plane.FuelNeeded(Distance, plane.GetFuel, plane.GetSpeed);

        public override string ToString()
        {
            return $"Flight information\nOrigin Location: {location}\nFlight Destination: {destination}" +
                $"\nAirlne: {Airline}\nFlightNumber{FlightNumber}\n";
        }

    }
}

