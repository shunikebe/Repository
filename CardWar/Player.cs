using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CardWar
{
    class Player
    {

        public int Open_num { get; set; }
        public int Point { get; set; }

        public Player(){
            Point = 0;
            Open_num = -1;
        }


    }
}
