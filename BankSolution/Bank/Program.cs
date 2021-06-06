using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Bank
{
    class Program
    {
        static void Main(string[] args)
        {
            var X = XElement.Load("../../../BankForm/bin/Debug/People.xml");
            var P = X.Elements("Person");
            var d = from s in P
                    select s.Element("Register_Date").Value;

            foreach (var item in d)
            {
                Console.WriteLine(DateTime.Parse(item) < DateTime.Now);
            }
        }
    }
}
