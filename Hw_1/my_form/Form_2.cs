using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace my_form
{
    public partial class Form_2 : Form
    {
        public Form_2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            float side_a = float.Parse(a.Text); 
            float side_b = float.Parse(b.Text); 
            float side_c = float.Parse(c.Text);
            output.Text = (Tasks.Task_2.triangle(side_a, side_b, side_c) == true) ? "Triangle Can be made" : "Can't be made";
        }

        private void a_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
