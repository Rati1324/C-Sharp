using System;
using System.Net.Mail;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BankForm
{
    public partial class Form1 : Form
    {
        public bool validName(string name)
            => name.Length >= 2 && name.Length <= 50;
        public bool validId(string id)
            => Regex.IsMatch(id, @"^\d+$") && id.Length == 11;
        public bool validDob(DateTime dob)
        {
            int age = DateTime.Today.Year - dob.Year;
            if (age < 18) return false;
            if (gender.Text == "Male") return age >= 65;
            return age >= 60;
        }
            
        public void validPhone()
        {
            string phoneNum = phone.Text;
            string error = "";
            if (phoneNum.Length != 9 && !Regex.IsMatch(phoneNum, @"^\d+$"))
                error = "Not a valid phone number";
            phoneError.Text = error;
        }

        public void validEmail()
        {
            string emailInput= email.Text;
            if (emailInput.Length > 0)
            {
                try
                {
                    MailAddress m = new MailAddress(emailInput);
                    emailError.Text = "";
                }
                catch (FormatException)
                {
                    emailError.Text = "Not a valid email";
                }
            }
            else
            {
                emailError.Text = "Not a valid email";
            }
        }

        public Dictionary<string, List<string>> Cities = new Dictionary<string, List<string>>()
        {
            {"Georgia", new List<string>{ "Tbilisi" }},
            {"USA", new List<string>{ "Illinois", "Philadelphia" }},
        };
        public Form1()
        {
            InitializeComponent();
            country.Items.Add("Georgia");
            country.Items.Add("USA");
            country.SelectedIndex = 0;

            gender.Items.Add("Male");
            gender.Items.Add("Female");
            gender.SelectedIndex = 0;

            guarantorRelation.Items.Add("Parent");
            guarantorRelation.Items.Add("Spouse");
            guarantorRelation.Items.Add("Friend");
            guarantorRelation.Items.Add("Relative");
            guarantorRelation.Items.Add("Other");
            guarantorRelation.SelectedIndex = 0;
        }

        private void country_SelectedIndexChanged(object sender, EventArgs e)
        {
            city.Items.Clear();
            foreach (var elem in Cities[country.Text])
            {
                city.Items.Add(elem);
            }
            city.SelectedIndex = 0;
        }

        private void submit_Click(object sender, EventArgs e)
        {
            if (!validName(firstName.Text)) firstNameError.Text = "Must be between 2 and 50 characters";
            else firstNameError.Text = "";
            if (!validName(lastName.Text)) lastNameError.Text = "Must be between 2 and 50 characters";
            else lastNameError.Text = "";
            if (!validId(ID.Text)) idError.Text = "Not a valid ID";
            else idError.Text = "";
            if (!validDob(dob.Value)) dobError.Text = "You must be older than 18 and younger than 65(M)/60(F)";
            else dobError.Text = "";
            if (!validId(guarantorID.Text)) guarantorIDError.Text = "Not a valid ID";
            else guarantorIDError.Text = "";
            validPhone();
            validEmail();
        }

      

    }
}
