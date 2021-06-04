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

            #region calling validation for person.
            firstNameErrorPerson.Text = Validations.validName(firstNamePerson.Text);
            lastNameErrorPerson.Text = Validations.validName(lastNamePerson.Text);
            idErrorPerson.Text = Validations.validId(idPerson.Text);
            dobErrorPerson.Text = Validations.validDob(dobPerson.Value, genderPerson.Text);
            guarantorIDError.Text = Validations.validId(guarantorID.Text);
            phoneErrorPerson.Text = Validations.validPhone(phonePerson.Text);
            emailErrorPerson.Text = Validations.validEmail(emailPerson.Text);
            #endregion
        }

        private void userRegisterTab_Click(object sender, EventArgs e)
        {
            loginPanel.Hide();
            userRegisterTab.Hide();
            userLoginTab.Show();
        }

        private void userLoginTab_Click(object sender, EventArgs e)
        {
            loginPanel.Show();
            userLoginTab.Hide();
            userRegisterTab.Show();
        }
    }
}

