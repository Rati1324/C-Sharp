using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Purchases
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {


            // buy a couple of normal toys

            Toy t1 = new Toy("Games console", 99.99m);

            t1.Buy();



            Toy t2 = new Toy("Lego set", 11.99m);

            t2.Buy();



            // buy a cuddly toy (saying what type it is)

            CuddlyToy t3 = new CuddlyToy("Flopsy rabbit", 5.99m);

            t3.Animal = "Rabbit";

            t3.Buy();



            string s = "";

            foreach (Toy t in Toy.Toys)

            {

                s += t.Description + "\n";

            }

            MessageBox.Show(s.Trim(), "Purchases");

        }
    }
}
