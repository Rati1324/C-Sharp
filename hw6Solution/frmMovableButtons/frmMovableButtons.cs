using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Advanced_CSharp_exercises
{
    public partial class frmMovableButtons : Form
    {
        public frmMovableButtons()
        {
            InitializeComponent();
        }

        private void currentPos_Click(object sender, EventArgs e)
        {
            MovableButton B = new MovableButton(btn);
            B.Distance = (int)nudMovement.Value;

            MovingButton M = B.MoveDown;
            M += B.MoveRight;
            B.Move(M);
        }

        private void topLeft_Click(object sender, EventArgs e)
        {
            MovableButton B = new MovableButton(btn);
            B.Distance = (int)nudMovement.Value;

            MovingButton M = B.MoveHome;
            B.MoveHome(0);
        }
    }
}
