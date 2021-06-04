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
            // person country and gender values are alredy added in degisner.cs for some reason????? 
            //countryPerson.Items.AddRange(new object[] { "Georgia", "Tbilisi" });
            countryPerson.DropDownStyle = ComboBoxStyle.DropDownList;
            countryPerson.SelectedIndex = 0;

            cityPerson.DropDownStyle = ComboBoxStyle.DropDownList;
            cityPerson.SelectedIndex = 0;

            genderPerson.DropDownStyle = ComboBoxStyle.DropDownList;
            genderPerson.SelectedIndex = 0;

            guarantorRelation.DropDownStyle = ComboBoxStyle.DropDownList;
            guarantorRelation.SelectedIndex = 0;

            genderUser.Items.AddRange(new object[] { "Male", "Female" });
            genderUser.DropDownStyle = ComboBoxStyle.DropDownList;
            genderUser.SelectedIndex = 0;

            countryUser.Items.AddRange(new object[] { "Georgia", "USA" });
            countryUser.DropDownStyle = ComboBoxStyle.DropDownList;
            countryUser.SelectedIndex = 0;

            cityUser.DropDownStyle = ComboBoxStyle.DropDownList;
            cityUser.SelectedIndex = 0;

            // these also get added automaticaly
            //branch.Items.AddRange(new object[] { "Branch 1", "Branch 2", "Branch 3" });
            //role.Items.AddRange(new object[] { "Manager", "Bank teller", "Customer Support" });

            branch.DropDownStyle = ComboBoxStyle.DropDownList;
            branch.SelectedIndex = 0;

            role.DropDownStyle = ComboBoxStyle.DropDownList;
            role.SelectedIndex = 0;
        }

        private void countryPerson_SelectedIndexChanged(object sender, EventArgs e)
        {
            cityPerson.Items.Clear();
            foreach (var elem in Cities[countryPerson.Text])
            {
                cityPerson.Items.Add(elem);
            }
        }

        private void countryUser_SelectedIndexChanged(object sender, EventArgs e)
        {
            cityUser.Items.Clear();
            foreach (var elem in Cities[countryUser.Text])
            {
                cityUser.Items.Add(elem);
            }
            
        }

        private void userRegisterTab_Click(object sender, EventArgs e)
        {
            //loginPanel.Hide();
            userRegisterPanel.BringToFront();
            userRegisterTab.Hide();
            userLoginTab.Show();
        }

        private void userLoginTab_Click(object sender, EventArgs e)
        {
            loginPanel.BringToFront();
            userLoginTab.Hide();
            userRegisterTab.Show();
        }

        private void registerPerson_Click(object sender, EventArgs e)
        {
            #region calling validations for person registration.
            firstNameErrorPerson.Text = Validations.validName(firstNamePerson.Text);
            lastNameErrorPerson.Text = Validations.validName(lastNamePerson.Text);
            idErrorPerson.Text = Validations.validId(idPerson.Text);
            dobErrorPerson.Text = Validations.validDob(dobPerson.Value, genderPerson.Text);
            guarantorIDError.Text = Validations.validId(guarantorID.Text);
            phoneErrorPerson.Text = Validations.validPhone(phonePerson.Text);
            emailErrorPerson.Text = Validations.validEmail(emailPerson.Text);
            #endregion
        }

        private void registerUser_Click(object sender, EventArgs e)
        {
            //Account.AuthUser A = new Account.AuthUser()
            #region calling validations for user registration.
            firstNameErrorUser.Text = Validations.validName(firstNameUser.Text);
            lastNameErrorUser.Text = Validations.validName(lastNameUser.Text);
            idErrorUser.Text = Validations.validId(idUser.Text);
            dobErrorUser.Text = Validations.validDob(dobUser.Value, genderUser.Text);
            guarantorIDError.Text = Validations.validId(guarantorID.Text);
            phoneErrorUser.Text = Validations.validPhone(phoneUser.Text);
            emailErrorUser.Text = Validations.validEmail(emailUser.Text);
            #endregion
        }

        
    }
}

