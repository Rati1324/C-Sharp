using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Train
{
    public class Train
    {

        public static int Passengers(int NumOfCoach, int PersonPerCoach)
        {

            if (NumOfCoach <= 0 || PersonPerCoach <= 0) throw new Exception("No negative numbers allowed");
            return NumOfCoach * PersonPerCoach;
        }

        public static float Passengers(float EnergyPerKm, float Distance)
        {
            if (EnergyPerKm <= 0 || Distance <= 0) throw new Exception("No negative numbers allowed");
            return EnergyPerKm * Distance;
        }

       
    }
}
