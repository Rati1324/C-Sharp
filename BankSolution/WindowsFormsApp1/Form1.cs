using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        List<Panel> listPanel = new List<Panel>();
        int index = 1;
        public Form1()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            panel2.Visible = true;
        }
        private void button2_Click(object sender, EventArgs e)
        {
            panel2.BringToFront();

        }
        private void Form1_Load(object sender, EventArgs e)
        {
            listPanel.Add(panel1);
            listPanel.Add(panel2);
            //listPanel[index].BringToFront();
        }

        
    }
}
