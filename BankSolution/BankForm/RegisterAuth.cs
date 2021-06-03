using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BankForm
{
    public partial class RegisterAuth : Form
    {
        public RegisterAuth()
        {
            InitializeComponent();
            this.IsMdiContainer = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            RegisterPerson f2 = new RegisterPerson();
            f2.MdiParent = this;
            f2.Show();
            f2.Parent.Hide();
        }
    }
}
