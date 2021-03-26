using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Linq;

namespace my_form
{
    public partial class Form_4_1 : Form
    {
        public Form_4_1()
        {
            InitializeComponent();
        }

        static int i = 6, x = 190, y = 36;

        static TextBox temp;

        private void Remove_Click(object sender, EventArgs e)
        {
            for (int j=Controls.Count - 1; j>=0; j--)
            {
                if (Controls[j] is TextBox && Controls[j].Name != "Num")
                {
                    Controls.Remove(Controls[j]);
                    x -= 35;
                    return;
                }
            }
        }

        private void run_Click(object sender, EventArgs e)
        {
            List<float> arr = new List<float>();
            float b = float.Parse(Num.Text);
            foreach(Control c in this.Controls)
            {
                if (c is TextBox)
                {
                    arr.Add(float.Parse(c.Text));
                }
            }
            float[] Arr = arr.ToArray();
            String output = $"Number of elements higher than" +
                $" {Num.Text}:\n{Tasks.Task_4.higher_than_b(Arr, b)}";
            outputLabel.Text = output;
        }
        private void Add_Click(object sender, EventArgs e)
        {
            var new_elem = new TextBox();
            temp = new_elem;
            new_elem.Name = "textBox" + i.ToString();
            new_elem.Location = new System.Drawing.Point(x, y);
            new_elem.Size = new System.Drawing.Size(30, 25);
            this.Controls.Add(new_elem);
            i++; x += 35;
        }


    }
}
