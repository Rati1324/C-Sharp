using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Linq;
using System.IO;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            #region classes and xml
            List<Student> S = new List<Student>()
            {
                new Student("02030104052", "John", "Johnson", "Math", "City1", "Street2", "Male"){GPA = 2.3F },
                new Student("01022342451", "Nick", "Nickson", "History", "City4", "Street1", "Male"){GPA = 1.3F },
                new Student("14234234256", "Kate", "Kateson", "English", "City53", "Street14", "Female"){GPA = 4.1F },
                new Student("34353233425", "Nick", "Johnson", "History", "City32", "Street10", "Male"){GPA = 1.3F },
                new Student("10292029282", "Mari", "Maridze", "Physics", "City5", "Street10", "Female"){GPA = 3.5F },
                new Student("34234324233", "Nino", "Ninodze", "Physics", "City6", "Street4", "Female"){GPA = 2.8F },
                new Student("20203023023", "Nana", "Nanadze", "Math", "City6", "Street5", "Male"){GPA = 3.7F }
            };

            XDocument xDoc = new XDocument(
                    new XDeclaration("1.0", "UTF-16", null),
                    new XElement("Students",
                        (from s in S
                         select new XElement("Student",
                            new XElement("id", s.Id),
                            new XElement("Name",
                                new XElement("First", s.F_name),
                                new XElement("Last", s.L_name)),
                            new XElement("Major", s.Major),

                            new XElement("Address",
                                new XElement("City", s.City),
                                new XElement("Street", s.Street)),
                            new XElement("Gender", s.Gender),
                            new XElement("GPA", s.GPA)
                    ))));

            StringWriter sw = new StringWriter();
            XmlWriter xWrite = XmlWriter.Create(sw);
            xDoc.Save("C:/Users/rati/source/repos/C-Sharp/hw8/ConsoleApp1/bin/Debug/Students.xml");
            #endregion

            var doc = XElement.Load("Students.xml");
            var Students = doc.Elements();

            var Majors = from x in Students
                         select x.Descendants("First").First().Value + " " + x.Descendants("Last").First().Value
                         + " " + x.Element("Major").Value;

            Console.WriteLine("Who studies what");
            foreach (var item in Majors) Console.WriteLine(item);

            var MathMajors = from x in Students
                             where x.Element("Major").Value == "Math"
                             select x.Descendants("First").First().Value + " " + x.Descendants("Last").First().Value;
            Console.WriteLine("\nStudents who study Math");
            foreach (var item in MathMajors) Console.WriteLine(item);


            var ByGpa = Students.OrderBy(y => y.Element("GPA").Value);
            Console.WriteLine("\nOrdered by GPA");
            foreach (var item in ByGpa) Console.WriteLine(item.Descendants("First").First().Value + " " + item.Descendants("Last").First().Value + " " + item.Element("GPA").Value);

            var City6 = Students.Count(y => y.Descendants("City").First().Value == "City6");
            Console.WriteLine($"\nHow many of them live in City6\n{City6}");

            var All = from x in Students
                      select x.Descendants("First").First().Value + " " + x.Descendants("Last").First().Value;
            Console.WriteLine("\nList of all students");
            foreach (var item in All){ Console.WriteLine(item);}

        }
        
        public static void UpdateGpa(float GPA, string id)
        {
            XDocument Doc = XDocument.Load("Students.xml");

            foreach (var item in Doc.Descendants("Student"))
            {
                if (item.Element("id").Value == id)
                    item.Element("GPA").Value = GPA.ToString();
            }
            Doc.Save("C:/Users/rati/source/repos/C-Sharp/hw8/ConsoleApp1/bin/Debug/Students.xml");
        }
    }
}