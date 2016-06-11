namespace takearest
{
    partial class reminder
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(reminder));
            this.mp = new AxWMPLib.AxWindowsMediaPlayer();
            this.showimg_btn = new System.Windows.Forms.Button();
            this.today_img = new System.Windows.Forms.PictureBox();
            this.morepic_btn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.mp)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.today_img)).BeginInit();
            this.SuspendLayout();
            // 
            // mp
            // 
            this.mp.Enabled = true;
            this.mp.Location = new System.Drawing.Point(498, 339);
            this.mp.Name = "mp";
            this.mp.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("mp.OcxState")));
            this.mp.Size = new System.Drawing.Size(75, 23);
            this.mp.TabIndex = 0;
            this.mp.Visible = false;
            // 
            // showimg_btn
            // 
            this.showimg_btn.Location = new System.Drawing.Point(629, 27);
            this.showimg_btn.Name = "showimg_btn";
            this.showimg_btn.Size = new System.Drawing.Size(75, 23);
            this.showimg_btn.TabIndex = 2;
            this.showimg_btn.Text = "今日福利";
            this.showimg_btn.UseVisualStyleBackColor = true;
            this.showimg_btn.Click += new System.EventHandler(this.showimg_btn_Click);
            // 
            // today_img
            // 
            this.today_img.Location = new System.Drawing.Point(-1, 0);
            this.today_img.Name = "today_img";
            this.today_img.Size = new System.Drawing.Size(100, 50);
            this.today_img.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.today_img.TabIndex = 1;
            this.today_img.TabStop = false;
            this.today_img.Visible = false;
            // 
            // morepic_btn
            // 
            this.morepic_btn.Location = new System.Drawing.Point(629, 57);
            this.morepic_btn.Name = "morepic_btn";
            this.morepic_btn.Size = new System.Drawing.Size(75, 23);
            this.morepic_btn.TabIndex = 3;
            this.morepic_btn.Text = "更多福利";
            this.morepic_btn.UseVisualStyleBackColor = true;
            this.morepic_btn.Click += new System.EventHandler(this.morepic_btn_Click);
            // 
            // reminder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(701, 741);
            this.Controls.Add(this.morepic_btn);
            this.Controls.Add(this.showimg_btn);
            this.Controls.Add(this.today_img);
            this.Controls.Add(this.mp);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "reminder";
            this.Text = "时间到啦！";
            this.Load += new System.EventHandler(this.reminder_Load);
            ((System.ComponentModel.ISupportInitialize)(this.mp)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.today_img)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private AxWMPLib.AxWindowsMediaPlayer mp;
        private System.Windows.Forms.PictureBox today_img;
        private System.Windows.Forms.Button showimg_btn;
        private System.Windows.Forms.Button morepic_btn;
    }
}