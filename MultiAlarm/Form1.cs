using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MultiAlarm
{
    public partial class Form1 : Form
    {

        private int[] arh = { 0,0,0};
        private int[] arm = { 0, 0, 0 };

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e){
            Set abc = new Set();
            string hs = "", ms="";
            if (abc.ShowDialog() == DialogResult.OK) {
                if (abc.h < 10) hs = "0";
                if (abc.m < 10) ms = "0";
                checkBox1.Text = hs + abc.h +":" + ms + abc.m;
                arh[0] = abc.h;
                arm[0] = abc.m;
            }           
            abc.Dispose();
        }

        private void button3_Click(object sender, EventArgs e){
            Set abc = new Set();
            string hs = "", ms = "";
            if (abc.ShowDialog() == DialogResult.OK)
            {
                if (abc.h < 10) hs = "0";
                if (abc.m < 10) ms = "0";
                checkBox4.Text = hs + abc.h + ":" + ms + abc.m;
                arh[1] = abc.h;
                arm[1] = abc.m;
            }
            abc.Dispose();
        }

        private void button2_Click(object sender, EventArgs e){
            Set abc = new Set();
            string hs = "", ms = "";
            if (abc.ShowDialog() == DialogResult.OK)
            {
                if (abc.h < 10) hs = "0";
                if (abc.m < 10) ms = "0";
                checkBox5.Text = hs + abc.h + ":" + ms + abc.m;
                arh[2] = abc.h;
                arm[2] = abc.m;
            }
            abc.Dispose();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            labelt.Text = DateTime.Now.ToString("T");
        }

       
        private void timer1_Tick(object sender, EventArgs e)
        {
            Form2 f2 = new Form2();

            labelt.Text = DateTime.Now.ToString("T");

            if (checkBox1.Checked){
                if(arh[0] == DateTime.Now.Hour && arm[0] == DateTime.Now.Minute){
                    checkBox1.Checked = false;
                    if (f2.ShowDialog() == DialogResult.OK){}
                    f2.Dispose();
                }
            }
            if (checkBox4.Checked){
                if (arh[1] == DateTime.Now.Hour && arm[1] == DateTime.Now.Minute){
                    checkBox4.Checked = false;
                    if (f2.ShowDialog() == DialogResult.OK){}
                    f2.Dispose();
                }
            }
            if (checkBox5.Checked){
                if (arh[2] == DateTime.Now.Hour && arm[2] == DateTime.Now.Minute){
                    checkBox5.Checked = false;
                    if (f2.ShowDialog() == DialogResult.OK){}
                    f2.Dispose();
                }
            }



        }





        
    }
}
