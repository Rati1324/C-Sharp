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
using System.Xml.Linq;
using System.Threading;

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
            #region user
            genderUser.Items.AddRange(new object[] { "Male", "Female" });
            genderUser.DropDownStyle = ComboBoxStyle.DropDownList;
            genderUser.SelectedIndex = 0;

            countryUser.Items.AddRange(new object[] { "Georgia", "USA" });
            countryUser.DropDownStyle = ComboBoxStyle.DropDownList;
            countryUser.SelectedIndex = 0;

            // cities added automatically
            //foreach (var city in Cities["Georgia"])
            //{
            //    cityUser.Items.Add(city);
            //}
            cityUser.DropDownStyle = ComboBoxStyle.DropDownList;
            cityUser.SelectedIndex = 0;

            //these also get added automaticaly
            //branch.Items.AddRange(new object[] { "Branch 1", "Branch 2", "Branch 3" });
            //role.Items.AddRange(new object[] { "Manager", "Bank teller", "Customer Support" });

            branch.DropDownStyle = ComboBoxStyle.DropDownList;
            branch.SelectedIndex = 0;

            role.DropDownStyle = ComboBoxStyle.DropDownList;
            role.SelectedIndex = 0;
            #endregion
            #region person
            // person country and gender values are alredy added in degisner.cs for some reason????? 
            //countryPerson.Items.AddRange(new object[] { "Georgia", "Tbilisi" });
            countryPerson.DropDownStyle = ComboBoxStyle.DropDownList;
            countryPerson.SelectedIndex = 0;

            //foreach (var city in Cities["Georgia"])
            //{
            //    cityPerson.Items.Add(city);
            //}
            cityPerson.DropDownStyle = ComboBoxStyle.DropDownList;
            cityPerson.SelectedIndex = 0;

            //genderPerson.Items.AddRange(new object[] { "Male", "Female" });
            genderPerson.DropDownStyle = ComboBoxStyle.DropDownList;
            genderPerson.SelectedIndex = 0;

            guarantorRelation.DropDownStyle = ComboBoxStyle.DropDownList;
            guarantorRelation.SelectedIndex = 0;
            #endregion

        }

        private void countryUser_SelectedIndexChanged(object sender, EventArgs e)
        {
            cityUser.Items.Clear();
            foreach (var elem in Cities[countryUser.Text])
            {
                cityUser.Items.Add(elem);
            }
            cityUser.SelectedIndex = 0;
        }

        private void countryPerson_SelectedIndexChanged(object sender, EventArgs e)
        {
            cityPerson.Items.Clear();
            foreach (var elem in Cities[countryPerson.Text])
            {
                cityPerson.Items.Add(elem);
            }
            cityPerson.SelectedIndex = 0;
        }
        private void registerUser_Click(object sender, EventArgs e)
        {
            //Account.AuthUser A = new Account.AuthUser()
            #region calling validations for user registration.
            bool valid = true;
            firstNameErrorUser.Text = Validations.validName(firstNameUser.Text);
            if (firstNameErrorUser.Text != "") valid = false;

            lastNameErrorUser.Text = Validations.validName(lastNameUser.Text);
            if (lastNameErrorUser.Text != "") valid = false;

            dobErrorUser.Text = Validations.validDob(dobUser.Value, genderUser.Text);
            if (dobErrorUser.Text != "") valid = false;

            phoneErrorUser.Text = Validations.validPhone(phoneUser.Text);
            if (phoneErrorUser.Text != "") valid = false;

            emailErrorUser.Text = Validations.validEmail(emailUser.Text);
            if (emailErrorUser.Text != "") valid = false;
            #endregion

            if (valid)
            {
                Account.AuthUser A = new Account.AuthUser(firstNameUser.Text,
                    lastNameUser.Text, genderUser.SelectedItem.ToString(), idUser.Text, dobUser.Value, countryUser.Text, cityUser.Text,
                    phoneUser.Text, emailUser.Text, passwordUser.Text, role.Text, branch.Text
                    );
                XDocument D = XDocument.Load("Users.xml");
                D.Element("Users").Add(new XElement("User",
                            new XElement("GUID", A.GuID),
                            new XElement("Name",
                                new XElement("First", firstNameUser.Text),
                                new XElement("Last", lastNameUser.Text)),
                            new XElement("Gender", genderUser.SelectedItem),
                            new XElement("DateOfBirth", dobUser.Value.ToString("yyyyy:MM:dd")),
                            new XElement("ID", idUser.Text),
                            new XElement("Country", countryUser.SelectedItem),
                            new XElement("City", cityUser.SelectedItem),
                            new XElement("Phone", phoneUser.Text),
                            new XElement("Email", emailUser.Text),
                            new XElement("Password", passwordUser.Text)
                            ));
                D.Save("C:/Users/rati/source/repos/C-Sharp/BankSolution/BankForm/bin/Debug/Users.xml");
            }
        }

        private void registerPerson_Click(object sender, EventArgs e)
        {
            bool valid = true;
            #region calling validations for person registration.
            firstNameErrorPerson.Text = Validations.validName(firstNamePerson.Text);
            if (firstNameErrorPerson.Text != "") valid = false;

            lastNameErrorPerson.Text = Validations.validName(lastNamePerson.Text);
            if (lastNameErrorPerson.Text != "") valid = false;

            dobErrorPerson.Text = Validations.validDob(dobPerson.Value, genderPerson.Text);
            if (dobErrorPerson.Text != "") valid = false;

            guarantorIDError.Text = Validations.validId(guarantorID.Text);
            if (guarantorIDError.Text != "") valid = false;

            phoneErrorPerson.Text = Validations.validPhone(phonePerson.Text);
            if (phoneErrorPerson.Text != "") valid = false;

            emailErrorPerson.Text = Validations.validEmail(emailPerson.Text);
            if (emailErrorPerson.Text != "") valid = false;
            #endregion
            if (valid)
            {
                XDocument D = XDocument.Load("People.xml");
                D.Element("People").Add(new XElement("Person",
                            new XElement("GUID", Guid.NewGuid().ToString()),
                            new XElement("Name",
                                new XElement("First", firstNamePerson.Text),
                                new XElement("Last", lastNamePerson.Text)),
                            new XElement("Gender", genderPerson.SelectedItem),
                            new XElement("DateOfBirth", dobPerson.Value.ToString("yyyyy:MM:dd")),
                            new XElement("ID", idPerson.Text),
                            new XElement("Country", countryPerson.SelectedItem),
                            new XElement("City", cityPerson.SelectedItem),
                            new XElement("Phone", phonePerson.Text),
                            new XElement("Email", emailPerson.Text),
                            new XElement("Guarantor_Relation", guarantorRelation.SelectedItem),
                            new XElement("Guarantor_Id", guarantorID.Text)
                            ));
                D.Save("C:/Users/rati/source/repos/C-Sharp/BankSolution/BankForm/bin/Debug/People.xml");
            }
        }

        private void getAll_Click(object sender, EventArgs e)
        {
            
            var people = Account.PhysicalPerson.getAllPeople();
            foreach (var p in people)
            {
                int n = peopleList.Rows.Add();
                peopleList.Rows[n].Cells[0].Value = p.Element("GUID").Value;
                peopleList.Rows[n].Cells[1].Value = p.Element("Name").Element("First").Value;
                peopleList.Rows[n].Cells[2].Value = p.Element("Name").Element("Last").Value;
                peopleList.Rows[n].Cells[3].Value = p.Element("ID").Value;
                peopleList.Rows[n].Cells[4].Value = p.Element("City").Value;
                peopleList.Rows[n].Cells[5].Value = p.Element("Country").Value;
                peopleList.Rows[n].Cells[6].Value = p.Element("Gender").Value;
                peopleList.Rows[n].Cells[7].Value = p.Element("DateOfBirth").Value;
                peopleList.Rows[n].Cells[8].Value = p.Element("Email").Value;
                peopleList.Rows[n].Cells[9].Value = p.Element("Phone").Value;
                peopleList.Rows[n].Cells[10].Value = p.Element("Guarantor_Relation").Value;
                peopleList.Rows[n].Cells[11].Value = p.Element("Guarantor_Id").Value;
            }
        }

        private void peopleList_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (peopleList.Columns["save"].Index == e.ColumnIndex)
            {
                List<string> newInfo = new List<string>();
                foreach (DataGridViewCell item in peopleList.Rows[e.RowIndex].Cells)
                {
                    if (item.ColumnIndex == peopleList.Columns["save"].Index) break;
                    newInfo.Add(item.Value.ToString());
                }
                Account.PhysicalPerson.editPerson(newInfo);

                peopleList.Update();
            }
        }
    }
}

