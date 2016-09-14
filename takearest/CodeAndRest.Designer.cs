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
            this.startBtn = new System.Windows.Forms.Button();
            this.showPassedTimeLabel = new System.Windows.Forms.Label();
            this.stopBtn = new System.Windows.Forms.Button();
            this.history = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.cpp_btn = new System.Windows.Forms.PictureBox();
            this.java_btn = new System.Windows.Forms.PictureBox();
            this.python_btn = new System.Windows.Forms.PictureBox();
            this.historyBox = new System.Windows.Forms.Label();
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.note_text = new System.Windows.Forms.TextBox();
            this.label_note = new System.Windows.Forms.Label();
            this.type_text = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.add40minute = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cpp_btn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.java_btn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.python_btn)).BeginInit();
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
            this.label1.Location = new System.Drawing.Point(198, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "分钟";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(51, 9);
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
            this.comboBox1.Location = new System.Drawing.Point(109, 6);
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
            // history
            // 
            this.history.Location = new System.Drawing.Point(0, 0);
            this.history.Name = "history";
            this.history.Size = new System.Drawing.Size(71, 26);
            this.history.TabIndex = 12;
            this.history.Text = "记录";
            this.history.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.history.UseVisualStyleBackColor = true;
            this.history.Click += new System.EventHandler(this.history_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.add40minute);
            this.panel1.Controls.Add(this.cpp_btn);
            this.panel1.Controls.Add(this.java_btn);
            this.panel1.Controls.Add(this.python_btn);
            this.panel1.Controls.Add(this.history);
            this.panel1.Controls.Add(this.stopBtn);
            this.panel1.Controls.Add(this.startBtn);
            this.panel1.Location = new System.Drawing.Point(12, 153);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(341, 177);
            this.panel1.TabIndex = 14;
            // 
            // cpp_btn
            // 
            this.cpp_btn.Image = ((System.Drawing.Image)(resources.GetObject("cpp_btn.Image")));
            this.cpp_btn.Location = new System.Drawing.Point(16, 134);
            this.cpp_btn.Name = "cpp_btn";
            this.cpp_btn.Size = new System.Drawing.Size(32, 32);
            this.cpp_btn.TabIndex = 15;
            this.cpp_btn.TabStop = false;
            // 
            // java_btn
            // 
            this.java_btn.Image = global::takearest.Properties.Resources.Java;
            this.java_btn.Location = new System.Drawing.Point(77, 134);
            this.java_btn.Name = "java_btn";
            this.java_btn.Size = new System.Drawing.Size(32, 32);
            this.java_btn.TabIndex = 14;
            this.java_btn.TabStop = false;
            // 
            // python_btn
            // 
            this.python_btn.Image = global::takearest.Properties.Resources.python;
            this.python_btn.Location = new System.Drawing.Point(136, 134);
            this.python_btn.Name = "python_btn";
            this.python_btn.Size = new System.Drawing.Size(32, 32);
            this.python_btn.TabIndex = 13;
            this.python_btn.TabStop = false;
            // 
            // historyBox
            // 
            this.historyBox.AutoSize = true;
            this.historyBox.Font = new System.Drawing.Font("微软雅黑 Light", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.historyBox.Location = new System.Drawing.Point(265, -1);
            this.historyBox.Name = "historyBox";
            this.historyBox.Size = new System.Drawing.Size(51, 20);
            this.historyBox.TabIndex = 16;
            this.historyBox.Text = "record";
            this.historyBox.Click += new System.EventHandler(this.historyBox_Click);
            // 
            // timer2
            // 
            this.timer2.Interval = 10;
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // note_text
            // 
            this.note_text.Location = new System.Drawing.Point(109, 74);
            this.note_text.Multiline = true;
            this.note_text.Name = "note_text";
            this.note_text.Size = new System.Drawing.Size(77, 21);
            this.note_text.TabIndex = 3;
            // 
            // label_note
            // 
            this.label_note.AutoSize = true;
            this.label_note.Location = new System.Drawing.Point(46, 74);
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
            this.type_text.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.type_text.FormattingEnabled = true;
            this.type_text.Items.AddRange(new object[] {
            "Python",
            "JAVA",
            "c++",
            "Web",
            "Android",
            "C"});
            this.type_text.Location = new System.Drawing.Point(109, 37);
            this.type_text.Name = "type_text";
            this.type_text.Size = new System.Drawing.Size(121, 25);
            this.type_text.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 44);
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
            this.panel2.Location = new System.Drawing.Point(390, 153);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(252, 148);
            this.panel2.TabIndex = 20;
            // 
            // add40minute
            // 
            this.add40minute.Location = new System.Drawing.Point(211, 134);
            this.add40minute.Name = "add40minute";
            this.add40minute.Size = new System.Drawing.Size(75, 23);
            this.add40minute.TabIndex = 16;
            this.add40minute.Text = "再续40分钟";
            this.add40minute.UseVisualStyleBackColor = true;
            this.add40minute.Click += new System.EventHandler(this.add40minute_Click);
            // 
            // CodeAndRest
            // 
            this.AcceptButton = this.startBtn;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(642, 331);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.historyBox);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.showPassedTimeLabel);
            this.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "CodeAndRest";
            this.Text = "请您注意身体";
            this.Load += new System.EventHandler(this.CodeAndRest_Load);
            this.Enter += new System.EventHandler(this.CodeAndRest_Enter);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.CodeAndRest_KeyDown);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.CodeAndRest_KeyPress);
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.cpp_btn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.java_btn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.python_btn)).EndInit();
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
        private System.Windows.Forms.Button startBtn;
        private System.Windows.Forms.Label showPassedTimeLabel;
        private System.Windows.Forms.Button stopBtn;
        private System.Windows.Forms.Button history;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label historyBox;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.TextBox note_text;
        private System.Windows.Forms.Label label_note;
        private System.Windows.Forms.ComboBox type_text;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox python_btn;
        private System.Windows.Forms.PictureBox cpp_btn;
        private System.Windows.Forms.PictureBox java_btn;
        private System.Windows.Forms.Button add40minute;
    }
}

