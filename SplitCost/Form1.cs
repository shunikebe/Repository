using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SplitCost
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int money,num;
            double addtax;
            const double tax = 0.08;

            money = int.Parse(text_m.Text);
            num = int.Parse(text_p.Text);
            addtax = money * (1 + tax);
            money = (int)addtax;
            label_s.Text = (money / num) + "円";
            label_a.Text = (money % num) + "円";


        }
    }
}
