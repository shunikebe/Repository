namespace WeekOfDay
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
            this.label1 = new System.Windows.Forms.Label();
            this.nen = new System.Windows.Forms.TextBox();
            this.tuki = new System.Windows.Forms.NumericUpDown();
            this.hi = new System.Windows.Forms.NumericUpDown();
            this.yobi = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.tuki)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hi)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(49, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(161, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "西暦年　　　　　月　  　　　　　日";
            // 
            // nen
            // 
            this.nen.Location = new System.Drawing.Point(39, 52);
            this.nen.Name = "nen";
            this.nen.Size = new System.Drawing.Size(50, 19);
            this.nen.TabIndex = 1;
            // 
            // tuki
            // 
            this.tuki.Location = new System.Drawing.Point(124, 53);
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
            this.tuki.Size = new System.Drawing.Size(47, 19);
            this.tuki.TabIndex = 2;
            this.tuki.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // hi
            // 
            this.hi.Location = new System.Drawing.Point(193, 52);
            this.hi.Maximum = new decimal(new int[] {
            31,
            0,
            0,
            0});
            this.hi.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.hi.Name = "hi";
            this.hi.Size = new System.Drawing.Size(47, 19);
            this.hi.TabIndex = 3;
            this.hi.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // yobi
            // 
            this.yobi.AutoSize = true;
            this.yobi.Location = new System.Drawing.Point(278, 53);
            this.yobi.Name = "yobi";
            this.yobi.Size = new System.Drawing.Size(35, 12);
            this.yobi.TabIndex = 4;
            this.yobi.Text = "label2";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(40, 99);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(273, 29);
            this.button1.TabIndex = 5;
            this.button1.Text = "曜日算出";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(459, 261);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.yobi);
            this.Controls.Add(this.hi);
            this.Controls.Add(this.tuki);
            this.Controls.Add(this.nen);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tuki)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hi)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox nen;
        private System.Windows.Forms.NumericUpDown tuki;
        private System.Windows.Forms.NumericUpDown hi;
        private System.Windows.Forms.Label yobi;
        private System.Windows.Forms.Button button1;
    }
}

