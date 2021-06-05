using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Account
{
    public abstract class PhysicalPerson
    {
        private string guid = Guid.NewGuid().ToString();
        public string firstName;
        private string lastName;
        private string gender;
        private string id;
        private DateTime dateOfBirth = default(DateTime);
        private string country;
        private string city;
        private string phone;
        private string email;
        private string guarantorRelation;
        private string guarantorId;
        public string GuID {get => this.guid;}
        public PhysicalPerson(string firstName, string lastName, string gender, string id, DateTime dateOfBirth, 
            string country, string city, string phone, string email, string guarantorRelation, string guarantorId)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.gender = gender;
            this.id = id;
            this.dateOfBirth = dateOfBirth;
            this.country = country;
            this.city = city;
            this.phone = phone;
            this.email = email;
            this.guarantorRelation = guarantorRelation;
            this.guarantorId = guarantorId;
        }

        public PhysicalPerson(string firstName, string lastName, string gender, string id, DateTime dateOfBirth,
            string country, string city, string phone, string email)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.gender = gender;
            this.id = id;
            this.dateOfBirth = dateOfBirth;
            this.country = country;
            this.city = city;
            this.phone = phone;
            this.email = email;
        }

        public static IEnumerable<XElement> getAllPeople()
        {
            XElement X = XElement.Load("People.xml");
            var people = X.Elements();
            return people;
        }
    }
}
