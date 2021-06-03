
namespace BankForm
{
    partial class RegisterPerson
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
            this.firstName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lastName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.ID = new System.Windows.Forms.TextBox();
            this.labell = new System.Windows.Forms.Label();
            this.dob = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.country = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.city = new System.Windows.Forms.ComboBox();
            this.submit = new System.Windows.Forms.Button();
            this.firstNameError = new System.Windows.Forms.Label();
            this.lastNameError = new System.Windows.Forms.Label();
            this.gender = new System.Windows.Forms.ComboBox();
            this.idError = new System.Windows.Forms.Label();
            this.dobError = new System.Windows.Forms.Label();
            this.phone = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.email = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.guarantorID = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.guarantorRelation = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.guarantorIDError = new System.Windows.Forms.Label();
            this.phoneError = new System.Windows.Forms.Label();
            this.emailError = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // firstName
            // 
            this.firstName.Location = new System.Drawing.Point(276, 53);
            this.firstName.Name = "firstName";
            this.firstName.Size = new System.Drawing.Size(168, 20);
            this.firstName.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(204, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "First Name:";
            // 
            // lastName
            // 
            this.lastName.Location = new System.Drawing.Point(276, 96);
            this.lastName.Name = "lastName";
            this.lastName.Size = new System.Drawing.Size(168, 20);
            this.lastName.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(204, 100);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "LastName:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(204, 147);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Gender:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(204, 190);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(21, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "ID:";
            // 
            // ID
            // 
            this.ID.Location = new System.Drawing.Point(276, 183);
            this.ID.Name = "ID";
            this.ID.Size = new System.Drawing.Size(168, 20);
            this.ID.TabIndex = 2;
            // 
            // labell
            // 
            this.labell.AutoSize = true;
            this.labell.Location = new System.Drawing.Point(204, 230);
            this.labell.Name = "labell";
            this.labell.Size = new System.Drawing.Size(69, 13);
            this.labell.TabIndex = 5;
            this.labell.Text = "Date of Birth:";
            // 
            // dob
            // 
            this.dob.Location = new System.Drawing.Point(276, 224);
            this.dob.Name = "dob";
            this.dob.Size = new System.Drawing.Size(168, 20);
            this.dob.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(204, 272);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(46, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Country:";
            // 
            // country
            // 
            this.country.FormattingEnabled = true;
            this.country.Location = new System.Drawing.Point(276, 265);
            this.country.Name = "country";
            this.country.Size = new System.Drawing.Size(168, 21);
            this.country.TabIndex = 9;
            this.country.SelectedIndexChanged += new System.EventHandler(this.country_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(204, 312);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(27, 13);
            this.label6.TabIndex = 8;
            this.label6.Text = "City:";
            // 
            // city
            // 
            this.city.FormattingEnabled = true;
            this.city.Location = new System.Drawing.Point(276, 304);
            this.city.Name = "city";
            this.city.Size = new System.Drawing.Size(168, 21);
            this.city.TabIndex = 9;
            // 
            // submit
            // 
            this.submit.Location = new System.Drawing.Point(207, 484);
            this.submit.Name = "submit";
            this.submit.Size = new System.Drawing.Size(75, 23);
            this.submit.TabIndex = 10;
            this.submit.Text = "Submit";
            this.submit.UseVisualStyleBackColor = true;
            this.submit.Click += new System.EventHandler(this.submit_Click);
            // 
            // firstNameError
            // 
            this.firstNameError.AutoSize = true;
            this.firstNameError.ForeColor = System.Drawing.Color.Red;
            this.firstNameError.Location = new System.Drawing.Point(275, 76);
            this.firstNameError.Name = "firstNameError";
            this.firstNameError.Size = new System.Drawing.Size(0, 13);
            this.firstNameError.TabIndex = 11;
            // 
            // lastNameError
            // 
            this.lastNameError.AutoSize = true;
            this.lastNameError.ForeColor = System.Drawing.Color.Red;
            this.lastNameError.Location = new System.Drawing.Point(275, 123);
            this.lastNameError.Name = "lastNameError";
            this.lastNameError.Size = new System.Drawing.Size(0, 13);
            this.lastNameError.TabIndex = 11;
            // 
            // gender
            // 
            this.gender.FormattingEnabled = true;
            this.gender.Location = new System.Drawing.Point(276, 139);
            this.gender.Name = "gender";
            this.gender.Size = new System.Drawing.Size(168, 21);
            this.gender.TabIndex = 12;
            // 
            // idError
            // 
            this.idError.AutoSize = true;
            this.idError.ForeColor = System.Drawing.Color.Red;
            this.idError.Location = new System.Drawing.Point(276, 208);
            this.idError.Name = "idError";
            this.idError.Size = new System.Drawing.Size(0, 13);
            this.idError.TabIndex = 13;
            // 
            // dobError
            // 
            this.dobError.AutoSize = true;
            this.dobError.BackColor = System.Drawing.Color.Transparent;
            this.dobError.ForeColor = System.Drawing.Color.Red;
            this.dobError.Location = new System.Drawing.Point(276, 248);
            this.dobError.Name = "dobError";
            this.dobError.Size = new System.Drawing.Size(0, 13);
            this.dobError.TabIndex = 14;
            // 
            // phone
            // 
            this.phone.Location = new System.Drawing.Point(276, 344);
            this.phone.Name = "phone";
            this.phone.Size = new System.Drawing.Size(168, 20);
            this.phone.TabIndex = 2;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(204, 348);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(41, 13);
            this.label7.TabIndex = 8;
            this.label7.Text = "Phone:";
            // 
            // email
            // 
            this.email.Location = new System.Drawing.Point(276, 383);
            this.email.Name = "email";
            this.email.Size = new System.Drawing.Size(168, 20);
            this.email.TabIndex = 2;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(204, 389);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(35, 13);
            this.label8.TabIndex = 8;
            this.label8.Text = "Email:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(204, 446);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(57, 13);
            this.label9.TabIndex = 8;
            this.label9.Text = "Guarantor:";
            // 
            // guarantorID
            // 
            this.guarantorID.Location = new System.Drawing.Point(359, 443);
            this.guarantorID.Name = "guarantorID";
            this.guarantorID.Size = new System.Drawing.Size(85, 20);
            this.guarantorID.TabIndex = 2;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(273, 426);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(49, 13);
            this.label10.TabIndex = 8;
            this.label10.Text = "Relation:";
            // 
            // guarantorRelation
            // 
            this.guarantorRelation.FormattingEnabled = true;
            this.guarantorRelation.Location = new System.Drawing.Point(276, 442);
            this.guarantorRelation.Name = "guarantorRelation";
            this.guarantorRelation.Size = new System.Drawing.Size(77, 21);
            this.guarantorRelation.TabIndex = 9;
            this.guarantorRelation.SelectedIndexChanged += new System.EventHandler(this.country_SelectedIndexChanged);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(356, 426);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(21, 13);
            this.label11.TabIndex = 8;
            this.label11.Text = "ID:";
            // 
            // guarantorIDError
            // 
            this.guarantorIDError.AutoSize = true;
            this.guarantorIDError.ForeColor = System.Drawing.Color.Red;
            this.guarantorIDError.Location = new System.Drawing.Point(356, 466);
            this.guarantorIDError.Name = "guarantorIDError";
            this.guarantorIDError.Size = new System.Drawing.Size(0, 13);
            this.guarantorIDError.TabIndex = 8;
            // 
            // phoneError
            // 
            this.phoneError.AutoSize = true;
            this.phoneError.ForeColor = System.Drawing.Color.Red;
            this.phoneError.Location = new System.Drawing.Point(276, 367);
            this.phoneError.Name = "phoneError";
            this.phoneError.Size = new System.Drawing.Size(0, 13);
            this.phoneError.TabIndex = 8;
            // 
            // emailError
            // 
            this.emailError.AutoSize = true;
            this.emailError.ForeColor = System.Drawing.Color.Red;
            this.emailError.Location = new System.Drawing.Point(278, 406);
            this.emailError.Name = "emailError";
            this.emailError.Size = new System.Drawing.Size(0, 13);
            this.emailError.TabIndex = 8;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(215, 9);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(233, 24);
            this.label13.TabIndex = 0;
            this.label13.Text = "Register a Physical Person";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(697, 525);
            this.Controls.Add(this.firstName);
            this.Controls.Add(this.dobError);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.idError);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.lastName);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.gender);
            this.Controls.Add(this.guarantorRelation);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.lastNameError);
            this.Controls.Add(this.country);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.firstNameError);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.ID);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.submit);
            this.Controls.Add(this.dob);
            this.Controls.Add(this.phone);
            this.Controls.Add(this.guarantorIDError);
            this.Controls.Add(this.city);
            this.Controls.Add(this.labell);
            this.Controls.Add(this.email);
            this.Controls.Add(this.emailError);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.guarantorID);
            this.Controls.Add(this.phoneError);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox firstName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox lastName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox ID;
        private System.Windows.Forms.Label labell;
        private System.Windows.Forms.DateTimePicker dob;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox country;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox city;
        private System.Windows.Forms.Button submit;
        private System.Windows.Forms.Label firstNameError;
        private System.Windows.Forms.Label lastNameError;
        private System.Windows.Forms.ComboBox gender;
        private System.Windows.Forms.Label idError;
        private System.Windows.Forms.Label dobError;
        private System.Windows.Forms.TextBox phone;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox email;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox guarantorID;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox guarantorRelation;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label guarantorIDError;
        private System.Windows.Forms.Label phoneError;
        private System.Windows.Forms.Label emailError;
        private System.Windows.Forms.Label label13;
    }
}

