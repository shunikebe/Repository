using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SwimmingSchedule
{
    public partial class Form1 : Form{
        public Form1(){
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e){
            label_d.Text = "";
            label_s.Text = "";
            label_m.Text = "";
        }

        private void button1_Click(object sender, EventArgs e){

            Course[] course = new Course[7];

            course[0] = new Course(1, 14, 1000);
            course[1] = new Course(2, 10, 1000);
            course[2] = new Course(3, 17, 800);
            course[3] = new Course(4, 19, 800);
            course[4] = new Course(5, 20, 1000);
            course[5] = new Course(6, 20, 1200);
            course[6] = new Course(0, 10, 1500);

            int n = list.SelectedIndex;
            if(n == -1) { return; }
            
            //開始時間
            label_s.Text = course[n].Start + "時";
            //授業日・授業料
            Rest(course[n].Day,course[n].Money);
        }


        private void Rest(int day,int money){
            int year, month;
            year = (int)seireki.Value;
            month = (int)tuki.Value;
            //その月の最後の日がわかる
            int dINm = DateTime.DaysInMonth(year, month);
            string jday = "" ;
            DateTime dt;
            int count = 0;
            for(int i = 1; i < dINm - 2; i++){
                dt = new DateTime(year, month, i);
                if((int)dt.DayOfWeek == day){
                    jday = jday + i + "日　";
                    count++;
                }
            }
            label_d.Text = jday;
            label_m.Text = money * count + "円";
        }




       
    }
}
