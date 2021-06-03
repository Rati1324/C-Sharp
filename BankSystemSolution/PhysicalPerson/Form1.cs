using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PhysicalPerson
{
    public partial class Form1 : Form
    {
        public Dictionary<string, List<string>> Cities = new Dictionary<string, List<string>>()
        {
            {"Georgia", new List<string>{ "Tbilisi" }},
            {"USA", new List<string>{ "Illinois", "Philadelphia" }},
        };
        public Form1()
        {
            InitializeComponent();
            country.Items.Add("Georgia");
            country.Items.Add("USA");
            country.SelectedIndex = 0;

        }

        private void country_SelectedIndexChanged(object sender, EventArgs e)
        {
            city.Items.Clear();
            foreach (var elem in Cities[country.Text])
            {
                city.Items.Add(elem);
            }
            city.SelectedIndex = 0;
        }
    }
}
