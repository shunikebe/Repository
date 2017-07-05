using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SwimmingSchedule
{
    class Course{
        private int day;
        private int start;
        private int money;

        public Course(int d,int s,int m){
            Day = d;
            Start = s;
            Money = m;
        }
        public int Day { get; private set;}
        public int Start { get; private set; }
        public int Money { get; private set; }
    }
}
