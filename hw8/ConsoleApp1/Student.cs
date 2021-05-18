using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Student
    {
        private string id;
        private string f_name;
        private string l_name;
        private float gpa;
        private string major;
        private string city;
        private string street; 
        private string gender;

        public string F_name { get => f_name; set => f_name = value; }
        public string L_name { get => l_name; set => l_name = value; }
        public float GPA { get => gpa; set => gpa = value; }
        public string Major{ get => major; set => major = value; }
        public string City{ get => city; set => city = value; }
        public string Street { get => street; set => street = value; }
        public string Gender { get => gender; set => gender = value; }
        public string Id { get => id; set => id = value; }
        public Student(string id, string f_name, string l_name, string major, string city, string street, string gender)
        {
            this.id = id;
            this.f_name = f_name;
            this.l_name = l_name;
            this.major = major;
            this.city = city;
            this.street = street;
            this.gender = gender;
        }


    }
}
