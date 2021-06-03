using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject
{
    class PhysicalPerson
    {
        
        private string guid = Guid.NewGuid().ToString();
        [Required]
        private string first_name;
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
