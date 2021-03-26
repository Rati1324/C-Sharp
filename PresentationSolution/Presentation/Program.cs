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
            
                Aircraft PlaneParent = new Aircraft("aircraft_1", 2934, 3999, 30);
            Civilian Plane = new Civilian(20, "name", 2000, 1000, 40);
            //Fighter PlaneFighter = new Fighter("name", 3033, 30, 43, true, 32);
            Flight fly = new Flight("flyyy", "asd", Plane);
            
            
        }
    }
}
