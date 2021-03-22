using System;
using System.Collections.Generic;
using System.Text;

namespace Hw_3
{
    // amocana 3.7.1
    public class Triangle
    {
        protected float a;
        protected float b;
        protected float c;

        public float A { get => a; }
        public float B { get => b; }
        public float C { get => c; }

        public Triangle(float a, float b, float c)
        {
            this.a = a; this.b = b; this.c = c;
        }



    }
}