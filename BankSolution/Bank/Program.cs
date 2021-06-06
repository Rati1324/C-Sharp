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
            var x = U.Where(y => y.Element("ID").Value == "1212121212").First();
            var elems = x.Elements();
            foreach (var item in elems)
            {
                if (item.Descendants().Count() > 0)
                {
                    foreach (var desc in item.Descendants())
                    {
                        item.SetElementValue(desc.Name, "tttt");
                    }
                }
                x.SetElementValue(item.Name, "test");
            }
            X.Save("../../../BankForm/bin/Debug/Users.xml");
        }
    }
}
