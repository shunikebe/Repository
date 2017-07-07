using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace FlowersLanguage
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e){
            Dictionary<string, string> language = Data.Read();

            foreach (string s in language.Keys){

                if (s.IndexOf("(") > 0){
                    string[] c = s.Split('(', ')');

                    list.Rows.Add("削除", c[0], c[1], language[s]);
                }else{
                    list.Rows.Add("削除", s, "", language[s]);
                }

            }

        }

        private void OK_Click(object sender, EventArgs e)
        {
            int count = list.Rows.Count;
            List<string> datalist = new List<string>();

            for(int i = 0; i < count - 1; i++)
            {
                string c1 = (string)list[1, i].Value;
                string c2 = "";
                if((string)list[2, i].Value != "") { c2 = "(" + (string)list[2, i].Value + ")"; }
                string c3 = (string)list[3, i].Value;

                datalist.Add(c1+c2+',' + c3 + Environment.NewLine);


            }

            Data.Write(datalist);


        }

        private void Cell_click(object sender, DataGridViewCellEventArgs e)
        {
            if(e.ColumnIndex == list.Columns["delete"].Index)
            {
                if (DialogResult.Yes == MessageBox.Show("本当に削除しますか？","確認",MessageBoxButtons.YesNo,MessageBoxIcon.Question))
                {
                    try { list.Rows.RemoveAt(e.RowIndex); }
                    catch(InvalidOperationException ex)
                    {
                        MessageBox.Show(ex.Message, "エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);


                    }



                }



            }
        }
    }
}
