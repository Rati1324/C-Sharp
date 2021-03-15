using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace my_form
{
    public partial class Form_4_1 : Form
    {
        public Form_4_1()
        {
            InitializeComponent();
        }

        

        private void run_Click(object sender, EventArgs e)
        {

        }

        private void Form_4_1_Load(object sender, EventArgs e)
        {

        }

        static int i = 0, x = 178, y = 36;
        private void add_element_Click(object sender, EventArgs e)
        {
            var new_elem = new TextBox();
            new_elem.Name = i.ToString();
            new_elem.Location = new System.Drawing.Point(x, y);
            new_elem.Size = new System.Drawing.Size(27, 23);
            this.Controls.Add(new_elem);
            i++; x += 35;
            
        }
    }
}
