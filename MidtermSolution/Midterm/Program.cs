using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConvertMoney;

namespace Midterm
{
    
    class Program
    {
        // veghar movaswari ameebis dawera
        static void Main(string[] args)
        {
            Console.WriteLine("enter GELs");
            int gel = Int32.Parse(Console.ReadLine());
            Console.WriteLine("enter coins");
            int coins = Int32.Parse(Console.ReadLine());
            Console.WriteLine("enter c1");
            float c1 = Int32.Parse(Console.ReadLine());
            Console.WriteLine("enter c2");
            float c2 = Int32.Parse(Console.ReadLine());

            Money money = new Money(gel, coins);
            ComplexNumber cn = new ComplexNumber(c1, c2);

            Console.WriteLine("what do you want to do");
            int input = Int32.Parse(Console.ReadLine());

            while (input != 0)
            {
                Console.WriteLine("what do you want to do");
                Console.WriteLine(0 + " exit");
                Console.WriteLine(1 + " subtract money");
                Console.WriteLine(2 + " subtract money");
                Console.WriteLine(3 + " convert money");
                Console.WriteLine(4 + " add complex numbers");
                Console.WriteLine(5 + " subtract complex numbers");
                if (input == 1)
                {
                    int toAdd = Int32.Parse(Console.ReadLine());
                    Console.WriteLine("enter money to add");
                    money.Addition(toAdd);
                }
            }
        }
    }
}
