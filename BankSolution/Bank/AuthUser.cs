using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank
{
    class AuthUser: PhysicalPerson
    {
        private string password;
        private string department;
        private string role;
        public AuthUser(string firstName, string lastName):base(firstName, lastName)
        {

        }

    }
}
