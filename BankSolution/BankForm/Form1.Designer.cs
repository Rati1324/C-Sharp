
using System.Windows.Forms;

namespace BankForm
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label9 = new System.Windows.Forms.Label();
            this.guarantorID = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.guarantorRelation = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.guarantorIDError = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.personRegisterPanel = new System.Windows.Forms.Panel();
            this.registerPerson = new System.Windows.Forms.Button();
            this.phonePerson = new System.Windows.Forms.TextBox();
            this.firstNamePerson = new System.Windows.Forms.TextBox();
            this.phoneErrorPerson = new System.Windows.Forms.Label();
            this.dobErrorPerson = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.idErrorPerson = new System.Windows.Forms.Label();
            this.emailErrorPerson = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.emailPerson = new System.Windows.Forms.TextBox();
            this.lastNamePerson = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label31 = new System.Windows.Forms.Label();
            this.cityPerson = new System.Windows.Forms.ComboBox();
            this.genderPerson = new System.Windows.Forms.ComboBox();
            this.dobPerson = new System.Windows.Forms.DateTimePicker();
            this.label32 = new System.Windows.Forms.Label();
            this.label33 = new System.Windows.Forms.Label();
            this.lastNameErrorPerson = new System.Windows.Forms.Label();
            this.idPerson = new System.Windows.Forms.TextBox();
            this.countryPerson = new System.Windows.Forms.ComboBox();
            this.label35 = new System.Windows.Forms.Label();
            this.label36 = new System.Windows.Forms.Label();
            this.firstNameErrorPerson = new System.Windows.Forms.Label();
            this.loginPanel = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox9 = new System.Windows.Forms.TextBox();
            this.textBox8 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.userRegisterPanel = new System.Windows.Forms.Panel();
            this.label12 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.role = new System.Windows.Forms.ComboBox();
            this.branch = new System.Windows.Forms.ComboBox();
            this.label30 = new System.Windows.Forms.Label();
            this.registerUser = new System.Windows.Forms.Button();
            this.phoneUser = new System.Windows.Forms.TextBox();
            this.firstNameUser = new System.Windows.Forms.TextBox();
            this.passwordConfirmError = new System.Windows.Forms.Label();
            this.phoneErrorUser = new System.Windows.Forms.Label();
            this.dobErrorUser = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.idErrorUser = new System.Windows.Forms.Label();
            this.emailErrorUser = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.emailUser = new System.Windows.Forms.TextBox();
            this.lastNameUser = new System.Windows.Forms.TextBox();
            this.label22 = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.cityUser = new System.Windows.Forms.ComboBox();
            this.genderUser = new System.Windows.Forms.ComboBox();
            this.dobUser = new System.Windows.Forms.DateTimePicker();
            this.label24 = new System.Windows.Forms.Label();
            this.label25 = new System.Windows.Forms.Label();
            this.lastNameErrorUser = new System.Windows.Forms.Label();
            this.idUser = new System.Windows.Forms.TextBox();
            this.countryUser = new System.Windows.Forms.ComboBox();
            this.label27 = new System.Windows.Forms.Label();
            this.label28 = new System.Windows.Forms.Label();
            this.firstNameErrorUser = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.passwordConfirm = new System.Windows.Forms.TextBox();
            this.passwordUser = new System.Windows.Forms.TextBox();
            this.userRegisterTab = new System.Windows.Forms.Button();
            this.userLoginTab = new System.Windows.Forms.Button();
            this.personRegisterPanel.SuspendLayout();
            this.loginPanel.SuspendLayout();
            this.userRegisterPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(66, 459);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(57, 13);
            this.label9.TabIndex = 8;
            this.label9.Text = "Guarantor:";
            // 
            // guarantorID
            // 
            this.guarantorID.Location = new System.Drawing.Point(217, 456);
            this.guarantorID.Name = "guarantorID";
            this.guarantorID.Size = new System.Drawing.Size(85, 20);
            this.guarantorID.TabIndex = 2;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(131, 439);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(49, 13);
            this.label10.TabIndex = 8;
            this.label10.Text = "Relation:";
            // 
            // guarantorRelation
            // 
            this.guarantorRelation.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.guarantorRelation.FormattingEnabled = true;
            this.guarantorRelation.Items.AddRange(new object[] {
            "Parent",
            "Spouse",
            "Friend",
            "Relative",
            "Other"});
            this.guarantorRelation.Location = new System.Drawing.Point(134, 455);
            this.guarantorRelation.Name = "guarantorRelation";
            this.guarantorRelation.Size = new System.Drawing.Size(77, 21);
            this.guarantorRelation.TabIndex = 9;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(214, 439);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(21, 13);
            this.label11.TabIndex = 8;
            this.label11.Text = "ID:";
            // 
            // guarantorIDError
            // 
            this.guarantorIDError.AutoSize = true;
            this.guarantorIDError.ForeColor = System.Drawing.Color.Red;
            this.guarantorIDError.Location = new System.Drawing.Point(214, 479);
            this.guarantorIDError.Name = "guarantorIDError";
            this.guarantorIDError.Size = new System.Drawing.Size(0, 13);
            this.guarantorIDError.TabIndex = 8;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(73, 22);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(233, 24);
            this.label13.TabIndex = 0;
            this.label13.Text = "Register a Physical Person";
            // 
            // personRegisterPanel
            // 
            this.personRegisterPanel.Controls.Add(this.userRegisterPanel);
            this.personRegisterPanel.Controls.Add(this.registerPerson);
            this.personRegisterPanel.Controls.Add(this.phonePerson);
            this.personRegisterPanel.Controls.Add(this.firstNamePerson);
            this.personRegisterPanel.Controls.Add(this.phoneErrorPerson);
            this.personRegisterPanel.Controls.Add(this.dobErrorPerson);
            this.personRegisterPanel.Controls.Add(this.label3);
            this.personRegisterPanel.Controls.Add(this.label4);
            this.personRegisterPanel.Controls.Add(this.idErrorPerson);
            this.personRegisterPanel.Controls.Add(this.emailErrorPerson);
            this.personRegisterPanel.Controls.Add(this.label7);
            this.personRegisterPanel.Controls.Add(this.emailPerson);
            this.personRegisterPanel.Controls.Add(this.lastNamePerson);
            this.personRegisterPanel.Controls.Add(this.label8);
            this.personRegisterPanel.Controls.Add(this.label31);
            this.personRegisterPanel.Controls.Add(this.cityPerson);
            this.personRegisterPanel.Controls.Add(this.genderPerson);
            this.personRegisterPanel.Controls.Add(this.dobPerson);
            this.personRegisterPanel.Controls.Add(this.label32);
            this.personRegisterPanel.Controls.Add(this.label33);
            this.personRegisterPanel.Controls.Add(this.lastNameErrorPerson);
            this.personRegisterPanel.Controls.Add(this.idPerson);
            this.personRegisterPanel.Controls.Add(this.countryPerson);
            this.personRegisterPanel.Controls.Add(this.label35);
            this.personRegisterPanel.Controls.Add(this.label36);
            this.personRegisterPanel.Controls.Add(this.firstNameErrorPerson);
            this.personRegisterPanel.Controls.Add(this.guarantorID);
            this.personRegisterPanel.Controls.Add(this.label13);
            this.personRegisterPanel.Controls.Add(this.label11);
            this.personRegisterPanel.Controls.Add(this.guarantorIDError);
            this.personRegisterPanel.Controls.Add(this.guarantorRelation);
            this.personRegisterPanel.Controls.Add(this.label10);
            this.personRegisterPanel.Controls.Add(this.label9);
            this.personRegisterPanel.Location = new System.Drawing.Point(214, -1);
            this.personRegisterPanel.Name = "personRegisterPanel";
            this.personRegisterPanel.Size = new System.Drawing.Size(482, 592);
            this.personRegisterPanel.TabIndex = 15;
            // 
            // registerPerson
            // 
            this.registerPerson.Location = new System.Drawing.Point(231, 497);
            this.registerPerson.Name = "registerPerson";
            this.registerPerson.Size = new System.Drawing.Size(75, 23);
            this.registerPerson.TabIndex = 19;
            this.registerPerson.Text = "Register";
            this.registerPerson.UseVisualStyleBackColor = true;
            this.registerPerson.Click += new System.EventHandler(this.registerPerson_Click);
            // 
            // phonePerson
            // 
            this.phonePerson.Location = new System.Drawing.Point(134, 354);
            this.phonePerson.Name = "phonePerson";
            this.phonePerson.Size = new System.Drawing.Size(168, 20);
            this.phonePerson.TabIndex = 44;
            // 
            // firstNamePerson
            // 
            this.firstNamePerson.Location = new System.Drawing.Point(134, 62);
            this.firstNamePerson.Name = "firstNamePerson";
            this.firstNamePerson.Size = new System.Drawing.Size(168, 20);
            this.firstNamePerson.TabIndex = 39;
            // 
            // phoneErrorPerson
            // 
            this.phoneErrorPerson.AutoSize = true;
            this.phoneErrorPerson.ForeColor = System.Drawing.Color.Red;
            this.phoneErrorPerson.Location = new System.Drawing.Point(134, 378);
            this.phoneErrorPerson.Name = "phoneErrorPerson";
            this.phoneErrorPerson.Size = new System.Drawing.Size(0, 13);
            this.phoneErrorPerson.TabIndex = 53;
            // 
            // dobErrorPerson
            // 
            this.dobErrorPerson.AutoSize = true;
            this.dobErrorPerson.BackColor = System.Drawing.Color.Transparent;
            this.dobErrorPerson.ForeColor = System.Drawing.Color.Red;
            this.dobErrorPerson.Location = new System.Drawing.Point(134, 257);
            this.dobErrorPerson.Name = "dobErrorPerson";
            this.dobErrorPerson.Size = new System.Drawing.Size(0, 13);
            this.dobErrorPerson.TabIndex = 62;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(101, 199);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(21, 13);
            this.label3.TabIndex = 47;
            this.label3.Text = "ID:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(62, 65);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 13);
            this.label4.TabIndex = 42;
            this.label4.Text = "First Name:";
            // 
            // idErrorPerson
            // 
            this.idErrorPerson.AutoSize = true;
            this.idErrorPerson.ForeColor = System.Drawing.Color.Red;
            this.idErrorPerson.Location = new System.Drawing.Point(134, 217);
            this.idErrorPerson.Name = "idErrorPerson";
            this.idErrorPerson.Size = new System.Drawing.Size(0, 13);
            this.idErrorPerson.TabIndex = 61;
            // 
            // emailErrorPerson
            // 
            this.emailErrorPerson.AutoSize = true;
            this.emailErrorPerson.ForeColor = System.Drawing.Color.Red;
            this.emailErrorPerson.Location = new System.Drawing.Point(136, 420);
            this.emailErrorPerson.Name = "emailErrorPerson";
            this.emailErrorPerson.Size = new System.Drawing.Size(0, 13);
            this.emailErrorPerson.TabIndex = 50;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(95, 321);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(27, 13);
            this.label7.TabIndex = 55;
            this.label7.Text = "City:";
            // 
            // emailPerson
            // 
            this.emailPerson.Location = new System.Drawing.Point(134, 394);
            this.emailPerson.Name = "emailPerson";
            this.emailPerson.Size = new System.Drawing.Size(168, 20);
            this.emailPerson.TabIndex = 46;
            // 
            // lastNamePerson
            // 
            this.lastNamePerson.Location = new System.Drawing.Point(134, 105);
            this.lastNamePerson.Name = "lastNamePerson";
            this.lastNamePerson.Size = new System.Drawing.Size(168, 20);
            this.lastNamePerson.TabIndex = 40;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(53, 240);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(69, 13);
            this.label8.TabIndex = 48;
            this.label8.Text = "Date of Birth:";
            // 
            // label31
            // 
            this.label31.AutoSize = true;
            this.label31.Location = new System.Drawing.Point(81, 357);
            this.label31.Name = "label31";
            this.label31.Size = new System.Drawing.Size(41, 13);
            this.label31.TabIndex = 51;
            this.label31.Text = "Phone:";
            // 
            // cityPerson
            // 
            this.cityPerson.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cityPerson.FormattingEnabled = true;
            this.cityPerson.Location = new System.Drawing.Point(134, 313);
            this.cityPerson.Name = "cityPerson";
            this.cityPerson.Size = new System.Drawing.Size(168, 21);
            this.cityPerson.TabIndex = 56;
            // 
            // genderPerson
            // 
            this.genderPerson.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.genderPerson.FormattingEnabled = true;
            this.genderPerson.Items.AddRange(new object[] {
            "Male",
            "Female"});
            this.genderPerson.Location = new System.Drawing.Point(134, 148);
            this.genderPerson.Name = "genderPerson";
            this.genderPerson.Size = new System.Drawing.Size(168, 21);
            this.genderPerson.TabIndex = 60;
            // 
            // dobPerson
            // 
            this.dobPerson.Location = new System.Drawing.Point(134, 233);
            this.dobPerson.Name = "dobPerson";
            this.dobPerson.Size = new System.Drawing.Size(168, 20);
            this.dobPerson.TabIndex = 49;
            // 
            // label32
            // 
            this.label32.AutoSize = true;
            this.label32.Location = new System.Drawing.Point(70, 111);
            this.label32.Name = "label32";
            this.label32.Size = new System.Drawing.Size(58, 13);
            this.label32.TabIndex = 41;
            this.label32.Text = "LastName:";
            // 
            // label33
            // 
            this.label33.AutoSize = true;
            this.label33.Location = new System.Drawing.Point(87, 401);
            this.label33.Name = "label33";
            this.label33.Size = new System.Drawing.Size(35, 13);
            this.label33.TabIndex = 52;
            this.label33.Text = "Email:";
            // 
            // lastNameErrorPerson
            // 
            this.lastNameErrorPerson.AutoSize = true;
            this.lastNameErrorPerson.ForeColor = System.Drawing.Color.Red;
            this.lastNameErrorPerson.Location = new System.Drawing.Point(133, 132);
            this.lastNameErrorPerson.Name = "lastNameErrorPerson";
            this.lastNameErrorPerson.Size = new System.Drawing.Size(0, 13);
            this.lastNameErrorPerson.TabIndex = 58;
            // 
            // idPerson
            // 
            this.idPerson.Location = new System.Drawing.Point(134, 192);
            this.idPerson.Name = "idPerson";
            this.idPerson.Size = new System.Drawing.Size(168, 20);
            this.idPerson.TabIndex = 45;
            // 
            // countryPerson
            // 
            this.countryPerson.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.countryPerson.FormattingEnabled = true;
            this.countryPerson.Items.AddRange(new object[] {
            "Georgia",
            "USA"});
            this.countryPerson.Location = new System.Drawing.Point(134, 274);
            this.countryPerson.Name = "countryPerson";
            this.countryPerson.Size = new System.Drawing.Size(168, 21);
            this.countryPerson.TabIndex = 57;
            this.countryPerson.SelectedIndexChanged += new System.EventHandler(this.countryPerson_SelectedIndexChanged);
            // 
            // label35
            // 
            this.label35.AutoSize = true;
            this.label35.Location = new System.Drawing.Point(76, 282);
            this.label35.Name = "label35";
            this.label35.Size = new System.Drawing.Size(46, 13);
            this.label35.TabIndex = 54;
            this.label35.Text = "Country:";
            // 
            // label36
            // 
            this.label36.AutoSize = true;
            this.label36.Location = new System.Drawing.Point(77, 156);
            this.label36.Name = "label36";
            this.label36.Size = new System.Drawing.Size(45, 13);
            this.label36.TabIndex = 43;
            this.label36.Text = "Gender:";
            // 
            // firstNameErrorPerson
            // 
            this.firstNameErrorPerson.AutoSize = true;
            this.firstNameErrorPerson.ForeColor = System.Drawing.Color.Red;
            this.firstNameErrorPerson.Location = new System.Drawing.Point(133, 85);
            this.firstNameErrorPerson.Name = "firstNameErrorPerson";
            this.firstNameErrorPerson.Size = new System.Drawing.Size(0, 13);
            this.firstNameErrorPerson.TabIndex = 59;
            // 
            // loginPanel
            // 
            this.loginPanel.Controls.Add(this.button2);
            this.loginPanel.Controls.Add(this.label5);
            this.loginPanel.Controls.Add(this.label2);
            this.loginPanel.Controls.Add(this.textBox9);
            this.loginPanel.Controls.Add(this.textBox8);
            this.loginPanel.Controls.Add(this.label1);
            this.loginPanel.Location = new System.Drawing.Point(0, -3);
            this.loginPanel.Name = "loginPanel";
            this.loginPanel.Size = new System.Drawing.Size(482, 598);
            this.loginPanel.TabIndex = 17;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(251, 162);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 17;
            this.button2.Text = "Log in ";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(114, 126);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 13);
            this.label5.TabIndex = 18;
            this.label5.Text = "Password:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(114, 83);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 18;
            this.label2.Text = "E-mail:";
            // 
            // textBox9
            // 
            this.textBox9.Location = new System.Drawing.Point(176, 123);
            this.textBox9.Name = "textBox9";
            this.textBox9.Size = new System.Drawing.Size(150, 20);
            this.textBox9.TabIndex = 17;
            // 
            // textBox8
            // 
            this.textBox8.Location = new System.Drawing.Point(176, 80);
            this.textBox8.Name = "textBox8";
            this.textBox8.Size = new System.Drawing.Size(150, 20);
            this.textBox8.TabIndex = 17;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(205, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Log In";
            // 
            // userRegisterPanel
            // 
            this.userRegisterPanel.Controls.Add(this.loginPanel);
            this.userRegisterPanel.Controls.Add(this.label12);
            this.userRegisterPanel.Controls.Add(this.label6);
            this.userRegisterPanel.Controls.Add(this.role);
            this.userRegisterPanel.Controls.Add(this.branch);
            this.userRegisterPanel.Controls.Add(this.label30);
            this.userRegisterPanel.Controls.Add(this.registerUser);
            this.userRegisterPanel.Controls.Add(this.phoneUser);
            this.userRegisterPanel.Controls.Add(this.firstNameUser);
            this.userRegisterPanel.Controls.Add(this.passwordConfirmError);
            this.userRegisterPanel.Controls.Add(this.phoneErrorUser);
            this.userRegisterPanel.Controls.Add(this.dobErrorUser);
            this.userRegisterPanel.Controls.Add(this.label17);
            this.userRegisterPanel.Controls.Add(this.label18);
            this.userRegisterPanel.Controls.Add(this.idErrorUser);
            this.userRegisterPanel.Controls.Add(this.emailErrorUser);
            this.userRegisterPanel.Controls.Add(this.label21);
            this.userRegisterPanel.Controls.Add(this.emailUser);
            this.userRegisterPanel.Controls.Add(this.lastNameUser);
            this.userRegisterPanel.Controls.Add(this.label22);
            this.userRegisterPanel.Controls.Add(this.label23);
            this.userRegisterPanel.Controls.Add(this.cityUser);
            this.userRegisterPanel.Controls.Add(this.genderUser);
            this.userRegisterPanel.Controls.Add(this.dobUser);
            this.userRegisterPanel.Controls.Add(this.label24);
            this.userRegisterPanel.Controls.Add(this.label25);
            this.userRegisterPanel.Controls.Add(this.lastNameErrorUser);
            this.userRegisterPanel.Controls.Add(this.idUser);
            this.userRegisterPanel.Controls.Add(this.countryUser);
            this.userRegisterPanel.Controls.Add(this.label27);
            this.userRegisterPanel.Controls.Add(this.label28);
            this.userRegisterPanel.Controls.Add(this.firstNameErrorUser);
            this.userRegisterPanel.Controls.Add(this.label16);
            this.userRegisterPanel.Controls.Add(this.label15);
            this.userRegisterPanel.Controls.Add(this.passwordConfirm);
            this.userRegisterPanel.Controls.Add(this.passwordUser);
            this.userRegisterPanel.Location = new System.Drawing.Point(31, 3);
            this.userRegisterPanel.Name = "userRegisterPanel";
            this.userRegisterPanel.Size = new System.Drawing.Size(482, 592);
            this.userRegisterPanel.TabIndex = 16;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(95, 529);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(32, 13);
            this.label12.TabIndex = 41;
            this.label12.Text = "Role:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(84, 494);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(44, 13);
            this.label6.TabIndex = 41;
            this.label6.Text = "Branch:";
            // 
            // role
            // 
            this.role.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.role.FormattingEnabled = true;
            this.role.Items.AddRange(new object[] {
            "Manager",
            "Customer Support",
            "Bank Teller"});
            this.role.Location = new System.Drawing.Point(137, 525);
            this.role.Name = "role";
            this.role.Size = new System.Drawing.Size(168, 21);
            this.role.TabIndex = 40;
            // 
            // branch
            // 
            this.branch.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.branch.FormattingEnabled = true;
            this.branch.Items.AddRange(new object[] {
            "Branch1",
            "Branch2",
            "Branch3"});
            this.branch.Location = new System.Drawing.Point(137, 491);
            this.branch.Name = "branch";
            this.branch.Size = new System.Drawing.Size(168, 21);
            this.branch.TabIndex = 40;
            // 
            // label30
            // 
            this.label30.AutoSize = true;
            this.label30.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label30.Location = new System.Drawing.Point(138, 3);
            this.label30.Name = "label30";
            this.label30.Size = new System.Drawing.Size(145, 24);
            this.label30.TabIndex = 39;
            this.label30.Text = "User registration";
            // 
            // registerUser
            // 
            this.registerUser.Location = new System.Drawing.Point(230, 556);
            this.registerUser.Name = "registerUser";
            this.registerUser.Size = new System.Drawing.Size(75, 23);
            this.registerUser.TabIndex = 2;
            this.registerUser.Text = "Register";
            this.registerUser.UseVisualStyleBackColor = true;
            this.registerUser.Click += new System.EventHandler(this.registerUser_Click);
            // 
            // phoneUser
            // 
            this.phoneUser.Location = new System.Drawing.Point(137, 332);
            this.phoneUser.Name = "phoneUser";
            this.phoneUser.Size = new System.Drawing.Size(168, 20);
            this.phoneUser.TabIndex = 20;
            // 
            // firstNameUser
            // 
            this.firstNameUser.Location = new System.Drawing.Point(137, 40);
            this.firstNameUser.Name = "firstNameUser";
            this.firstNameUser.Size = new System.Drawing.Size(168, 20);
            this.firstNameUser.TabIndex = 15;
            // 
            // passwordConfirmError
            // 
            this.passwordConfirmError.AutoSize = true;
            this.passwordConfirmError.ForeColor = System.Drawing.Color.Red;
            this.passwordConfirmError.Location = new System.Drawing.Point(137, 481);
            this.passwordConfirmError.Name = "passwordConfirmError";
            this.passwordConfirmError.Size = new System.Drawing.Size(0, 13);
            this.passwordConfirmError.TabIndex = 29;
            // 
            // phoneErrorUser
            // 
            this.phoneErrorUser.AutoSize = true;
            this.phoneErrorUser.ForeColor = System.Drawing.Color.Red;
            this.phoneErrorUser.Location = new System.Drawing.Point(137, 356);
            this.phoneErrorUser.Name = "phoneErrorUser";
            this.phoneErrorUser.Size = new System.Drawing.Size(0, 13);
            this.phoneErrorUser.TabIndex = 29;
            // 
            // dobErrorUser
            // 
            this.dobErrorUser.AutoSize = true;
            this.dobErrorUser.BackColor = System.Drawing.Color.Transparent;
            this.dobErrorUser.ForeColor = System.Drawing.Color.Red;
            this.dobErrorUser.Location = new System.Drawing.Point(137, 235);
            this.dobErrorUser.Name = "dobErrorUser";
            this.dobErrorUser.Size = new System.Drawing.Size(0, 13);
            this.dobErrorUser.TabIndex = 38;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(104, 177);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(21, 13);
            this.label17.TabIndex = 23;
            this.label17.Text = "ID:";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(65, 43);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(60, 13);
            this.label18.TabIndex = 18;
            this.label18.Text = "First Name:";
            // 
            // idErrorUser
            // 
            this.idErrorUser.AutoSize = true;
            this.idErrorUser.ForeColor = System.Drawing.Color.Red;
            this.idErrorUser.Location = new System.Drawing.Point(137, 195);
            this.idErrorUser.Name = "idErrorUser";
            this.idErrorUser.Size = new System.Drawing.Size(0, 13);
            this.idErrorUser.TabIndex = 37;
            // 
            // emailErrorUser
            // 
            this.emailErrorUser.AutoSize = true;
            this.emailErrorUser.ForeColor = System.Drawing.Color.Red;
            this.emailErrorUser.Location = new System.Drawing.Point(139, 398);
            this.emailErrorUser.Name = "emailErrorUser";
            this.emailErrorUser.Size = new System.Drawing.Size(0, 13);
            this.emailErrorUser.TabIndex = 26;
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(98, 299);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(27, 13);
            this.label21.TabIndex = 31;
            this.label21.Text = "City:";
            // 
            // emailUser
            // 
            this.emailUser.Location = new System.Drawing.Point(137, 372);
            this.emailUser.Name = "emailUser";
            this.emailUser.Size = new System.Drawing.Size(168, 20);
            this.emailUser.TabIndex = 22;
            // 
            // lastNameUser
            // 
            this.lastNameUser.Location = new System.Drawing.Point(137, 83);
            this.lastNameUser.Name = "lastNameUser";
            this.lastNameUser.Size = new System.Drawing.Size(168, 20);
            this.lastNameUser.TabIndex = 16;
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(56, 218);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(69, 13);
            this.label22.TabIndex = 24;
            this.label22.Text = "Date of Birth:";
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(84, 335);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(41, 13);
            this.label23.TabIndex = 27;
            this.label23.Text = "Phone:";
            // 
            // cityUser
            // 
            this.cityUser.FormattingEnabled = true;
            this.cityUser.Location = new System.Drawing.Point(137, 291);
            this.cityUser.Name = "cityUser";
            this.cityUser.Size = new System.Drawing.Size(168, 21);
            this.cityUser.TabIndex = 32;
            // 
            // genderUser
            // 
            this.genderUser.FormattingEnabled = true;
            this.genderUser.Location = new System.Drawing.Point(137, 126);
            this.genderUser.Name = "genderUser";
            this.genderUser.Size = new System.Drawing.Size(168, 21);
            this.genderUser.TabIndex = 36;
            // 
            // dobUser
            // 
            this.dobUser.Location = new System.Drawing.Point(137, 211);
            this.dobUser.Name = "dobUser";
            this.dobUser.Size = new System.Drawing.Size(168, 20);
            this.dobUser.TabIndex = 25;
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Location = new System.Drawing.Point(73, 89);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(58, 13);
            this.label24.TabIndex = 17;
            this.label24.Text = "LastName:";
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Location = new System.Drawing.Point(90, 379);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(35, 13);
            this.label25.TabIndex = 28;
            this.label25.Text = "Email:";
            // 
            // lastNameErrorUser
            // 
            this.lastNameErrorUser.AutoSize = true;
            this.lastNameErrorUser.ForeColor = System.Drawing.Color.Red;
            this.lastNameErrorUser.Location = new System.Drawing.Point(136, 110);
            this.lastNameErrorUser.Name = "lastNameErrorUser";
            this.lastNameErrorUser.Size = new System.Drawing.Size(0, 13);
            this.lastNameErrorUser.TabIndex = 34;
            // 
            // idUser
            // 
            this.idUser.Location = new System.Drawing.Point(137, 170);
            this.idUser.Name = "idUser";
            this.idUser.Size = new System.Drawing.Size(168, 20);
            this.idUser.TabIndex = 21;
            // 
            // countryUser
            // 
            this.countryUser.FormattingEnabled = true;
            this.countryUser.Location = new System.Drawing.Point(137, 252);
            this.countryUser.Name = "countryUser";
            this.countryUser.Size = new System.Drawing.Size(168, 21);
            this.countryUser.TabIndex = 33;
            this.countryUser.SelectedIndexChanged += new System.EventHandler(this.countryUser_SelectedIndexChanged);
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.Location = new System.Drawing.Point(79, 260);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(46, 13);
            this.label27.TabIndex = 30;
            this.label27.Text = "Country:";
            // 
            // label28
            // 
            this.label28.AutoSize = true;
            this.label28.Location = new System.Drawing.Point(80, 134);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(45, 13);
            this.label28.TabIndex = 19;
            this.label28.Text = "Gender:";
            // 
            // firstNameErrorUser
            // 
            this.firstNameErrorUser.AutoSize = true;
            this.firstNameErrorUser.ForeColor = System.Drawing.Color.Red;
            this.firstNameErrorUser.Location = new System.Drawing.Point(136, 63);
            this.firstNameErrorUser.Name = "firstNameErrorUser";
            this.firstNameErrorUser.Size = new System.Drawing.Size(0, 13);
            this.firstNameErrorUser.TabIndex = 35;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(32, 455);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(93, 13);
            this.label16.TabIndex = 1;
            this.label16.Text = "Confirm password:";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(69, 416);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(56, 13);
            this.label15.TabIndex = 1;
            this.label15.Text = "Password:";
            // 
            // passwordConfirm
            // 
            this.passwordConfirm.Location = new System.Drawing.Point(137, 452);
            this.passwordConfirm.Name = "passwordConfirm";
            this.passwordConfirm.Size = new System.Drawing.Size(168, 20);
            this.passwordConfirm.TabIndex = 0;
            // 
            // passwordUser
            // 
            this.passwordUser.Location = new System.Drawing.Point(137, 413);
            this.passwordUser.Name = "passwordUser";
            this.passwordUser.Size = new System.Drawing.Size(168, 20);
            this.passwordUser.TabIndex = 0;
            // 
            // userRegisterTab
            // 
            this.userRegisterTab.Location = new System.Drawing.Point(22, 12);
            this.userRegisterTab.Name = "userRegisterTab";
            this.userRegisterTab.Size = new System.Drawing.Size(75, 23);
            this.userRegisterTab.TabIndex = 17;
            this.userRegisterTab.Text = "Register";
            this.userRegisterTab.UseVisualStyleBackColor = true;
            this.userRegisterTab.Click += new System.EventHandler(this.userRegisterTab_Click);
            // 
            // userLoginTab
            // 
            this.userLoginTab.Location = new System.Drawing.Point(22, 12);
            this.userLoginTab.Name = "userLoginTab";
            this.userLoginTab.Size = new System.Drawing.Size(75, 23);
            this.userLoginTab.TabIndex = 18;
            this.userLoginTab.Text = "Log in";
            this.userLoginTab.UseVisualStyleBackColor = true;
            this.userLoginTab.Click += new System.EventHandler(this.userLoginTab_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1020, 632);
            this.Controls.Add(this.userRegisterTab);
            this.Controls.Add(this.userLoginTab);
            this.Controls.Add(this.personRegisterPanel);
            this.Name = "Form1";
            this.Text = "Form1";
            this.personRegisterPanel.ResumeLayout(false);
            this.personRegisterPanel.PerformLayout();
            this.loginPanel.ResumeLayout(false);
            this.loginPanel.PerformLayout();
            this.userRegisterPanel.ResumeLayout(false);
            this.userRegisterPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox guarantorID;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox guarantorRelation;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label guarantorIDError;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Panel personRegisterPanel;
        private System.Windows.Forms.Panel userRegisterPanel;
        private System.Windows.Forms.Button registerUser;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox passwordConfirm;
        private System.Windows.Forms.TextBox passwordUser;
        private System.Windows.Forms.TextBox phoneUser;
        private System.Windows.Forms.TextBox firstNameUser;
        private System.Windows.Forms.Label phoneErrorUser;
        private System.Windows.Forms.Label dobErrorUser;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label idErrorUser;
        private System.Windows.Forms.Label emailErrorUser;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.TextBox emailUser;
        private System.Windows.Forms.TextBox lastNameUser;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.ComboBox cityUser;
        private System.Windows.Forms.ComboBox genderUser;
        private System.Windows.Forms.DateTimePicker dobUser;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.Label lastNameErrorUser;
        private System.Windows.Forms.TextBox idUser;
        private System.Windows.Forms.ComboBox countryUser;
        private System.Windows.Forms.Label label27;
        private System.Windows.Forms.Label label28;
        private System.Windows.Forms.Label firstNameErrorUser;
        private System.Windows.Forms.Label label30;
        private System.Windows.Forms.Label passwordConfirmError;
        private System.Windows.Forms.TextBox phonePerson;
        private System.Windows.Forms.TextBox firstNamePerson;
        private System.Windows.Forms.Label phoneErrorPerson;
        private System.Windows.Forms.Label dobErrorPerson;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label idErrorPerson;
        private System.Windows.Forms.Label emailErrorPerson;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox emailPerson;
        private System.Windows.Forms.TextBox lastNamePerson;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label31;
        private System.Windows.Forms.ComboBox cityPerson;
        private System.Windows.Forms.ComboBox genderPerson;
        private System.Windows.Forms.DateTimePicker dobPerson;
        private System.Windows.Forms.Label label32;
        private System.Windows.Forms.Label label33;
        private System.Windows.Forms.Label lastNameErrorPerson;
        private System.Windows.Forms.TextBox idPerson;
        private System.Windows.Forms.ComboBox countryPerson;
        private System.Windows.Forms.Label label35;
        private System.Windows.Forms.Label label36;
        private System.Windows.Forms.Label firstNameErrorPerson;
        private System.Windows.Forms.Panel loginPanel;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox9;
        private System.Windows.Forms.TextBox textBox8;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button userRegisterTab;
        private System.Windows.Forms.Button userLoginTab;
        private System.Windows.Forms.Button registerPerson;
        private System.Windows.Forms.ComboBox branch;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox role;
    }
}