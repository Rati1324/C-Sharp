using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Linq;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            
            XElement elem = XElement.Load("Students.xml");
            var students = elem.Elements("Student");
            var names = students.Elements("Name");
           
            Console.WriteLine("names of students:");

            foreach (var item in names)
            {
                Console.WriteLine(item.Element("First").Value + " " + item.Element("Last").Value);
            }

            Console.WriteLine("\nstudents who study applied math");

            var Math = from y in students
                    where (string)y.Element("Course") == "Applied Math"
                    select y.Element("Name");
            foreach (var item in Math)
            {
                Console.WriteLine(item.Element("First").Value + " " + item.Element("Last").Value);
            }

            Console.WriteLine("\nstudents who live in london");
            var London = students.Where(y => (string)y.Element("Address").Element("City") == "London").ToList();

            foreach (var item in London)
            {
                Console.WriteLine(item.Element("Name").Element("First").Value + " " + item.Element("Name").Element("Last").Value);
            }

            Console.WriteLine("\nhow many students are from london");
            var LondonNum = (from y in students.Descendants("City")
                            where y.Value == "London"
                            select y).Count();
            Console.WriteLine(LondonNum);

            Console.WriteLine("\nstudents ordered by GPA");
            var GPA = students.OrderBy(y => (string)y.Element("GPA")).Reverse();
            foreach (var item in GPA)
            {
                Console.WriteLine((string)item.Element("Name").Element("First") + " " + (string)item.Element("Name").Element("Last") + " " +item.Element("GPA").Value);
            }
        

        }
    }
}