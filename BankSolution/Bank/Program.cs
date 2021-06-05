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
            var X = XElement.Load("../../../BankForm/bin/Debug/Users.xml");
            var U = X.Elements("User");
            var x = U.Where(y => y.Element("ID").Value == "1212121212");
            x.First().SetElementValue("City", "asd2");
            X.Save("../../../BankForm/bin/Debug/Users.xml");
            //foreach (var item in U)
            //{
            //    Console.WriteLine(item.V);
            //}
        }
    }
}
