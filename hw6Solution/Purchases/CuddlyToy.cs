using System;
using System.Collections.Generic;
using System.Text;

namespace Purchases
{
    public class CuddlyToy : Toy
    {
        public string Animal { get; set; }
        public CuddlyToy(string Name, decimal Price) : base(Name, Price){}


    }
}
