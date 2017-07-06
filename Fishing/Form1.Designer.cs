namespace Fishing
{
    partial class Form1
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージ リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.ankou = new System.Windows.Forms.PictureBox();
            this.hitode = new System.Windows.Forms.PictureBox();
            this.isoginchaku = new System.Windows.Forms.PictureBox();
            this.iwashi = new System.Windows.Forms.PictureBox();
            this.utubo = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.button1 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.ankou)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hitode)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.isoginchaku)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iwashi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.utubo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // ankou
            // 
            this.ankou.Image = ((System.Drawing.Image)(resources.GetObject("ankou.Image")));
            this.ankou.Location = new System.Drawing.Point(390, 390);
            this.ankou.Name = "ankou";
            this.ankou.Size = new System.Drawing.Size(205, 205);
            this.ankou.TabIndex = 0;
            this.ankou.TabStop = false;
            // 
            // hitode
            // 
            this.hitode.Image = ((System.Drawing.Image)(resources.GetObject("hitode.Image")));
            this.hitode.Location = new System.Drawing.Point(742, 548);
            this.hitode.Name = "hitode";
            this.hitode.Size = new System.Drawing.Size(81, 82);
            this.hitode.TabIndex = 1;
            this.hitode.TabStop = false;
            // 
            // isoginchaku
            // 
            this.isoginchaku.Image = ((System.Drawing.Image)(resources.GetObject("isoginchaku.Image")));
            this.isoginchaku.Location = new System.Drawing.Point(32, 509);
            this.isoginchaku.Name = "isoginchaku";
            this.isoginchaku.Size = new System.Drawing.Size(103, 104);
            this.isoginchaku.TabIndex = 2;
            this.isoginchaku.TabStop = false;
            // 
            // iwashi
            // 
            this.iwashi.Image = ((System.Drawing.Image)(resources.GetObject("iwashi.Image")));
            this.iwashi.Location = new System.Drawing.Point(32, 40);
            this.iwashi.Name = "iwashi";
            this.iwashi.Size = new System.Drawing.Size(156, 55);
            this.iwashi.TabIndex = 3;
            this.iwashi.TabStop = false;
            // 
            // utubo
            // 
            this.utubo.Image = ((System.Drawing.Image)(resources.GetObject("utubo.Image")));
            this.utubo.Location = new System.Drawing.Point(160, 175);
            this.utubo.Name = "utubo";
            this.utubo.Size = new System.Drawing.Size(302, 180);
            this.utubo.TabIndex = 4;
            this.utubo.TabStop = false;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 16;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(32, 7);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(83, 27);
            this.button1.TabIndex = 5;
            this.button1.Text = "スタート";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(365, 40);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(26, 55);
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(752, 208);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(48, 109);
            this.pictureBox2.TabIndex = 7;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(265, 433);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(37, 84);
            this.pictureBox3.TabIndex = 8;
            this.pictureBox3.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MS UI Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(133, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 19);
            this.label1.TabIndex = 9;
            this.label1.Text = "point : ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("MS UI Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(237, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 19);
            this.label2.TabIndex = 10;
            this.label2.Text = "time :  ";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Highlight;
            this.ClientSize = new System.Drawing.Size(984, 642);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.utubo);
            this.Controls.Add(this.iwashi);
            this.Controls.Add(this.isoginchaku);
            this.Controls.Add(this.hitode);
            this.Controls.Add(this.ankou);
            this.KeyPreview = true;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Form1_KeyPress);
            ((System.ComponentModel.ISupportInitialize)(this.ankou)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hitode)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.isoginchaku)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iwashi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.utubo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox ankou;
        private System.Windows.Forms.PictureBox hitode;
        private System.Windows.Forms.PictureBox isoginchaku;
        private System.Windows.Forms.PictureBox iwashi;
        private System.Windows.Forms.PictureBox utubo;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

