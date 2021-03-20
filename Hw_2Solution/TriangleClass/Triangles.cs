using System;

namespace Triangles
{
    // amocana 6.4.1  mteli ricxvebi sheatanineo mara floatebze gavakete universaluri rom iyos
    public static class Triangle
    {
        public static float CalcTriangle(float height, float baseSide)
        {
            if (height <= 0 || baseSide <= 0) throw new Exception("Only positive numbers allowed");
            return (height * baseSide) / 2;
        }

        public static float CalcTriangle(float A, float B, float C)
        {
            if (A <= 0 || B <= 0 || C <= 0) throw new Exception("Only positive numebrs allowed");
            return A + B + C;
        }
    }
}
