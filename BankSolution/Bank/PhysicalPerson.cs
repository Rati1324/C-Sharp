using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank
{
    public abstract class PhysicalPerson
    {
        private string guid = Guid.NewGuid().ToString();
        public string firstName { get; set; }
        private string lastName;
        private string gender;
        private string id;
        private DateTime dateOfBirth = default(DateTime);
        private string country;
        private string city;
        private string phone;
        private string email;

        public PhysicalPerson(string firstName, string lastName)
        {
            this.firstName = firstName;
            this.lastName = lastName;
        }

    }
}
