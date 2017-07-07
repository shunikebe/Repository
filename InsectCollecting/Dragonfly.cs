using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace InsectCollecting{
    class Dragonfly:Bug{
        private double rad;
        private int dx, dy;

        public Dragonfly(int x, int y, int speed,double rad)
            : base(x, y,speed, Properties.Resources.dragonfly_right){
            this.rad = rad;
            dx = dy = 1;
        }

        public override void Move(){
            base.Visible = true;
            int x = base.Location.X;
            int y = base.Location.Y;
            x += dx*(int)(Speed * Math.Cos(rad));
            y += dy*(int)(Speed * Math.Sin(rad));
            base.Location = new Point(x, y);

            if (x > Form1.lx-base.Image.Width) { dx = -1; }
            else if (x < 0) { dx = 1; }
            if (y > Form1.ly - base.Image.Height) { dy = -1; }
            else if (y < 0) { dy = 1; }

            if (dx == 1) { base.Image = Properties.Resources.dragonfly_right; }
            else if (dx == -1) { base.Image = Properties.Resources.dragonfly_left; }
        }

        public override void Reset(){
            base.Visible = false;
            base.Location = new Point(0, 0);
            mflag = false;
            cflag = false;
        }



    }
}
