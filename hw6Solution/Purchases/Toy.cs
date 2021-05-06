using System;
using System.Collections.Generic;
using System.Text;

namespace Purchases
{
    public class Toy
    {
        public static List<Toy> Toys = new List<Toy>();
        private string name;
        private decimal price;
        public string Description { get => name + " " + price; }

        public Toy(string name, decimal price)
        {
            this.name = name;
            this.price = price;
        }

        public void Buy()
        {
            Toys.Add(this);
        }


    }
}
