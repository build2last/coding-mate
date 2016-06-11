namespace takearest
{
    partial class record
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(record));
            this.DGV = new System.Windows.Forms.DataGridView();
            this.begin_time = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.coding_time = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.end_time = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.type = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.note = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.DGV)).BeginInit();
            this.SuspendLayout();
            // 
            // DGV
            // 
            this.DGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.begin_time,
            this.coding_time,
            this.end_time,
            this.type,
            this.note});
            this.DGV.Location = new System.Drawing.Point(2, 1);
            this.DGV.Name = "DGV";
            this.DGV.RowTemplate.Height = 23;
            this.DGV.Size = new System.Drawing.Size(573, 313);
            this.DGV.TabIndex = 0;
            // 
            // begin_time
            // 
            this.begin_time.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.begin_time.DataPropertyName = "begin_time";
            this.begin_time.HeaderText = "本次开始Coding的时间";
            this.begin_time.Name = "begin_time";
            this.begin_time.Width = 105;
            // 
            // coding_time
            // 
            this.coding_time.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.coding_time.DataPropertyName = "coding_time";
            this.coding_time.HeaderText = "Coding时长";
            this.coding_time.Name = "coding_time";
            this.coding_time.Width = 72;
            // 
            // end_time
            // 
            this.end_time.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.end_time.DataPropertyName = "end_time";
            this.end_time.HeaderText = "结束时间";
            this.end_time.Name = "end_time";
            this.end_time.Width = 61;
            // 
            // type
            // 
            this.type.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.type.DataPropertyName = "type";
            this.type.HeaderText = "这次的操作类型";
            this.type.Name = "type";
            this.type.Width = 83;
            // 
            // note
            // 
            this.note.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.note.DataPropertyName = "Note";
            this.note.HeaderText = "添加附注";
            this.note.Name = "note";
            // 
            // record
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(576, 313);
            this.Controls.Add(this.DGV);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "record";
            this.Text = "record";
            this.Load += new System.EventHandler(this.record_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DGV)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView DGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn begin_time;
        private System.Windows.Forms.DataGridViewTextBoxColumn coding_time;
        private System.Windows.Forms.DataGridViewTextBoxColumn end_time;
        private System.Windows.Forms.DataGridViewTextBoxColumn type;
        private System.Windows.Forms.DataGridViewTextBoxColumn note;
    }
}