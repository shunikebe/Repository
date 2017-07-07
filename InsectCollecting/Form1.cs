using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InsectCollecting{
    
    public partial class Form1 : Form
    {

        public const int lx = 1000;
        public const int ly = 500;

        private Bug[] bug;
        private Random r;

        private int count = 0;
        private int Acount = 0;

        private int point = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e){
            bug = new Bug[61];
            r = new Random();

            SuspendLayout();

            for(int a = 0; a < bug.Length; a++){              
                switch (r.Next(0, 3)){
                    case 0:
                        bug[a] = new Dragonfly(0, 0, r.Next(5, 10), r.Next(15, 75) * Math.PI / 180);
                        break;
                    case 1:
                        bug[a] = new Butterfly(0, 420, r.Next(3,7), r.Next(45, 65) * Math.PI / 180);
                        break;
                    case 2:
                        bug[a] = new Beetle(933, 420, r.Next(10, 20));
                        break;
                }

                bug[a].Name = "bug" +  a.ToString();
                bug[a].Click += new EventHandler(Bug_click);

            }

            Controls.AddRange(bug);
            ResumeLayout(false);
        }

        private void Bug_click(object sender,EventArgs e) {
            int n = int.Parse(((PictureBox)sender).Name.Substring(3));
            bug[n].Hit();
            point++;
            score.Text = "得点：" + point ;
        }


        private void start_Click(object sender, EventArgs e){
            start.Enabled = false;
            count = Acount = point = 0;
            score.Text = "得点：" + point;
            time.Text = "残り時間：60秒";
            for (int a = 0; a < bug.Length; a++){
                bug[a].Reset();
            }

            }

        private void timer1_Tick(object sender, EventArgs e){
            if (!start.Enabled){
                if(!bug[count].cflag)bug[count].mflag = true;
                for (int a = 0; a < bug.Length; a++){
                    if (bug[a].mflag) bug[a].Move();
                }
                Acount++;
                if (Acount % 50 == 0) {
                    count++;
                    time.Text = "残り時間：" + (60 -count)  + "秒";
                }
                if(Acount> 50 * 60){
                    start.Enabled = true;
                    for (int a = 0; a < bug.Length; a++){
                        if (bug[a].mflag) bug[a].Reset();
                    }
                    
                }



            }

        }
    }
}
