using System;
using System.Collections.Generic;
using System.Text;

namespace Tasks
{
    public static class Task_2
    {
        // 1_30
        public static bool triangle(float a, float b, float c)
            => a > 0 && b > 0 && c > 0 && ((a > c && b > c) || (a > b && c > b) || (b > a && c > a));
    }
}
