using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fishing
{
    class ClassI:Fish
    {
        public ClassI(int x, int y, int speed, int dx, System.Windows.Forms.PictureBox picture)
            : base(x,y,speed,dx, picture)
        { }

        public bool Other(bool light){
            bool flag = true;

            if (!light) { flag = false; }

            return flag;
        }

    }
}
