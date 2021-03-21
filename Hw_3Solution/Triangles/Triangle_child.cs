using System;
using System.Collections.Generic;
using System.Text;

namespace TriangleClass
{
    public class Triangle_child : Triangle
    {
        
        public Triangle_child(float a, float b, float c) : base(a, b, c) { }

        public static float this_peri(Triangle_child x)
         => x.a + x.b + x.c;


        public static float parent_peri(Triangle x)
         => x.A + x.B + x.C;

    }
}
