using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhysicalPerson
{
    public abstract class PhysicalPerson
    {
        private string guid = Guid.NewGuid().ToString();
        public string first_name { get; set; }
        private string last_name;
        private string gender;
        private string id;
        private DateTime date_of_birth = default(DateTime);
        private string country;
        private string city;
        private string phone;
        private string email;

    }
}
