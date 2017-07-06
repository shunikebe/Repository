using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace InsectCollecting
{
    class Beetle:Bug{

        private int dnum = 0;//0:上/1:左/2:下/3:右

        public Beetle(int x, int y, int speed)
            : base(x, y,speed, Properties.Resources.beetle_up){}

        public override void Move(){
            base.Visible = true;
            int x = base.Location.X;
            int y = base.Location.Y;

            switch (dnum){
                case 0://up
                    base.Image = Properties.Resources.beetle_up;
                    y -= Speed;
                    if (y < 0){
                        y = 0;
                        dnum = 1;
                    }
                    break;
                case 1://left
                    base.Image = Properties.Resources.beetle_upsidedown;
                    x -= Speed;
                    if (x < 0){
                        x = 0;
                        dnum = 2;
                    }
                    break;
                case 2://down
                    base.Image = Properties.Resources.beetle_down;
                    y += Speed;
                    if (y > Form1.ly - base.Image.Height){
                        y = Form1.ly - base.Image.Height;
                        dnum = 3;
                    }
                    break;
                case 3://right
                    base.Image = Properties.Resources.beetle_right;
                    x += Speed;
                    if (x > Form1.lx - base.Image.Width)
                    {
                        x = Form1.lx - base.Image.Width;
                        dnum = 0;
                    }
                    break;
            }
           
            base.Location = new Point(x, y);
        }

        public override void Reset(){
            base.Visible = false;
            base.Location = new Point(Form1.lx - base.Image.Width, Form1.ly - base.Image.Height);
            mflag = false;
            dnum = 0;
        }



    }
}
