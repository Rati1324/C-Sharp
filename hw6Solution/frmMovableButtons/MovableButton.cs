using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Advanced_CSharp_exercises
{
    public delegate void MovingButton(int distance);
    class MovableButton
    {
        Button button = null;
        int distance;
        public int Distance
        {
            get => distance;
            set => distance = value;
        }
        public MovableButton(Button b)
        {
            // we know which button this is
            button = b;
        }

        public void MoveDown(int distanceDown)
        {
            // move button left a bit
            button.Top = button.Top + distanceDown;
        }
        public void MoveRight(int distanceRight)
        {
            // move button left a bit
            button.Left = button.Left + distanceRight;
        }

        public void Move(MovingButton m)
        {
            m(distance);
        }

        public void MoveHome(int blank)
        {
            button.Top = 0;
            button.Left = 0;
        }
       

    }
}
