using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Fishing
{
    public partial class Form1 : Form
    {
        private ClassA an;
        private ClassI iwa;
        private ClassU utu;

        private bool Gameflag = false;
        private bool light = true;
        private int count = 0;
        private int Acount = 0;
        private int point = 0;

        private void Form1_Load(object sender, EventArgs e)
        {
            an = new ClassA(390, 390, 1,265, ankou);
            iwa = new ClassI(32, 40, 2,365,iwashi);
            utu = new ClassU(160, 175, 1,752, utubo);
        }


        public Form1()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e){
            if (Gameflag){
                int x, y;
                an.Swim(out x, out y);
                an.Move(x, y);
                iwa.Swim(out x, out y);
                iwa.Move(x, y);
                if (light){
                    utu.Swim(out x, out y);
                    utu.Move(x, y);
                }


                count++;
                Acount++;
                if (light) {
                    BackColor = Color.Blue;
                    if(count > 62.5 * 10){
                        light = false;
                        count = 0;
                    }
                }
                else {
                    BackColor = Color.Navy;
                    if (count > 62.5 * 5){
                        light = true;
                        count = 0;
                    }
                }

                if(Acount > 62.5 * 60){//ゲーム終了
                    Gameflag = false;
                    count = Acount = 0;
                    an.Move(390, 390);
                    iwa.Move(32, 40);
                    utu.Move(160, 175);
                    light = true;
                    BackColor = Color.Blue;
                }

                //ポイントの描写
                label1.Text = "point : " + point;
                //残り時間
                label2.Text = "time : " +(int)( Acount * 16 / 1000);

            }
        }

        private void button1_Click(object sender, EventArgs e){
            Gameflag = true;
            point = 0;
        }

        private void Form1_KeyPress(object sender, KeyPressEventArgs e)
        {   
            if (Gameflag){
                if (int.Parse(e.KeyChar.ToString())<=3){
                    if( iwa.Eat(26) && iwa.Other(light)){
                        iwa.Move(-500, 40);
                        iwa.PositionX = -500;
                        point += 10;
                    }
                }
                if (int.Parse(e.KeyChar.ToString()) >= 0){
                    if (an.Eat(37)){
                        an.Move(-500, 40);
                        an.PositionX = -500;
                        point += 30;
                    }
                }
                if (int.Parse(e.KeyChar.ToString()) >= 7)
                {
                    if (utu.Eat(48) && utu.Other(light))
                    {
                        utu.Move(-500, 40);
                        utu.PositionX = -500;
                        point += 100;
                    }
                }              


            }
            

        }
    }
}
