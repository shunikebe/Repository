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
    public partial class Set : Form
    {

        internal int h, m;
        public Set()
        {
            InitializeComponent();
        }



        private void button1_Click(object sender, EventArgs e)
        {            
            h = (int)numericUpDown1.Value;
            m = (int)numericUpDown2.Value;

        }

        private void Set_Load(object sender, EventArgs e)
        {
            numericUpDown1.Value = DateTime.Now.Hour;
            numericUpDown2.Value = DateTime.Now.Minute;
        }
    }
}
