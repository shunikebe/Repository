namespace SwimmingSchedule
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
            this.seireki = new System.Windows.Forms.NumericUpDown();
            this.tuki = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.list = new System.Windows.Forms.ListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label_d = new System.Windows.Forms.Label();
            this.label_s = new System.Windows.Forms.Label();
            this.label_m = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.seireki)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tuki)).BeginInit();
            this.SuspendLayout();
            // 
            // seireki
            // 
            this.seireki.Location = new System.Drawing.Point(19, 19);
            this.seireki.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.seireki.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.seireki.Name = "seireki";
            this.seireki.Size = new System.Drawing.Size(57, 19);
            this.seireki.TabIndex = 0;
            this.seireki.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // tuki
            // 
            this.tuki.Location = new System.Drawing.Point(105, 19);
            this.tuki.Maximum = new decimal(new int[] {
            12,
            0,
            0,
            0});
            this.tuki.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.tuki.Name = "tuki";
            this.tuki.Size = new System.Drawing.Size(46, 19);
            this.tuki.TabIndex = 1;
            this.tuki.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(82, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(17, 12);
            this.label1.TabIndex = 2;
            this.label1.Text = "年";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(157, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(17, 12);
            this.label2.TabIndex = 3;
            this.label2.Text = "月";
            // 
            // list
            // 
            this.list.FormattingEnabled = true;
            this.list.ItemHeight = 12;
            this.list.Items.AddRange(new object[] {
            "ベビーコース",
            "幼児コース",
            "小学生コース",
            "中学生コース",
            "レディースコース",
            "一般コース",
            "家庭コース"});
            this.list.Location = new System.Drawing.Point(232, 19);
            this.list.Name = "list";
            this.list.Size = new System.Drawing.Size(144, 88);
            this.list.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(17, 66);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 84);
            this.label3.TabIndex = 5;
            this.label3.Text = "授業日　：\r\n\r\n\r\n開始時間：\r\n\r\n\r\n授業料　：";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(19, 169);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(357, 30);
            this.button1.TabIndex = 6;
            this.button1.Text = "表示";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label_d
            // 
            this.label_d.AutoSize = true;
            this.label_d.Location = new System.Drawing.Point(82, 66);
            this.label_d.Name = "label_d";
            this.label_d.Size = new System.Drawing.Size(35, 12);
            this.label_d.TabIndex = 7;
            this.label_d.Text = "label4";
            // 
            // label_s
            // 
            this.label_s.AutoSize = true;
            this.label_s.Location = new System.Drawing.Point(82, 101);
            this.label_s.Name = "label_s";
            this.label_s.Size = new System.Drawing.Size(35, 12);
            this.label_s.TabIndex = 8;
            this.label_s.Text = "label5";
            // 
            // label_m
            // 
            this.label_m.AutoSize = true;
            this.label_m.Location = new System.Drawing.Point(82, 137);
            this.label_m.Name = "label_m";
            this.label_m.Size = new System.Drawing.Size(35, 12);
            this.label_m.TabIndex = 9;
            this.label_m.Text = "label6";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(388, 207);
            this.Controls.Add(this.label_m);
            this.Controls.Add(this.label_s);
            this.Controls.Add(this.label_d);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.list);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tuki);
            this.Controls.Add(this.seireki);
            this.Name = "Form1";
            this.Text = "CSスイミングスクール";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.seireki)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tuki)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown seireki;
        private System.Windows.Forms.NumericUpDown tuki;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox list;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label_d;
        private System.Windows.Forms.Label label_s;
        private System.Windows.Forms.Label label_m;
    }
}

