using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AircraftNspace;

namespace Presentation
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Aircraft PlaneParent = new Aircraft("aircraft_1", 2934, 3999, 30);
                Civilian Plane = new Civilian(20, "name", 2000, 1000, 40);
                Fighter PlaneFighter = new Fighter("name", 3033, 30, 43, true, 32);

                Flight fly = new Flight("London", "NY", Plane);
                Flight flyFighter = new Flight("Maine", "Moscow", PlaneFighter);
                Flight flyParent = new Flight("NY", "Moscow", PlaneParent);

                fly.Airline = "Airline_1";
                fly.Distance= 4;
                fly.FlightNumber= "A432";
                Console.WriteLine(fly.Plane.GetInfo());
                Console.WriteLine(flyFighter.Plane.GetInfo());
                Console.WriteLine(flyParent.Plane.GetInfo());
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
