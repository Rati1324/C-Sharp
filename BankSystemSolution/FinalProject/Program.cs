using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankSystem
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, List<string>> Cities = new Dictionary<string, List<string>>()
            {
                {"fuck", new List<string>(){"you","me" } },
                {"fuck2", new List<string>(){"them","us" } }
            };
            foreach (KeyValuePair<string, List<string>> thing in Cities)
            {
                Console.WriteLine(thing.Key);
            }
        }
    }
}
