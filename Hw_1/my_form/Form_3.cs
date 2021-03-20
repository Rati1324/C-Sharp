using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace my_form
{
    public partial class Form_3 : Form
    {
        public Form_3()
        {
            InitializeComponent();
        }

        private void run_Click(object sender, EventArgs e)
        {
            output.Text = (Tasks.Task_3.num_range(float.Parse(num.Text)) == true ? string.Format("Number {0} is in range 0 - 17",num.Text) : string.Format("Number {0} is not in range 0 - 17", num.Text));
        }

        private void num_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
