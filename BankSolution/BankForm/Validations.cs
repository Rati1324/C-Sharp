using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace BankForm
{
    public class Validations
    {
        public static string validName(string name)
        {
            if (name.Length <= 2 || name.Length >= 50)
            {
                return "Must be between 2 and 50 characters";
            }
            return "";
        }
          
        public static string validId(string id)
        {
            if (!(Regex.IsMatch(id, @"^\d+$") && id.Length == 11))
            {
                return "Not a valid ID";
            }
            return "";
        }
            
        public static string validDob(DateTime dob, string gender)
        {
            string error = "";
            int age = DateTime.Today.Year - dob.Year;
            if (age < 18) error = "You must be older than 18";
            else if (gender == "Male" && age >= 65) error = "You must younger than 65";
            else if (gender == "Female" && age >= 60) error = "You must be younger than 60(F)";
            return error;
        }

        public static string validPhone(string phone)
        {
            string error = "";
            if (phone.Length != 9 && !Regex.IsMatch(phone, @"^\d+$"))
                error = "Not a valid phone number";
            return error;
        }

        public static string validEmail(string email)
        {
            string error = "";
            if (email.Length > 0)
            {
                try
                {
                    MailAddress m = new MailAddress(email);
                    error = "";
                }
                catch (FormatException)
                {
                    error = "Not a valid email";
                }
            }
            else
            {
                error = "Not a valid email";
            }
            return error;
        }
    }
}
