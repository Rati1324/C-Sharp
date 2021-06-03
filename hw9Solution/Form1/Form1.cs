using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Form1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        
        private void append_Click(object sender, EventArgs e)
        {
            StringBuilder S = new StringBuilder();
            S.Capacity = 50;
            if (textBox2.Text.Length + textBox1.Text.Length > 50 )
            {
                throw new Exception("Max capacity is 50");
            }

            S.Append(textBox1.Text);
            S.Append(' ');
            S.Append(textBox2.Text);
            result.Text = S.ToString();
        }
    }
}
