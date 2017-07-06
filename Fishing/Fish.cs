using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fishing
{
    class Fish{

        const int Lx = -310;
        const int Rx = 1000;


        private System.Windows.Forms.PictureBox picture;

        public Fish(int x,int y,int speed,int dx, System.Windows.Forms.PictureBox picture)
        {
            PositionX = x;
            PositionY = y;
            Speed = speed;
            DirectionX = dx;
            this.picture = picture;
        }

        public int PositionX { get; set; }
        public int PositionY { get; set; }//魚の場所
        public int Speed { get; set; }
        public int DirectionX { get; set; }
       


        public void Swim(out int dx,out int dy){            
            PositionX += Speed;
            if (PositionX > Rx) { PositionX = Lx; }
            dx = PositionX;
            dy = PositionY;
        }

        public void Move(int x,int y){
             picture.Location = new System.Drawing.Point(x, y); 
        }

        public bool Eat(int tx){
            bool flag = false;
            if (Math.Abs(PositionX+picture.Width - (DirectionX + tx)-15) < 15) { flag = true; }
            return flag;
        }


    }
}
