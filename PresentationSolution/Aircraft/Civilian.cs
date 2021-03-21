using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aircraft
{
    public class Civilian : Aircraft
    {
        public Civilian(string Name, string Location, float Altitude, int Speed)
            : base(Name, Location, Altitude, Speed){ }


    }
}
