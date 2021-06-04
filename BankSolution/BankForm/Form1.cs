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
        #region validations
        public bool validName(string name)
            => name.Length >= 2 && name.Length <= 50;
        public bool validId(string id)
            => Regex.IsMatch(id, @"^\d+$") && id.Length == 11;
        public bool validDob(DateTime dob)
        {
            int age = DateTime.Today.Year - dob.Year;
            if (age < 18) return false;
            if (genderPerson.Text == "Male") return age >= 65;
            return age >= 60;
        }
            
        public void validPhone()
        {
            string phoneNum = phonePerson.Text;
            string error = "";
            if (phoneNum.Length != 9 && !Regex.IsMatch(phoneNum, @"^\d+$"))
                error = "Not a valid phone number";
            phoneErrorPerson.Text = error;
        }

        public void validEmail()
        {
            string emailInput= emailPerson.Text;
            if (emailInput.Length > 0)
            {
                try
                {
                    MailAddress m = new MailAddress(emailInput);
                    emailErrorPerson.Text = "";
                }
                catch (FormatException)
                {
                    emailErrorPerson.Text = "Not a valid email";
                }
            }
            else
            {
                emailErrorPerson.Text = "Not a valid email";
            }
        }
        #endregion
        public Dictionary<string, List<string>> Cities = new Dictionary<string, List<string>>()
        {
            {"Georgia", new List<string>{ "Tbilisi" }},
            {"USA", new List<string>{ "Illinois", "Philadelphia" }},
        };
        public Form1()
        {
            InitializeComponent();
            countryPerson.Items.Add("Georgia");
            countryPerson.Items.Add("USA");
            countryPerson.SelectedIndex = 0;

            genderPerson.Items.Add("Male");
            genderPerson.Items.Add("Female");
            genderPerson.SelectedIndex = 0;

            guarantorRelation.Items.Add("Parent");
            guarantorRelation.Items.Add("Spouse");
            guarantorRelation.Items.Add("Friend");
            guarantorRelation.Items.Add("Relative");
            guarantorRelation.Items.Add("Other");
            guarantorRelation.SelectedIndex = 0;
        }

        private void country_SelectedIndexChanged(object sender, EventArgs e)
        {
            cityPerson.Items.Clear();
            foreach (var elem in Cities[countryPerson.Text])
            {
                cityPerson.Items.Add(elem);
            }
            cityPerson.SelectedIndex = 0;
        }

        private void submit_Click(object sender, EventArgs e)
        {
            #region calling validation
            if (!validName(firstNamePerson.Text)) firstNameErrorPerson.Text = "Must be between 2 and 50 characters";
            else firstNameErrorPerson.Text = "";
            if (!validName(lastNamePerson.Text)) lastNameErrorPerson.Text = "Must be between 2 and 50 characters";
            else lastNameErrorPerson.Text = "";
            if (!validId(idPerson.Text)) idErrorPerson.Text = "Not a valid ID";
            else idErrorPerson.Text = "";
            if (!validDob(dobPerson.Value)) dobErrorPerson.Text = "You must be older than 18 and younger than 65(M)/60(F)";
            else dobErrorPerson.Text = "";
            if (!validId(guarantorID.Text)) guarantorIDError.Text = "Not a valid ID";
            else guarantorIDError.Text = "";
            validPhone();
            validEmail();
            #endregion
        }

        private void registerPers_Click(object sender, EventArgs e)
        {
            panel1.BringToFront();
        }

        private void registerUser_Click(object sender, EventArgs e)
        {
            panel2.BringToFront();
        }

        
    }
}
