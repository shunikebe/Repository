using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WeekOfDay
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            yobi.Text = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int y, m, d;
            int w = -1;//曜日用
            bool flag = true;           
            if(int.TryParse(nen.Text,out y) == true)
            {
                if (y < 0) {
                    yobi.Text = "西暦を正しく入れてください";
                    return;
                }
            }else
            {
                yobi.Text = "西暦を正しく入れてください";
                return;
            }

            m = (int)tuki.Value;
            d = (int)hi.Value;

            switch (m)
            {
                case 1:
                case 3:
                case 5:
                case 7:
                case 8:
                case 10:
                case 12:
                    //if (d > 31) flag = false;
                    break;
                case 2:
                    if (y % 4 == 0 && d > 29) flag = false;
                    if (y % 4 != 0 && d > 28) flag = false;
                    break;
                case 4:
                case 6:
                case 9:
                case 11:
                    if (d > 30) flag = false;
                    break;
                default:
                    flag = false;
                    break;
            }

            if (flag)
            {
                int a=0, b=0;//計算用の変数
                if(m ==1 || m == 2)
                {
                    a = -1;
                    b = 12;
                }
                w = (5*(y+a)/4 - (y+a)/100 + (y+a)/400 + (26 * (m+b) + 16)/10 + d) % 7;
                
            }


            switch (w)
            {
                case 0:
                    yobi.Text = "日曜日です";
                    break;
                case 1:
                    yobi.Text = "月曜日です";
                    break;
                case 2:
                    yobi.Text = "火曜日です";
                    break;
                case 3:
                    yobi.Text = "水曜日です";
                    break;
                case 4:
                    yobi.Text = "木曜日です";
                    break;
                case 5:
                    yobi.Text = "金曜日です";
                    break;
                case 6:
                    yobi.Text = "土曜日です";
                    break;
                default:
                    yobi.Text = "ありえない日付です";
                    break;
            }
        }

        
    }
}
