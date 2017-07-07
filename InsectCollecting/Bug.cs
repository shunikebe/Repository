using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace InsectCollecting
{
    abstract class Bug:PictureBox
    {
        public int X { get; set; }
        public int Y { get; set; }
        public int Speed { get; set; }
        public Image image { get; set; }
        public bool mflag { get; set; }
        public bool cflag{ get; set; }

        public Bug(int x,int y,int speed,Image image){
            X = x;
            Y = y;
            Speed = speed;
            base.Location = new Point(x, y);
            base.Image = image;
            base.Visible = false;
            base.SizeMode = PictureBoxSizeMode.AutoSize;
            mflag = false;
            cflag = false;
        }

        public abstract void Move();
        public abstract void Reset();

        public void Hit(){
            mflag = false;
            cflag = true;
            base.Visible = false;


        }


            















    }
}
