using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace hw9
{
    class Program
    {
        //12.3.6. სტრიქონში დათვლის "რო" სიმბოლოების რაოდენობას.
        public static int task(string S)
            => Regex.Matches(S, "ro").Count;

        static void Main(string[] args)
        {
            string S = Console.ReadLine();
            if (float.TryParse(S, out float x))
            {
                throw new Exception("Only strings allowed");
            }

            Console.WriteLine(task(S));
        }

    }
}
