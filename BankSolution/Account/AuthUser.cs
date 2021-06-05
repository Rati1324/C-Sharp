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
        private string branch;
        private string role;
        public AuthUser(string firstName, string lastName, string gender, string id, DateTime dateOfBirth,
            string country, string city, string phone, string email, string password,
            string role, string branch):base(firstName, lastName, gender, id, dateOfBirth, country, city, phone,
            email)
        {

            this.password = password;
            this.role = role;
            this.branch = branch;
        }

    }
}
