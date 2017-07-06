using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CardWar
{
    public partial class Form1 : Form
    {
        private Card[] cards;
        private Player player;
        private CPM cpm;
     
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Create(ref cards);
            player = new Player();
            cpm = new CPM();
         
            SuspendLayout();
            const int offsetX = 100, offsetY = 50;
            for (int i = 0; i < cards.Length; i++) {
                cards[i].Name = "card" + i;
                int sw = cards[i].Size.Width;
                int sh = cards[i].Size.Height;

                cards[i].Location = new Point(offsetX + i / 2 * sw,
                    offsetY + i % 2 * (sh+130));

                if (i % 2 == 1) cards[i].Click += new EventHandler(card_Click);
                //else cards[i].Enabled = false;

            }
            Controls.AddRange(cards);
            ResumeLayout(false);

            //start
            Shuffle(cards);
            foreach (Card c in cards) { c.Close(); }
            start.Enabled = false;
            explain.Text = "自分のカードをクリックしてください";
            label1.Text = "";
            CPMp.Text = "CPM\n得点：0";
            playerp.Text = "player\n得点：0";

        }

        private void start_Click(object sender, EventArgs e){
            Shuffle(cards);
            foreach(Card c in cards){c.Close();}
            player.Open_num = -1;
            player.Point = 0;
            cpm.Open_num = -1;
            cpm.Point = 0;
            start.Enabled = false;
            explain.Text = "自分のカードをクリックしてください";
            label1.Text = "";
            CPMp.Text = "CPM\n得点：0";
            playerp.Text = "player\n得点：0";
        }

        private void Create(ref Card[] cards){
            string[] picture = 
                { "A", "2", "3", "4", "5", "6", "7", "8", "9", "10", "J", "Q", "K" };
            cards = new Card[picture.Length * 2];
            for(int i = 0,j = 0; i < cards.Length; i+=2,j++){
                cards[i] = new Card(picture[j]);
                cards[i+1] = new Card(picture[j]);
            }
        }

        private void Shuffle(Card[] cards){
            Random r = new Random();
            int n = cards.Length - 1;
            while (n > 0){
                int w = r.Next(0, n);
                string s = cards[n].Picture;
                cards[n].Picture = cards[w].Picture;
                cards[w].Picture = s;
                n--;
            }
        } 
        
        private void Fight(string pst,string cst){
            if (pst == "A") { pst = "14"; }
            else if (pst == "J") { pst = "11"; }
            else if (pst == "Q") { pst = "12"; }
            else if (pst == "K") { pst = "13"; }

            if (cst == "A") { cst = "14"; }
            else if (cst == "J") { cst = "11"; }
            else if (cst == "Q") { cst = "12"; }
            else if (cst == "K") { cst = "13"; }

            int np, nc;
            np = int.Parse(pst);
            nc = int.Parse(cst);

            if (np > nc){
                player.Point += 2;
                explain.Text = "あなたの勝ちです。自分のカードをクリックしてください";
            }else if (np < nc){
                cpm.Point += 2;
                explain.Text = "あなたの負けです。自分のカードをクリックしてください";
            }else{
                player.Point += 1;
                cpm.Point += 1;
                explain.Text = "引き分けです。自分のカードをクリックしてください";
            }
            CPMp.Text = "CPM\n得点："+cpm.Point;
            playerp.Text = "player\n得点："+player.Point;
        }

        private bool AOCheck(Card[] cards){
            foreach(Card c in cards){
                if (!c.State) return false;
            }
            return true;
        }

        private void card_Click(object sender,EventArgs e) {
            //カードの色をもとに戻す
            if(player.Open_num != -1) { cards[player.Open_num].BackColor = Color.White; }
            if(cpm.Open_num != -1) { cards[cpm.Open_num].BackColor = Color.White; }
            
            int np = int.Parse(((Button)sender).Name.Substring(4));
            //カードをめくる
            cards[np].Open();
            cards[np].BackColor = Color.LightSkyBlue;
            player.Open_num = np;

            //CPMがカードを選ぶ
            int nc = 0;
            do {//数字を選ぶ
                nc = cpm.Select();
                //選べるカードだったら抜ける
            } while (cards[nc].State);
            cards[nc].Open();
            cards[nc].BackColor = Color.LightSkyBlue;
            cpm.Open_num = nc;

            Fight(cards[np].Picture,cards[nc].Picture);

            if (AOCheck(cards)){
                start.Enabled = true;
                explain.Text = "";
                if (player.Point > cpm.Point){
                    label1.Text = "あなたの勝ちです";
                }else if (player.Point < cpm.Point){
                    label1.Text = "あなたの負けです";
                }else{
                    label1.Text = "引き分けです";
                }
            }



        }

        
    }
}
