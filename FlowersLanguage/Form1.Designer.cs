namespace FlowersLanguage
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
            this.color = new System.Windows.Forms.ComboBox();
            this.flower = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.search = new System.Windows.Forms.Button();
            this.edit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MS UI Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(420, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "花の名前と色を入力して検索ボタンをクリックしてください";
            // 
            // color
            // 
            this.color.FormattingEnabled = true;
            this.color.Items.AddRange(new object[] {
            "赤",
            "白",
            "ピンク",
            "黄",
            "紫",
            "青",
            "黒"});
            this.color.Location = new System.Drawing.Point(320, 85);
            this.color.Name = "color";
            this.color.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.color.Size = new System.Drawing.Size(112, 20);
            this.color.TabIndex = 1;
            // 
            // flower
            // 
            this.flower.Location = new System.Drawing.Point(16, 86);
            this.flower.Name = "flower";
            this.flower.Size = new System.Drawing.Size(298, 19);
            this.flower.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 12);
            this.label2.TabIndex = 3;
            this.label2.Text = "花の名前(カタカナ)";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(318, 71);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(17, 12);
            this.label3.TabIndex = 4;
            this.label3.Text = "色";
            // 
            // search
            // 
            this.search.Location = new System.Drawing.Point(16, 136);
            this.search.Name = "search";
            this.search.Size = new System.Drawing.Size(298, 24);
            this.search.TabIndex = 5;
            this.search.Text = "検索";
            this.search.UseVisualStyleBackColor = true;
            this.search.Click += new System.EventHandler(this.search_Click);
            // 
            // edit
            // 
            this.edit.Location = new System.Drawing.Point(320, 136);
            this.edit.Name = "edit";
            this.edit.Size = new System.Drawing.Size(112, 25);
            this.edit.TabIndex = 6;
            this.edit.Text = "追加編集";
            this.edit.UseVisualStyleBackColor = true;
            this.edit.Click += new System.EventHandler(this.edit_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(455, 190);
            this.Controls.Add(this.edit);
            this.Controls.Add(this.search);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.flower);
            this.Controls.Add(this.color);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "花言葉調べ";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox color;
        private System.Windows.Forms.TextBox flower;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button search;
        private System.Windows.Forms.Button edit;
    }
}

