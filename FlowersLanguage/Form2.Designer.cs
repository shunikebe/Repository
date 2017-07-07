namespace FlowersLanguage
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.list = new System.Windows.Forms.DataGridView();
            this.OK = new System.Windows.Forms.Button();
            this.cancel = new System.Windows.Forms.Button();
            this.delete = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.flower = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.color = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.language = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.list)).BeginInit();
            this.SuspendLayout();
            // 
            // list
            // 
            this.list.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.list.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.delete,
            this.flower,
            this.color,
            this.language});
            this.list.Location = new System.Drawing.Point(12, 12);
            this.list.Name = "list";
            this.list.RowTemplate.Height = 21;
            this.list.Size = new System.Drawing.Size(722, 444);
            this.list.TabIndex = 0;
            this.list.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Cell_click);
            // 
            // OK
            // 
            this.OK.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.OK.Location = new System.Drawing.Point(177, 480);
            this.OK.Name = "OK";
            this.OK.Size = new System.Drawing.Size(154, 36);
            this.OK.TabIndex = 1;
            this.OK.Text = "OK";
            this.OK.UseVisualStyleBackColor = true;
            this.OK.Click += new System.EventHandler(this.OK_Click);
            // 
            // cancel
            // 
            this.cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cancel.Location = new System.Drawing.Point(364, 478);
            this.cancel.Name = "cancel";
            this.cancel.Size = new System.Drawing.Size(124, 37);
            this.cancel.TabIndex = 2;
            this.cancel.Text = "キャンセル";
            this.cancel.UseVisualStyleBackColor = true;
            // 
            // delete
            // 
            this.delete.HeaderText = "削除";
            this.delete.Name = "delete";
            this.delete.Width = 40;
            // 
            // flower
            // 
            this.flower.HeaderText = "花の名前(カタカナ)";
            this.flower.Name = "flower";
            this.flower.Width = 200;
            // 
            // color
            // 
            this.color.HeaderText = "色";
            this.color.Items.AddRange(new object[] {
            "赤",
            "白",
            "ピンク",
            "黄",
            "紫",
            "青",
            "黒"});
            this.color.Name = "color";
            this.color.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.color.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.color.Width = 40;
            // 
            // language
            // 
            this.language.HeaderText = "花言葉";
            this.language.Name = "language";
            this.language.Width = 400;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(749, 544);
            this.Controls.Add(this.cancel);
            this.Controls.Add(this.OK);
            this.Controls.Add(this.list);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.list)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView list;
        private System.Windows.Forms.Button OK;
        private System.Windows.Forms.Button cancel;
        private System.Windows.Forms.DataGridViewTextBoxColumn delete;
        private System.Windows.Forms.DataGridViewTextBoxColumn flower;
        private System.Windows.Forms.DataGridViewComboBoxColumn color;
        private System.Windows.Forms.DataGridViewTextBoxColumn language;
    }
}