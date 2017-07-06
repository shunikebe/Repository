using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CardWar
{
    class CPM:Player
    {
        public CPM() :base() { }

        public int Select(){
            int n = 0;
            Random abc = new Random();
            n = abc.Next(0, 13) * 2;
            return n ;
        }

    }
}
