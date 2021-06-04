
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
            this.submit = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.guarantorID = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.guarantorRelation = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.guarantorIDError = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
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
            this.registerUser = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.registerPers = new System.Windows.Forms.Button();
            this.label30 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.passwordConfirmError = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.label22 = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label24 = new System.Windows.Forms.Label();
            this.label25 = new System.Windows.Forms.Label();
            this.label26 = new System.Windows.Forms.Label();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.label27 = new System.Windows.Forms.Label();
            this.label28 = new System.Windows.Forms.Label();
            this.label29 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // submit
            // 
            this.submit.Location = new System.Drawing.Point(133, 496);
            this.submit.Name = "submit";
            this.submit.Size = new System.Drawing.Size(75, 23);
            this.submit.TabIndex = 10;
            this.submit.Text = "Submit";
            this.submit.UseVisualStyleBackColor = true;
            this.submit.Click += new System.EventHandler(this.submit_Click);
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
            this.guarantorRelation.FormattingEnabled = true;
            this.guarantorRelation.Location = new System.Drawing.Point(134, 455);
            this.guarantorRelation.Name = "guarantorRelation";
            this.guarantorRelation.Size = new System.Drawing.Size(77, 21);
            this.guarantorRelation.TabIndex = 9;
            this.guarantorRelation.SelectedIndexChanged += new System.EventHandler(this.country_SelectedIndexChanged);
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
            // panel1
            // 
            this.panel1.Controls.Add(this.phonePerson);
            this.panel1.Controls.Add(this.firstNamePerson);
            this.panel1.Controls.Add(this.phoneErrorPerson);
            this.panel1.Controls.Add(this.dobErrorPerson);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.idErrorPerson);
            this.panel1.Controls.Add(this.emailErrorPerson);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.emailPerson);
            this.panel1.Controls.Add(this.lastNamePerson);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label31);
            this.panel1.Controls.Add(this.cityPerson);
            this.panel1.Controls.Add(this.genderPerson);
            this.panel1.Controls.Add(this.dobPerson);
            this.panel1.Controls.Add(this.label32);
            this.panel1.Controls.Add(this.label33);
            this.panel1.Controls.Add(this.lastNameErrorPerson);
            this.panel1.Controls.Add(this.idPerson);
            this.panel1.Controls.Add(this.countryPerson);
            this.panel1.Controls.Add(this.label35);
            this.panel1.Controls.Add(this.label36);
            this.panel1.Controls.Add(this.firstNameErrorPerson);
            this.panel1.Controls.Add(this.registerUser);
            this.panel1.Controls.Add(this.guarantorID);
            this.panel1.Controls.Add(this.label13);
            this.panel1.Controls.Add(this.label11);
            this.panel1.Controls.Add(this.guarantorIDError);
            this.panel1.Controls.Add(this.guarantorRelation);
            this.panel1.Controls.Add(this.submit);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Location = new System.Drawing.Point(179, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(485, 524);
            this.panel1.TabIndex = 15;
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
            this.cityPerson.FormattingEnabled = true;
            this.cityPerson.Location = new System.Drawing.Point(134, 313);
            this.cityPerson.Name = "cityPerson";
            this.cityPerson.Size = new System.Drawing.Size(168, 21);
            this.cityPerson.TabIndex = 56;
            // 
            // genderPerson
            // 
            this.genderPerson.FormattingEnabled = true;
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
            this.countryPerson.FormattingEnabled = true;
            this.countryPerson.Location = new System.Drawing.Point(134, 274);
            this.countryPerson.Name = "countryPerson";
            this.countryPerson.Size = new System.Drawing.Size(168, 21);
            this.countryPerson.TabIndex = 57;
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
            // registerUser
            // 
            this.registerUser.Location = new System.Drawing.Point(341, 3);
            this.registerUser.Name = "registerUser";
            this.registerUser.Size = new System.Drawing.Size(129, 23);
            this.registerUser.TabIndex = 15;
            this.registerUser.Text = "Register a user";
            this.registerUser.UseVisualStyleBackColor = true;
            this.registerUser.Click += new System.EventHandler(this.registerUser_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.registerPers);
            this.panel2.Controls.Add(this.label30);
            this.panel2.Controls.Add(this.button1);
            this.panel2.Controls.Add(this.textBox3);
            this.panel2.Controls.Add(this.textBox4);
            this.panel2.Controls.Add(this.passwordConfirmError);
            this.panel2.Controls.Add(this.label12);
            this.panel2.Controls.Add(this.label14);
            this.panel2.Controls.Add(this.label17);
            this.panel2.Controls.Add(this.label18);
            this.panel2.Controls.Add(this.label19);
            this.panel2.Controls.Add(this.label20);
            this.panel2.Controls.Add(this.label21);
            this.panel2.Controls.Add(this.textBox5);
            this.panel2.Controls.Add(this.textBox6);
            this.panel2.Controls.Add(this.label22);
            this.panel2.Controls.Add(this.label23);
            this.panel2.Controls.Add(this.comboBox1);
            this.panel2.Controls.Add(this.comboBox2);
            this.panel2.Controls.Add(this.dateTimePicker1);
            this.panel2.Controls.Add(this.label24);
            this.panel2.Controls.Add(this.label25);
            this.panel2.Controls.Add(this.label26);
            this.panel2.Controls.Add(this.textBox7);
            this.panel2.Controls.Add(this.comboBox3);
            this.panel2.Controls.Add(this.label27);
            this.panel2.Controls.Add(this.label28);
            this.panel2.Controls.Add(this.label29);
            this.panel2.Controls.Add(this.label16);
            this.panel2.Controls.Add(this.label15);
            this.panel2.Controls.Add(this.textBox2);
            this.panel2.Controls.Add(this.textBox1);
            this.panel2.Location = new System.Drawing.Point(182, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(485, 520);
            this.panel2.TabIndex = 16;
            // 
            // registerPers
            // 
            this.registerPers.Location = new System.Drawing.Point(338, 6);
            this.registerPers.Name = "registerPers";
            this.registerPers.Size = new System.Drawing.Size(129, 23);
            this.registerPers.TabIndex = 40;
            this.registerPers.Text = "Register a person";
            this.registerPers.UseVisualStyleBackColor = true;
            this.registerPers.Click += new System.EventHandler(this.registerPers_Click);
            // 
            // label30
            // 
            this.label30.AutoSize = true;
            this.label30.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label30.Location = new System.Drawing.Point(138, 5);
            this.label30.Name = "label30";
            this.label30.Size = new System.Drawing.Size(136, 24);
            this.label30.TabIndex = 39;
            this.label30.Text = "Register a user";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(137, 481);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Register";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(137, 332);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(168, 20);
            this.textBox3.TabIndex = 20;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(137, 40);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(168, 20);
            this.textBox4.TabIndex = 15;
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
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.ForeColor = System.Drawing.Color.Red;
            this.label12.Location = new System.Drawing.Point(137, 356);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(0, 13);
            this.label12.TabIndex = 29;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.BackColor = System.Drawing.Color.Transparent;
            this.label14.ForeColor = System.Drawing.Color.Red;
            this.label14.Location = new System.Drawing.Point(137, 235);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(0, 13);
            this.label14.TabIndex = 38;
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
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.ForeColor = System.Drawing.Color.Red;
            this.label19.Location = new System.Drawing.Point(137, 195);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(0, 13);
            this.label19.TabIndex = 37;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.ForeColor = System.Drawing.Color.Red;
            this.label20.Location = new System.Drawing.Point(139, 398);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(0, 13);
            this.label20.TabIndex = 26;
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
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(137, 372);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(168, 20);
            this.textBox5.TabIndex = 22;
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(137, 83);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(168, 20);
            this.textBox6.TabIndex = 16;
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
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(137, 291);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(168, 21);
            this.comboBox1.TabIndex = 32;
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(137, 126);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(168, 21);
            this.comboBox2.TabIndex = 36;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(137, 211);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(168, 20);
            this.dateTimePicker1.TabIndex = 25;
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
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.ForeColor = System.Drawing.Color.Red;
            this.label26.Location = new System.Drawing.Point(136, 110);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(0, 13);
            this.label26.TabIndex = 34;
            // 
            // textBox7
            // 
            this.textBox7.Location = new System.Drawing.Point(137, 170);
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(168, 20);
            this.textBox7.TabIndex = 21;
            // 
            // comboBox3
            // 
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Location = new System.Drawing.Point(137, 252);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(168, 21);
            this.comboBox3.TabIndex = 33;
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
            // label29
            // 
            this.label29.AutoSize = true;
            this.label29.ForeColor = System.Drawing.Color.Red;
            this.label29.Location = new System.Drawing.Point(136, 63);
            this.label29.Name = "label29";
            this.label29.Size = new System.Drawing.Size(0, 13);
            this.label29.TabIndex = 35;
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
            this.label15.Location = new System.Drawing.Point(69, 413);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(56, 13);
            this.label15.TabIndex = 1;
            this.label15.Text = "Password:";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(137, 452);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(168, 20);
            this.textBox2.TabIndex = 0;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(137, 410);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(168, 20);
            this.textBox1.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(836, 578);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button submit;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox guarantorID;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox guarantorRelation;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label guarantorIDError;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.ComboBox comboBox3;
        private System.Windows.Forms.Label label27;
        private System.Windows.Forms.Label label28;
        private System.Windows.Forms.Label label29;
        private System.Windows.Forms.Label label30;
        private System.Windows.Forms.Label passwordConfirmError;
        private System.Windows.Forms.Button registerPers;
        private System.Windows.Forms.Button registerUser;
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
    }
}

