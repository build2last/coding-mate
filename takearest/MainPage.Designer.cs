namespace takearest
{
    partial class MainPage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainPage));
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
            this.JS = new System.Windows.Forms.PictureBox();
            this.add40minute = new System.Windows.Forms.Button();
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
            this.historyBox2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.JS)).BeginInit();
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
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.Name = "label2";
            // 
            // comboBox1
            // 
            resources.ApplyResources(this.comboBox1, "comboBox1");
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            resources.GetString("comboBox1.Items"),
            resources.GetString("comboBox1.Items1"),
            resources.GetString("comboBox1.Items2"),
            resources.GetString("comboBox1.Items3"),
            resources.GetString("comboBox1.Items4")});
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Enter += new System.EventHandler(this.button1_Click_1);
            this.comboBox1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.comboBox1_KeyPress);
            // 
            // bindingSource1
            // 
            this.bindingSource1.CurrentChanged += new System.EventHandler(this.bindingSource1_CurrentChanged);
            // 
            // startBtn
            // 
            resources.ApplyResources(this.startBtn, "startBtn");
            this.startBtn.Name = "startBtn";
            this.startBtn.UseVisualStyleBackColor = true;
            this.startBtn.Click += new System.EventHandler(this.button1_Click);
            // 
            // showPassedTimeLabel
            // 
            resources.ApplyResources(this.showPassedTimeLabel, "showPassedTimeLabel");
            this.showPassedTimeLabel.Name = "showPassedTimeLabel";
            // 
            // stopBtn
            // 
            resources.ApplyResources(this.stopBtn, "stopBtn");
            this.stopBtn.Name = "stopBtn";
            this.stopBtn.UseVisualStyleBackColor = true;
            this.stopBtn.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // history
            // 
            resources.ApplyResources(this.history, "history");
            this.history.Name = "history";
            this.history.UseVisualStyleBackColor = true;
            this.history.Click += new System.EventHandler(this.history_Click);
            // 
            // panel1
            // 
            resources.ApplyResources(this.panel1, "panel1");
            this.panel1.Controls.Add(this.JS);
            this.panel1.Controls.Add(this.add40minute);
            this.panel1.Controls.Add(this.cpp_btn);
            this.panel1.Controls.Add(this.java_btn);
            this.panel1.Controls.Add(this.python_btn);
            this.panel1.Controls.Add(this.history);
            this.panel1.Controls.Add(this.stopBtn);
            this.panel1.Controls.Add(this.startBtn);
            this.panel1.Name = "panel1";
            // 
            // JS
            // 
            resources.ApplyResources(this.JS, "JS");
            this.JS.Image = global::takearest.Properties.Resources.javascript;
            this.JS.Name = "JS";
            this.JS.TabStop = false;
            // 
            // add40minute
            // 
            resources.ApplyResources(this.add40minute, "add40minute");
            this.add40minute.Name = "add40minute";
            this.add40minute.UseVisualStyleBackColor = true;
            this.add40minute.Click += new System.EventHandler(this.add40minute_Click);
            // 
            // cpp_btn
            // 
            resources.ApplyResources(this.cpp_btn, "cpp_btn");
            this.cpp_btn.Image = global::takearest.Properties.Resources.cpp;
            this.cpp_btn.Name = "cpp_btn";
            this.cpp_btn.TabStop = false;
            // 
            // java_btn
            // 
            resources.ApplyResources(this.java_btn, "java_btn");
            this.java_btn.Image = global::takearest.Properties.Resources.Java;
            this.java_btn.Name = "java_btn";
            this.java_btn.TabStop = false;
            // 
            // python_btn
            // 
            resources.ApplyResources(this.python_btn, "python_btn");
            this.python_btn.Image = global::takearest.Properties.Resources.python;
            this.python_btn.Name = "python_btn";
            this.python_btn.TabStop = false;
            // 
            // historyBox
            // 
            resources.ApplyResources(this.historyBox, "historyBox");
            this.historyBox.Name = "historyBox";
            this.historyBox.Click += new System.EventHandler(this.historyBox_Click);
            // 
            // timer2
            // 
            this.timer2.Interval = 10;
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // note_text
            // 
            resources.ApplyResources(this.note_text, "note_text");
            this.note_text.Name = "note_text";
            // 
            // label_note
            // 
            resources.ApplyResources(this.label_note, "label_note");
            this.label_note.Name = "label_note";
            this.label_note.Click += new System.EventHandler(this.label3_Click);
            // 
            // type_text
            // 
            resources.ApplyResources(this.type_text, "type_text");
            this.type_text.AllowDrop = true;
            this.type_text.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.type_text.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.type_text.FormattingEnabled = true;
            this.type_text.Items.AddRange(new object[] {
            resources.GetString("type_text.Items"),
            resources.GetString("type_text.Items1"),
            resources.GetString("type_text.Items2"),
            resources.GetString("type_text.Items3"),
            resources.GetString("type_text.Items4"),
            resources.GetString("type_text.Items5"),
            resources.GetString("type_text.Items6"),
            resources.GetString("type_text.Items7")});
            this.type_text.Name = "type_text";
            // 
            // label3
            // 
            resources.ApplyResources(this.label3, "label3");
            this.label3.Name = "label3";
            // 
            // panel2
            // 
            resources.ApplyResources(this.panel2, "panel2");
            this.panel2.Controls.Add(this.comboBox1);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.type_text);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label_note);
            this.panel2.Controls.Add(this.note_text);
            this.panel2.Name = "panel2";
            // 
            // historyBox2
            // 
            resources.ApplyResources(this.historyBox2, "historyBox2");
            this.historyBox2.Name = "historyBox2";
            this.historyBox2.Click += new System.EventHandler(this.historyBox2_Click);
            // 
            // MainPage
            // 
            this.AcceptButton = this.startBtn;
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::takearest.Properties.Resources.GirlFlipHair;
            this.Controls.Add(this.historyBox2);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.historyBox);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.showPassedTimeLabel);
            this.MaximizeBox = false;
            this.Name = "MainPage";
            this.Load += new System.EventHandler(this.CodeAndRest_Load);
            this.Enter += new System.EventHandler(this.CodeAndRest_Enter);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.CodeAndRest_KeyDown);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.CodeAndRest_KeyPress);
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.JS)).EndInit();
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
        private System.Windows.Forms.PictureBox JS;
        private System.Windows.Forms.Label historyBox2;
    }
}

