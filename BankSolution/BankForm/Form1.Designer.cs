
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
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
            this.label20 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label38 = new System.Windows.Forms.Label();
            this.label49 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
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
            this.guarantorID = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.guarantorIDError = new System.Windows.Forms.Label();
            this.guarantorRelation = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.getAll = new System.Windows.Forms.Button();
            this.peopleList = new System.Windows.Forms.DataGridView();
            this.GUIDCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.firstNameCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lastNameCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IDCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cityCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.countryCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.guarantorRelCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gender = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dobCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emailCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phoneCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.guarantorIDCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.save = new System.Windows.Forms.DataGridViewButtonColumn();
            this.delete = new System.Windows.Forms.DataGridViewButtonColumn();
            this.test = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.peopleList)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Location = new System.Drawing.Point(-1, 1);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1452, 702);
            this.tabControl1.TabIndex = 19;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.label12);
            this.tabPage1.Controls.Add(this.label6);
            this.tabPage1.Controls.Add(this.role);
            this.tabPage1.Controls.Add(this.branch);
            this.tabPage1.Controls.Add(this.label30);
            this.tabPage1.Controls.Add(this.registerUser);
            this.tabPage1.Controls.Add(this.phoneUser);
            this.tabPage1.Controls.Add(this.firstNameUser);
            this.tabPage1.Controls.Add(this.passwordConfirmError);
            this.tabPage1.Controls.Add(this.phoneErrorUser);
            this.tabPage1.Controls.Add(this.dobErrorUser);
            this.tabPage1.Controls.Add(this.label17);
            this.tabPage1.Controls.Add(this.label18);
            this.tabPage1.Controls.Add(this.idErrorUser);
            this.tabPage1.Controls.Add(this.emailErrorUser);
            this.tabPage1.Controls.Add(this.label21);
            this.tabPage1.Controls.Add(this.emailUser);
            this.tabPage1.Controls.Add(this.lastNameUser);
            this.tabPage1.Controls.Add(this.label22);
            this.tabPage1.Controls.Add(this.label23);
            this.tabPage1.Controls.Add(this.cityUser);
            this.tabPage1.Controls.Add(this.genderUser);
            this.tabPage1.Controls.Add(this.dobUser);
            this.tabPage1.Controls.Add(this.label24);
            this.tabPage1.Controls.Add(this.label25);
            this.tabPage1.Controls.Add(this.lastNameErrorUser);
            this.tabPage1.Controls.Add(this.idUser);
            this.tabPage1.Controls.Add(this.countryUser);
            this.tabPage1.Controls.Add(this.label27);
            this.tabPage1.Controls.Add(this.label28);
            this.tabPage1.Controls.Add(this.firstNameErrorUser);
            this.tabPage1.Controls.Add(this.label16);
            this.tabPage1.Controls.Add(this.label15);
            this.tabPage1.Controls.Add(this.passwordConfirm);
            this.tabPage1.Controls.Add(this.passwordUser);
            this.tabPage1.Controls.Add(this.label20);
            this.tabPage1.Controls.Add(this.textBox2);
            this.tabPage1.Controls.Add(this.label38);
            this.tabPage1.Controls.Add(this.label49);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1444, 676);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "tabPage1";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(206, 569);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(32, 13);
            this.label12.TabIndex = 107;
            this.label12.Text = "Role:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(195, 534);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(44, 13);
            this.label6.TabIndex = 106;
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
            this.role.Location = new System.Drawing.Point(248, 565);
            this.role.Name = "role";
            this.role.Size = new System.Drawing.Size(168, 21);
            this.role.TabIndex = 104;
            // 
            // branch
            // 
            this.branch.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.branch.FormattingEnabled = true;
            this.branch.Items.AddRange(new object[] {
            "Branch1",
            "Branch2",
            "Branch3"});
            this.branch.Location = new System.Drawing.Point(248, 531);
            this.branch.Name = "branch";
            this.branch.Size = new System.Drawing.Size(168, 21);
            this.branch.TabIndex = 105;
            // 
            // label30
            // 
            this.label30.AutoSize = true;
            this.label30.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label30.Location = new System.Drawing.Point(249, 43);
            this.label30.Name = "label30";
            this.label30.Size = new System.Drawing.Size(145, 24);
            this.label30.TabIndex = 103;
            this.label30.Text = "User registration";
            // 
            // registerUser
            // 
            this.registerUser.Location = new System.Drawing.Point(341, 596);
            this.registerUser.Name = "registerUser";
            this.registerUser.Size = new System.Drawing.Size(75, 23);
            this.registerUser.TabIndex = 77;
            this.registerUser.Text = "Register";
            this.registerUser.UseVisualStyleBackColor = true;
            this.registerUser.Click += new System.EventHandler(this.registerUser_Click);
            // 
            // phoneUser
            // 
            this.phoneUser.Location = new System.Drawing.Point(248, 372);
            this.phoneUser.Name = "phoneUser";
            this.phoneUser.Size = new System.Drawing.Size(168, 20);
            this.phoneUser.TabIndex = 83;
            // 
            // firstNameUser
            // 
            this.firstNameUser.Location = new System.Drawing.Point(248, 80);
            this.firstNameUser.Name = "firstNameUser";
            this.firstNameUser.Size = new System.Drawing.Size(168, 20);
            this.firstNameUser.TabIndex = 78;
            // 
            // passwordConfirmError
            // 
            this.passwordConfirmError.AutoSize = true;
            this.passwordConfirmError.ForeColor = System.Drawing.Color.Red;
            this.passwordConfirmError.Location = new System.Drawing.Point(248, 521);
            this.passwordConfirmError.Name = "passwordConfirmError";
            this.passwordConfirmError.Size = new System.Drawing.Size(0, 13);
            this.passwordConfirmError.TabIndex = 93;
            // 
            // phoneErrorUser
            // 
            this.phoneErrorUser.AutoSize = true;
            this.phoneErrorUser.ForeColor = System.Drawing.Color.Red;
            this.phoneErrorUser.Location = new System.Drawing.Point(248, 396);
            this.phoneErrorUser.Name = "phoneErrorUser";
            this.phoneErrorUser.Size = new System.Drawing.Size(0, 13);
            this.phoneErrorUser.TabIndex = 92;
            // 
            // dobErrorUser
            // 
            this.dobErrorUser.AutoSize = true;
            this.dobErrorUser.BackColor = System.Drawing.Color.Transparent;
            this.dobErrorUser.ForeColor = System.Drawing.Color.Red;
            this.dobErrorUser.Location = new System.Drawing.Point(248, 275);
            this.dobErrorUser.Name = "dobErrorUser";
            this.dobErrorUser.Size = new System.Drawing.Size(0, 13);
            this.dobErrorUser.TabIndex = 102;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(215, 217);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(21, 13);
            this.label17.TabIndex = 86;
            this.label17.Text = "ID:";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(176, 83);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(60, 13);
            this.label18.TabIndex = 81;
            this.label18.Text = "First Name:";
            // 
            // idErrorUser
            // 
            this.idErrorUser.AutoSize = true;
            this.idErrorUser.ForeColor = System.Drawing.Color.Red;
            this.idErrorUser.Location = new System.Drawing.Point(248, 235);
            this.idErrorUser.Name = "idErrorUser";
            this.idErrorUser.Size = new System.Drawing.Size(0, 13);
            this.idErrorUser.TabIndex = 101;
            // 
            // emailErrorUser
            // 
            this.emailErrorUser.AutoSize = true;
            this.emailErrorUser.ForeColor = System.Drawing.Color.Red;
            this.emailErrorUser.Location = new System.Drawing.Point(250, 438);
            this.emailErrorUser.Name = "emailErrorUser";
            this.emailErrorUser.Size = new System.Drawing.Size(0, 13);
            this.emailErrorUser.TabIndex = 89;
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(209, 339);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(27, 13);
            this.label21.TabIndex = 95;
            this.label21.Text = "City:";
            // 
            // emailUser
            // 
            this.emailUser.Location = new System.Drawing.Point(248, 412);
            this.emailUser.Name = "emailUser";
            this.emailUser.Size = new System.Drawing.Size(168, 20);
            this.emailUser.TabIndex = 85;
            // 
            // lastNameUser
            // 
            this.lastNameUser.Location = new System.Drawing.Point(248, 123);
            this.lastNameUser.Name = "lastNameUser";
            this.lastNameUser.Size = new System.Drawing.Size(168, 20);
            this.lastNameUser.TabIndex = 79;
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(167, 258);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(69, 13);
            this.label22.TabIndex = 87;
            this.label22.Text = "Date of Birth:";
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(195, 375);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(41, 13);
            this.label23.TabIndex = 90;
            this.label23.Text = "Phone:";
            // 
            // cityUser
            // 
            this.cityUser.FormattingEnabled = true;
            this.cityUser.Location = new System.Drawing.Point(248, 331);
            this.cityUser.Name = "cityUser";
            this.cityUser.Size = new System.Drawing.Size(168, 21);
            this.cityUser.TabIndex = 96;
            // 
            // genderUser
            // 
            this.genderUser.FormattingEnabled = true;
            this.genderUser.Location = new System.Drawing.Point(248, 166);
            this.genderUser.Name = "genderUser";
            this.genderUser.Size = new System.Drawing.Size(168, 21);
            this.genderUser.TabIndex = 100;
            // 
            // dobUser
            // 
            this.dobUser.Location = new System.Drawing.Point(248, 251);
            this.dobUser.Name = "dobUser";
            this.dobUser.Size = new System.Drawing.Size(168, 20);
            this.dobUser.TabIndex = 88;
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Location = new System.Drawing.Point(184, 129);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(58, 13);
            this.label24.TabIndex = 80;
            this.label24.Text = "LastName:";
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Location = new System.Drawing.Point(201, 419);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(35, 13);
            this.label25.TabIndex = 91;
            this.label25.Text = "Email:";
            // 
            // lastNameErrorUser
            // 
            this.lastNameErrorUser.AutoSize = true;
            this.lastNameErrorUser.ForeColor = System.Drawing.Color.Red;
            this.lastNameErrorUser.Location = new System.Drawing.Point(247, 150);
            this.lastNameErrorUser.Name = "lastNameErrorUser";
            this.lastNameErrorUser.Size = new System.Drawing.Size(0, 13);
            this.lastNameErrorUser.TabIndex = 98;
            // 
            // idUser
            // 
            this.idUser.Location = new System.Drawing.Point(248, 210);
            this.idUser.Name = "idUser";
            this.idUser.Size = new System.Drawing.Size(168, 20);
            this.idUser.TabIndex = 84;
            // 
            // countryUser
            // 
            this.countryUser.FormattingEnabled = true;
            this.countryUser.Location = new System.Drawing.Point(248, 292);
            this.countryUser.Name = "countryUser";
            this.countryUser.Size = new System.Drawing.Size(168, 21);
            this.countryUser.TabIndex = 97;
            this.countryUser.SelectedIndexChanged += new System.EventHandler(this.countryUser_SelectedIndexChanged);
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.Location = new System.Drawing.Point(190, 300);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(46, 13);
            this.label27.TabIndex = 94;
            this.label27.Text = "Country:";
            // 
            // label28
            // 
            this.label28.AutoSize = true;
            this.label28.Location = new System.Drawing.Point(191, 174);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(45, 13);
            this.label28.TabIndex = 82;
            this.label28.Text = "Gender:";
            // 
            // firstNameErrorUser
            // 
            this.firstNameErrorUser.AutoSize = true;
            this.firstNameErrorUser.ForeColor = System.Drawing.Color.Red;
            this.firstNameErrorUser.Location = new System.Drawing.Point(247, 103);
            this.firstNameErrorUser.Name = "firstNameErrorUser";
            this.firstNameErrorUser.Size = new System.Drawing.Size(0, 13);
            this.firstNameErrorUser.TabIndex = 99;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(143, 495);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(93, 13);
            this.label16.TabIndex = 76;
            this.label16.Text = "Confirm password:";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(180, 456);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(56, 13);
            this.label15.TabIndex = 75;
            this.label15.Text = "Password:";
            // 
            // passwordConfirm
            // 
            this.passwordConfirm.Location = new System.Drawing.Point(248, 492);
            this.passwordConfirm.Name = "passwordConfirm";
            this.passwordConfirm.Size = new System.Drawing.Size(168, 20);
            this.passwordConfirm.TabIndex = 74;
            // 
            // passwordUser
            // 
            this.passwordUser.Location = new System.Drawing.Point(248, 453);
            this.passwordUser.Name = "passwordUser";
            this.passwordUser.Size = new System.Drawing.Size(168, 20);
            this.passwordUser.TabIndex = 73;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.Location = new System.Drawing.Point(249, -63);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(145, 24);
            this.label20.TabIndex = 72;
            this.label20.Text = "User registration";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(248, -26);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(168, 20);
            this.textBox2.TabIndex = 47;
            // 
            // label38
            // 
            this.label38.AutoSize = true;
            this.label38.Location = new System.Drawing.Point(176, -23);
            this.label38.Name = "label38";
            this.label38.Size = new System.Drawing.Size(60, 13);
            this.label38.TabIndex = 50;
            this.label38.Text = "First Name:";
            // 
            // label49
            // 
            this.label49.AutoSize = true;
            this.label49.ForeColor = System.Drawing.Color.Red;
            this.label49.Location = new System.Drawing.Point(247, -3);
            this.label49.Name = "label49";
            this.label49.Size = new System.Drawing.Size(0, 13);
            this.label49.TabIndex = 68;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.registerPerson);
            this.tabPage2.Controls.Add(this.phonePerson);
            this.tabPage2.Controls.Add(this.firstNamePerson);
            this.tabPage2.Controls.Add(this.phoneErrorPerson);
            this.tabPage2.Controls.Add(this.dobErrorPerson);
            this.tabPage2.Controls.Add(this.label3);
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Controls.Add(this.idErrorPerson);
            this.tabPage2.Controls.Add(this.emailErrorPerson);
            this.tabPage2.Controls.Add(this.label7);
            this.tabPage2.Controls.Add(this.emailPerson);
            this.tabPage2.Controls.Add(this.lastNamePerson);
            this.tabPage2.Controls.Add(this.label8);
            this.tabPage2.Controls.Add(this.label31);
            this.tabPage2.Controls.Add(this.cityPerson);
            this.tabPage2.Controls.Add(this.genderPerson);
            this.tabPage2.Controls.Add(this.dobPerson);
            this.tabPage2.Controls.Add(this.label32);
            this.tabPage2.Controls.Add(this.label33);
            this.tabPage2.Controls.Add(this.lastNameErrorPerson);
            this.tabPage2.Controls.Add(this.idPerson);
            this.tabPage2.Controls.Add(this.countryPerson);
            this.tabPage2.Controls.Add(this.label35);
            this.tabPage2.Controls.Add(this.label36);
            this.tabPage2.Controls.Add(this.firstNameErrorPerson);
            this.tabPage2.Controls.Add(this.guarantorID);
            this.tabPage2.Controls.Add(this.label13);
            this.tabPage2.Controls.Add(this.label11);
            this.tabPage2.Controls.Add(this.guarantorIDError);
            this.tabPage2.Controls.Add(this.guarantorRelation);
            this.tabPage2.Controls.Add(this.label10);
            this.tabPage2.Controls.Add(this.label9);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1444, 676);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // registerPerson
            // 
            this.registerPerson.Location = new System.Drawing.Point(327, 553);
            this.registerPerson.Name = "registerPerson";
            this.registerPerson.Size = new System.Drawing.Size(75, 23);
            this.registerPerson.TabIndex = 95;
            this.registerPerson.Text = "Register";
            this.registerPerson.UseVisualStyleBackColor = true;
            this.registerPerson.Click += new System.EventHandler(this.registerPerson_Click);
            // 
            // phonePerson
            // 
            this.phonePerson.Location = new System.Drawing.Point(234, 414);
            this.phonePerson.Name = "phonePerson";
            this.phonePerson.Size = new System.Drawing.Size(168, 20);
            this.phonePerson.TabIndex = 76;
            // 
            // firstNamePerson
            // 
            this.firstNamePerson.Location = new System.Drawing.Point(234, 122);
            this.firstNamePerson.Name = "firstNamePerson";
            this.firstNamePerson.Size = new System.Drawing.Size(168, 20);
            this.firstNamePerson.TabIndex = 71;
            // 
            // phoneErrorPerson
            // 
            this.phoneErrorPerson.AutoSize = true;
            this.phoneErrorPerson.ForeColor = System.Drawing.Color.Red;
            this.phoneErrorPerson.Location = new System.Drawing.Point(234, 438);
            this.phoneErrorPerson.Name = "phoneErrorPerson";
            this.phoneErrorPerson.Size = new System.Drawing.Size(0, 13);
            this.phoneErrorPerson.TabIndex = 85;
            // 
            // dobErrorPerson
            // 
            this.dobErrorPerson.AutoSize = true;
            this.dobErrorPerson.BackColor = System.Drawing.Color.Transparent;
            this.dobErrorPerson.ForeColor = System.Drawing.Color.Red;
            this.dobErrorPerson.Location = new System.Drawing.Point(234, 317);
            this.dobErrorPerson.Name = "dobErrorPerson";
            this.dobErrorPerson.Size = new System.Drawing.Size(0, 13);
            this.dobErrorPerson.TabIndex = 94;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(201, 259);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(21, 13);
            this.label3.TabIndex = 79;
            this.label3.Text = "ID:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(162, 125);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 13);
            this.label4.TabIndex = 74;
            this.label4.Text = "First Name:";
            // 
            // idErrorPerson
            // 
            this.idErrorPerson.AutoSize = true;
            this.idErrorPerson.ForeColor = System.Drawing.Color.Red;
            this.idErrorPerson.Location = new System.Drawing.Point(234, 277);
            this.idErrorPerson.Name = "idErrorPerson";
            this.idErrorPerson.Size = new System.Drawing.Size(0, 13);
            this.idErrorPerson.TabIndex = 93;
            // 
            // emailErrorPerson
            // 
            this.emailErrorPerson.AutoSize = true;
            this.emailErrorPerson.ForeColor = System.Drawing.Color.Red;
            this.emailErrorPerson.Location = new System.Drawing.Point(236, 480);
            this.emailErrorPerson.Name = "emailErrorPerson";
            this.emailErrorPerson.Size = new System.Drawing.Size(0, 13);
            this.emailErrorPerson.TabIndex = 82;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(195, 381);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(27, 13);
            this.label7.TabIndex = 87;
            this.label7.Text = "City:";
            // 
            // emailPerson
            // 
            this.emailPerson.Location = new System.Drawing.Point(234, 454);
            this.emailPerson.Name = "emailPerson";
            this.emailPerson.Size = new System.Drawing.Size(168, 20);
            this.emailPerson.TabIndex = 78;
            // 
            // lastNamePerson
            // 
            this.lastNamePerson.Location = new System.Drawing.Point(234, 165);
            this.lastNamePerson.Name = "lastNamePerson";
            this.lastNamePerson.Size = new System.Drawing.Size(168, 20);
            this.lastNamePerson.TabIndex = 72;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(153, 300);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(69, 13);
            this.label8.TabIndex = 80;
            this.label8.Text = "Date of Birth:";
            // 
            // label31
            // 
            this.label31.AutoSize = true;
            this.label31.Location = new System.Drawing.Point(181, 417);
            this.label31.Name = "label31";
            this.label31.Size = new System.Drawing.Size(41, 13);
            this.label31.TabIndex = 83;
            this.label31.Text = "Phone:";
            // 
            // cityPerson
            // 
            this.cityPerson.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cityPerson.FormattingEnabled = true;
            this.cityPerson.Location = new System.Drawing.Point(234, 373);
            this.cityPerson.Name = "cityPerson";
            this.cityPerson.Size = new System.Drawing.Size(168, 21);
            this.cityPerson.TabIndex = 88;
            // 
            // genderPerson
            // 
            this.genderPerson.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.genderPerson.FormattingEnabled = true;
            this.genderPerson.Items.AddRange(new object[] {
            "Male",
            "Female"});
            this.genderPerson.Location = new System.Drawing.Point(234, 208);
            this.genderPerson.Name = "genderPerson";
            this.genderPerson.Size = new System.Drawing.Size(168, 21);
            this.genderPerson.TabIndex = 92;
            // 
            // dobPerson
            // 
            this.dobPerson.Location = new System.Drawing.Point(234, 293);
            this.dobPerson.Name = "dobPerson";
            this.dobPerson.Size = new System.Drawing.Size(168, 20);
            this.dobPerson.TabIndex = 81;
            // 
            // label32
            // 
            this.label32.AutoSize = true;
            this.label32.Location = new System.Drawing.Point(170, 171);
            this.label32.Name = "label32";
            this.label32.Size = new System.Drawing.Size(58, 13);
            this.label32.TabIndex = 73;
            this.label32.Text = "LastName:";
            // 
            // label33
            // 
            this.label33.AutoSize = true;
            this.label33.Location = new System.Drawing.Point(187, 461);
            this.label33.Name = "label33";
            this.label33.Size = new System.Drawing.Size(35, 13);
            this.label33.TabIndex = 84;
            this.label33.Text = "Email:";
            // 
            // lastNameErrorPerson
            // 
            this.lastNameErrorPerson.AutoSize = true;
            this.lastNameErrorPerson.ForeColor = System.Drawing.Color.Red;
            this.lastNameErrorPerson.Location = new System.Drawing.Point(233, 192);
            this.lastNameErrorPerson.Name = "lastNameErrorPerson";
            this.lastNameErrorPerson.Size = new System.Drawing.Size(0, 13);
            this.lastNameErrorPerson.TabIndex = 90;
            // 
            // idPerson
            // 
            this.idPerson.Location = new System.Drawing.Point(234, 252);
            this.idPerson.Name = "idPerson";
            this.idPerson.Size = new System.Drawing.Size(168, 20);
            this.idPerson.TabIndex = 77;
            // 
            // countryPerson
            // 
            this.countryPerson.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.countryPerson.FormattingEnabled = true;
            this.countryPerson.Items.AddRange(new object[] {
            "Georgia",
            "USA"});
            this.countryPerson.Location = new System.Drawing.Point(234, 334);
            this.countryPerson.Name = "countryPerson";
            this.countryPerson.Size = new System.Drawing.Size(168, 21);
            this.countryPerson.TabIndex = 89;
            this.countryPerson.SelectedIndexChanged += new System.EventHandler(this.countryPerson_SelectedIndexChanged);
            // 
            // label35
            // 
            this.label35.AutoSize = true;
            this.label35.Location = new System.Drawing.Point(176, 342);
            this.label35.Name = "label35";
            this.label35.Size = new System.Drawing.Size(46, 13);
            this.label35.TabIndex = 86;
            this.label35.Text = "Country:";
            // 
            // label36
            // 
            this.label36.AutoSize = true;
            this.label36.Location = new System.Drawing.Point(177, 216);
            this.label36.Name = "label36";
            this.label36.Size = new System.Drawing.Size(45, 13);
            this.label36.TabIndex = 75;
            this.label36.Text = "Gender:";
            // 
            // firstNameErrorPerson
            // 
            this.firstNameErrorPerson.AutoSize = true;
            this.firstNameErrorPerson.ForeColor = System.Drawing.Color.Red;
            this.firstNameErrorPerson.Location = new System.Drawing.Point(233, 145);
            this.firstNameErrorPerson.Name = "firstNameErrorPerson";
            this.firstNameErrorPerson.Size = new System.Drawing.Size(0, 13);
            this.firstNameErrorPerson.TabIndex = 91;
            // 
            // guarantorID
            // 
            this.guarantorID.Location = new System.Drawing.Point(317, 516);
            this.guarantorID.Name = "guarantorID";
            this.guarantorID.Size = new System.Drawing.Size(85, 20);
            this.guarantorID.TabIndex = 64;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(173, 82);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(233, 24);
            this.label13.TabIndex = 63;
            this.label13.Text = "Register a Physical Person";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(314, 499);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(21, 13);
            this.label11.TabIndex = 67;
            this.label11.Text = "ID:";
            // 
            // guarantorIDError
            // 
            this.guarantorIDError.AutoSize = true;
            this.guarantorIDError.ForeColor = System.Drawing.Color.Red;
            this.guarantorIDError.Location = new System.Drawing.Point(314, 539);
            this.guarantorIDError.Name = "guarantorIDError";
            this.guarantorIDError.Size = new System.Drawing.Size(0, 13);
            this.guarantorIDError.TabIndex = 66;
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
            this.guarantorRelation.Location = new System.Drawing.Point(234, 515);
            this.guarantorRelation.Name = "guarantorRelation";
            this.guarantorRelation.Size = new System.Drawing.Size(77, 21);
            this.guarantorRelation.TabIndex = 69;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(231, 499);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(49, 13);
            this.label10.TabIndex = 68;
            this.label10.Text = "Relation:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(166, 519);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(57, 13);
            this.label9.TabIndex = 65;
            this.label9.Text = "Guarantor:";
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.test);
            this.tabPage3.Controls.Add(this.getAll);
            this.tabPage3.Controls.Add(this.peopleList);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(1444, 676);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "tabPage3";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // getAll
            // 
            this.getAll.Location = new System.Drawing.Point(16, 8);
            this.getAll.Name = "getAll";
            this.getAll.Size = new System.Drawing.Size(75, 23);
            this.getAll.TabIndex = 1;
            this.getAll.Text = "Get all";
            this.getAll.UseVisualStyleBackColor = true;
            this.getAll.Click += new System.EventHandler(this.getAll_Click);
            // 
            // peopleList
            // 
            this.peopleList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.peopleList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.GUIDCol,
            this.firstNameCol,
            this.lastNameCol,
            this.IDCol,
            this.cityCol,
            this.countryCol,
            this.guarantorRelCol,
            this.gender,
            this.dobCol,
            this.emailCol,
            this.phoneCol,
            this.guarantorIDCol,
            this.save,
            this.delete});
            this.peopleList.Location = new System.Drawing.Point(0, 73);
            this.peopleList.Name = "peopleList";
            this.peopleList.Size = new System.Drawing.Size(1441, 311);
            this.peopleList.TabIndex = 0;
            this.peopleList.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.peopleList_CellClick);
            // 
            // GUIDCol
            // 
            this.GUIDCol.HeaderText = "GUID";
            this.GUIDCol.Name = "GUIDCol";
            // 
            // firstNameCol
            // 
            this.firstNameCol.HeaderText = "First Name";
            this.firstNameCol.Name = "firstNameCol";
            // 
            // lastNameCol
            // 
            this.lastNameCol.HeaderText = "Last Name";
            this.lastNameCol.Name = "lastNameCol";
            // 
            // IDCol
            // 
            this.IDCol.HeaderText = "ID";
            this.IDCol.Name = "IDCol";
            // 
            // cityCol
            // 
            this.cityCol.HeaderText = "City";
            this.cityCol.Name = "cityCol";
            // 
            // countryCol
            // 
            this.countryCol.HeaderText = "Country";
            this.countryCol.Name = "countryCol";
            // 
            // guarantorRelCol
            // 
            this.guarantorRelCol.HeaderText = "Guarantor Relation";
            this.guarantorRelCol.Name = "guarantorRelCol";
            // 
            // gender
            // 
            this.gender.HeaderText = "Gender";
            this.gender.Name = "gender";
            // 
            // dobCol
            // 
            this.dobCol.HeaderText = "Date of Birth";
            this.dobCol.Name = "dobCol";
            // 
            // emailCol
            // 
            this.emailCol.HeaderText = "Email";
            this.emailCol.Name = "emailCol";
            // 
            // phoneCol
            // 
            this.phoneCol.HeaderText = "phone";
            this.phoneCol.Name = "phoneCol";
            // 
            // guarantorIDCol
            // 
            this.guarantorIDCol.HeaderText = "Guarantor ID";
            this.guarantorIDCol.Name = "guarantorIDCol";
            // 
            // save
            // 
            this.save.HeaderText = "Save";
            this.save.Name = "save";
            this.save.ToolTipText = "dsadsa";
            // 
            // delete
            // 
            this.delete.HeaderText = "Delete";
            this.delete.Name = "delete";
            // 
            // test
            // 
            this.test.AutoSize = true;
            this.test.Location = new System.Drawing.Point(186, 18);
            this.test.Name = "test";
            this.test.Size = new System.Drawing.Size(35, 13);
            this.test.TabIndex = 2;
            this.test.Text = "label1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1450, 711);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.peopleList)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private TabControl tabControl1;
        private TabPage tabPage1;
        private Label label20;
        private TextBox textBox2;
        private Label label38;
        private Label label49;
        private TabPage tabPage2;
        private Label label12;
        private Label label6;
        private ComboBox role;
        private ComboBox branch;
        private Label label30;
        private TextBox phoneUser;
        private TextBox firstNameUser;
        private Label passwordConfirmError;
        private Label phoneErrorUser;
        private Label dobErrorUser;
        private Label label17;
        private Label label18;
        private Label idErrorUser;
        private Label emailErrorUser;
        private Label label21;
        private TextBox emailUser;
        private TextBox lastNameUser;
        private Label label22;
        private Label label23;
        private ComboBox cityUser;
        private ComboBox genderUser;
        private DateTimePicker dobUser;
        private Label label24;
        private Label label25;
        private Label lastNameErrorUser;
        private TextBox idUser;
        private ComboBox countryUser;
        private Label label27;
        private Label label28;
        private Label firstNameErrorUser;
        private Label label16;
        private Label label15;
        private TextBox passwordConfirm;
        private TextBox passwordUser;
        private TextBox phonePerson;
        private TextBox firstNamePerson;
        private Label phoneErrorPerson;
        private Label dobErrorPerson;
        private Label label3;
        private Label label4;
        private Label idErrorPerson;
        private Label emailErrorPerson;
        private Label label7;
        private TextBox emailPerson;
        private TextBox lastNamePerson;
        private Label label8;
        private Label label31;
        private ComboBox cityPerson;
        private ComboBox genderPerson;
        private DateTimePicker dobPerson;
        private Label label32;
        private Label label33;
        private Label lastNameErrorPerson;
        private TextBox idPerson;
        private ComboBox countryPerson;
        private Label label35;
        private Label label36;
        private Label firstNameErrorPerson;
        private TextBox guarantorID;
        private Label label13;
        private Label label11;
        private Label guarantorIDError;
        private ComboBox guarantorRelation;
        private Label label10;
        private Label label9;
        private TabPage tabPage3;
        private DataGridView peopleList;
        private Button getAll;
        private Button registerUser;
        private Button registerPerson;
        private DataGridViewTextBoxColumn GUIDCol;
        private DataGridViewTextBoxColumn firstNameCol;
        private DataGridViewTextBoxColumn lastNameCol;
        private DataGridViewTextBoxColumn IDCol;
        private DataGridViewTextBoxColumn cityCol;
        private DataGridViewTextBoxColumn countryCol;
        private DataGridViewTextBoxColumn guarantorRelCol;
        private DataGridViewTextBoxColumn gender;
        private DataGridViewTextBoxColumn dobCol;
        private DataGridViewTextBoxColumn emailCol;
        private DataGridViewTextBoxColumn phoneCol;
        private DataGridViewTextBoxColumn guarantorIDCol;
        private DataGridViewButtonColumn save;
        private DataGridViewButtonColumn delete;
        private Label test;
    }
}