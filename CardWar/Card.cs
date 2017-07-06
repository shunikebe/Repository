using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace CardWar
{
    class Card:Button
    {
        private const int sizeW = 50,sizeH = 70;//カード大きさ
        private Color openColor = Color.White;//カード表
        private Color closeColor = Color.LightSeaGreen;//カード裏
        
        public Card(string picture)
        {
            Picture = picture;
            State = false;
            base.Size = new Size(sizeW,sizeH);
            base.BackColor = closeColor;
            base.Font = new Font("MS UI Gothic",14,FontStyle.Bold);
            base.Enabled = false;
            
        }


        public string Picture { get; set; }
        public bool State { get; set; }//表：true　裏：false

        public void Open()
        {
            State = true;
            base.BackColor = openColor;
            base.Text = Picture;
            base.Enabled = false;
            
        }

        public void Close()
        {
            State = false;
            base.BackColor = closeColor;
            base.Text = "";
            base.Enabled = true;
        }

        public void Turn(){
            if (State == true) Close();
            else Open();
        }






    }
}
