using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Account
{
    public class AuthUser: PhysicalPerson
    {
        private string password;
        private string department;
        private string role;
        public AuthUser(string firstName, string lastName, string gender, string id, DateTime dateOfBirth,
            string country, string city, string phone, string email, string password,
            string department, string role):base(firstName, lastName, gender, id, dateOfBirth, country, city, phone,
            email)
        {
            this.password = password;
            this.department = department;
            this.role = role;
        }

    }
}
