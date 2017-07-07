using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace InsectCollecting
{
    class Butterfly:Bug{
        
        private double rad;
        private int dx, dy;

        public Butterfly(int x, int y, int speed, double rad)
            : base(x, y,speed, Properties.Resources.butterfly_right){
            this.rad = rad;
            dx = 1; 
            dy = -1;
        }

        public override void Move(){
            base.Visible = true;
            int x = base.Location.X;
            int y = base.Location.Y;
            x += dx * (int)(Speed * Math.Cos(rad));
            y += dy * (int)(Speed * Math.Sin(rad));

            int vx = new Random().Next(0, 2);
            x -= vx*dx;
            int vy = new Random().Next(-3, 1);
            y += vy;

            base.Location = new Point(x, y);

           

            if (x > Form1.lx - base.Image.Width) { dx = -1; }
            else if (x < 0) { dx = 1; }
            if (y > Form1.ly - base.Image.Height) { dy = -1; }
            else if (y < 0) { dy = 1; }

            if (dx == 1) { base.Image = Properties.Resources.butterfly_right; }
            else if (dx == -1) { base.Image = Properties.Resources.butterfly_left; }
        }

        public override void Reset(){
            base.Visible = false;
            base.Location = new Point(0, 420);
            mflag = false;
            cflag = false;
        }









    }
}
