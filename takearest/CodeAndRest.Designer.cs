namespace takearest
{
    partial class CodeAndRest
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CodeAndRest));
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.mp = new AxWMPLib.AxWindowsMediaPlayer();
            this.startBtn = new System.Windows.Forms.Button();
            this.showPassedTimeLabel = new System.Windows.Forms.Label();
            this.stopBtn = new System.Windows.Forms.Button();
            this.cppstart = new System.Windows.Forms.Button();
            this.javastart = new System.Windows.Forms.Button();
            this.pythonstart = new System.Windows.Forms.Button();
            this.history = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.historyBox = new System.Windows.Forms.Label();
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.note_text = new System.Windows.Forms.TextBox();
            this.label_note = new System.Windows.Forms.Label();
            this.type_text = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mp)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(158, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "分钟";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(32, 8);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "编程";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "10",
            "30",
            "45",
            "60",
            "120"});
            this.comboBox1.Location = new System.Drawing.Point(73, 4);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(77, 25);
            this.comboBox1.TabIndex = 1;
            this.comboBox1.Text = "10";
            this.comboBox1.Enter += new System.EventHandler(this.button1_Click_1);
            this.comboBox1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.comboBox1_KeyPress);
            // 
            // bindingSource1
            // 
            this.bindingSource1.CurrentChanged += new System.EventHandler(this.bindingSource1_CurrentChanged);
            // 
            // mp
            // 
            this.mp.Enabled = true;
            this.mp.Location = new System.Drawing.Point(567, 307);
            this.mp.Name = "mp";
            this.mp.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("mp.OcxState")));
            this.mp.Size = new System.Drawing.Size(75, 23);
            this.mp.TabIndex = 13;
            this.mp.Visible = false;
            // 
            // startBtn
            // 
            this.startBtn.Location = new System.Drawing.Point(0, 37);
            this.startBtn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.startBtn.Name = "startBtn";
            this.startBtn.Size = new System.Drawing.Size(71, 33);
            this.startBtn.TabIndex = 4;
            this.startBtn.Text = "开始计时";
            this.startBtn.UseVisualStyleBackColor = true;
            this.startBtn.Click += new System.EventHandler(this.button1_Click);
            // 
            // showPassedTimeLabel
            // 
            this.showPassedTimeLabel.AutoSize = true;
            this.showPassedTimeLabel.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.showPassedTimeLabel.Location = new System.Drawing.Point(408, 304);
            this.showPassedTimeLabel.Name = "showPassedTimeLabel";
            this.showPassedTimeLabel.Size = new System.Drawing.Size(65, 17);
            this.showPassedTimeLabel.TabIndex = 5;
            this.showPassedTimeLabel.Text = "totaltime";
            // 
            // stopBtn
            // 
            this.stopBtn.Location = new System.Drawing.Point(0, 93);
            this.stopBtn.Name = "stopBtn";
            this.stopBtn.Size = new System.Drawing.Size(71, 29);
            this.stopBtn.TabIndex = 8;
            this.stopBtn.Text = "结束计时";
            this.stopBtn.UseVisualStyleBackColor = true;
            this.stopBtn.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // cppstart
            // 
            this.cppstart.Location = new System.Drawing.Point(9, 145);
            this.cppstart.Name = "cppstart";
            this.cppstart.Size = new System.Drawing.Size(75, 23);
            this.cppstart.TabIndex = 9;
            this.cppstart.Text = "c++";
            this.cppstart.UseVisualStyleBackColor = true;
            // 
            // javastart
            // 
            this.javastart.Location = new System.Drawing.Point(126, 145);
            this.javastart.Name = "javastart";
            this.javastart.Size = new System.Drawing.Size(75, 23);
            this.javastart.TabIndex = 10;
            this.javastart.Text = "java";
            this.javastart.UseVisualStyleBackColor = true;
            // 
            // pythonstart
            // 
            this.pythonstart.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pythonstart.Location = new System.Drawing.Point(242, 145);
            this.pythonstart.Name = "pythonstart";
            this.pythonstart.Size = new System.Drawing.Size(75, 23);
            this.pythonstart.TabIndex = 11;
            this.pythonstart.Text = "python";
            this.pythonstart.UseVisualStyleBackColor = true;
            // 
            // history
            // 
            this.history.Location = new System.Drawing.Point(0, 0);
            this.history.Name = "history";
            this.history.Size = new System.Drawing.Size(45, 23);
            this.history.TabIndex = 12;
            this.history.Text = "记录";
            this.history.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.history.UseVisualStyleBackColor = true;
            this.history.Click += new System.EventHandler(this.history_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.history);
            this.panel1.Controls.Add(this.pythonstart);
            this.panel1.Controls.Add(this.javastart);
            this.panel1.Controls.Add(this.cppstart);
            this.panel1.Controls.Add(this.stopBtn);
            this.panel1.Controls.Add(this.startBtn);
            this.panel1.Location = new System.Drawing.Point(12, 153);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(341, 177);
            this.panel1.TabIndex = 14;
            // 
            // historyBox
            // 
            this.historyBox.AutoSize = true;
            this.historyBox.Font = new System.Drawing.Font("幼圆", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.historyBox.Location = new System.Drawing.Point(265, -1);
            this.historyBox.Name = "historyBox";
            this.historyBox.Size = new System.Drawing.Size(55, 14);
            this.historyBox.TabIndex = 16;
            this.historyBox.Text = "record";
            this.historyBox.Click += new System.EventHandler(this.historyBox_Click);
            // 
            // timer2
            // 
            this.timer2.Interval = 50;
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // note_text
            // 
            this.note_text.Location = new System.Drawing.Point(73, 70);
            this.note_text.Multiline = true;
            this.note_text.Name = "note_text";
            this.note_text.Size = new System.Drawing.Size(77, 21);
            this.note_text.TabIndex = 3;
            // 
            // label_note
            // 
            this.label_note.AutoSize = true;
            this.label_note.Location = new System.Drawing.Point(32, 74);
            this.label_note.Name = "label_note";
            this.label_note.Size = new System.Drawing.Size(37, 17);
            this.label_note.TabIndex = 18;
            this.label_note.Text = "Note";
            this.label_note.Click += new System.EventHandler(this.label3_Click);
            // 
            // type_text
            // 
            this.type_text.AllowDrop = true;
            this.type_text.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.type_text.FormattingEnabled = true;
            this.type_text.Items.AddRange(new object[] {
            "Python",
            "JAVA",
            "c++",
            "Web",
            "Android"});
            this.type_text.Location = new System.Drawing.Point(100, 36);
            this.type_text.Name = "type_text";
            this.type_text.Size = new System.Drawing.Size(121, 25);
            this.type_text.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 44);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 17);
            this.label3.TabIndex = 19;
            this.label3.Text = "Coding Type";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.comboBox1);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.type_text);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label_note);
            this.panel2.Controls.Add(this.note_text);
            this.panel2.Location = new System.Drawing.Point(411, 153);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(231, 148);
            this.panel2.TabIndex = 20;
            // 
            // CodeAndRest
            // 
            this.AcceptButton = this.startBtn;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::takearest.Properties.Resources._0a7408387a09cdc3e275c0b33c46bcd27563184410b89_DdaKlt_fw658;
            this.ClientSize = new System.Drawing.Size(642, 331);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.historyBox);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.mp);
            this.Controls.Add(this.showPassedTimeLabel);
            this.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "CodeAndRest";
            this.Text = "大人请注意身体";
            this.Load += new System.EventHandler(this.CodeAndRest_Load);
            this.Enter += new System.EventHandler(this.CodeAndRest_Enter);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.CodeAndRest_KeyDown);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.CodeAndRest_KeyPress);
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mp)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.BindingSource bindingSource1;
        private AxWMPLib.AxWindowsMediaPlayer mp;
        private System.Windows.Forms.Button startBtn;
        private System.Windows.Forms.Label showPassedTimeLabel;
        private System.Windows.Forms.Button stopBtn;
        private System.Windows.Forms.Button cppstart;
        private System.Windows.Forms.Button javastart;
        private System.Windows.Forms.Button pythonstart;
        private System.Windows.Forms.Button history;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label historyBox;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.TextBox note_text;
        private System.Windows.Forms.Label label_note;
        private System.Windows.Forms.ComboBox type_text;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel2;
    }
}

