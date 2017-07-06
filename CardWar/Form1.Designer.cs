namespace CardWar
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
            this.start = new System.Windows.Forms.Button();
            this.CPMp = new System.Windows.Forms.Label();
            this.playerp = new System.Windows.Forms.Label();
            this.explain = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // start
            // 
            this.start.Location = new System.Drawing.Point(12, 12);
            this.start.Name = "start";
            this.start.Size = new System.Drawing.Size(75, 23);
            this.start.TabIndex = 0;
            this.start.Text = "再挑戦";
            this.start.UseVisualStyleBackColor = true;
            this.start.Click += new System.EventHandler(this.start_Click);
            // 
            // CPMp
            // 
            this.CPMp.AutoSize = true;
            this.CPMp.Location = new System.Drawing.Point(19, 55);
            this.CPMp.Name = "CPMp";
            this.CPMp.Size = new System.Drawing.Size(29, 12);
            this.CPMp.TabIndex = 1;
            this.CPMp.Text = "CPM";
            // 
            // playerp
            // 
            this.playerp.AutoSize = true;
            this.playerp.Location = new System.Drawing.Point(19, 250);
            this.playerp.Name = "playerp";
            this.playerp.Size = new System.Drawing.Size(36, 12);
            this.playerp.TabIndex = 2;
            this.playerp.Text = "player";
            // 
            // explain
            // 
            this.explain.AutoSize = true;
            this.explain.Location = new System.Drawing.Point(134, 23);
            this.explain.Name = "explain";
            this.explain.Size = new System.Drawing.Size(41, 12);
            this.explain.TabIndex = 3;
            this.explain.Text = "explain";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MS UI Gothic", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label1.Location = new System.Drawing.Point(172, 147);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(183, 64);
            this.label1.TabIndex = 4;
            this.label1.Text = "label1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1059, 418);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.explain);
            this.Controls.Add(this.playerp);
            this.Controls.Add(this.CPMp);
            this.Controls.Add(this.start);
            this.Name = "Form1";
            this.Text = "戦争ゲーム";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button start;
        private System.Windows.Forms.Label CPMp;
        private System.Windows.Forms.Label playerp;
        private System.Windows.Forms.Label explain;
        private System.Windows.Forms.Label label1;
    }
}

