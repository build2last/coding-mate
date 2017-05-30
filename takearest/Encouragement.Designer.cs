namespace takearest
{
    partial class Encouragement
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Encouragement));
            this.morepic_btn = new System.Windows.Forms.Button();
            this.showimg_btn = new System.Windows.Forms.Button();
            this.fuli_pbox = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.fuli_pbox)).BeginInit();
            this.SuspendLayout();
            // 
            // morepic_btn
            // 
            this.morepic_btn.Location = new System.Drawing.Point(388, 57);
            this.morepic_btn.Name = "morepic_btn";
            this.morepic_btn.Size = new System.Drawing.Size(75, 23);
            this.morepic_btn.TabIndex = 5;
            this.morepic_btn.Text = "更多福利";
            this.morepic_btn.UseVisualStyleBackColor = true;
            this.morepic_btn.Click += new System.EventHandler(this.morepic_btn_Click);
            // 
            // showimg_btn
            // 
            this.showimg_btn.Location = new System.Drawing.Point(388, 27);
            this.showimg_btn.Name = "showimg_btn";
            this.showimg_btn.Size = new System.Drawing.Size(75, 23);
            this.showimg_btn.TabIndex = 4;
            this.showimg_btn.Text = "今日福利";
            this.showimg_btn.UseVisualStyleBackColor = true;
            this.showimg_btn.Click += new System.EventHandler(this.showimg_btn_Click_1);
            // 
            // fuli_pbox
            // 
            this.fuli_pbox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.fuli_pbox.Location = new System.Drawing.Point(0, 0);
            this.fuli_pbox.Name = "fuli_pbox";
            this.fuli_pbox.Size = new System.Drawing.Size(464, 641);
            this.fuli_pbox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.fuli_pbox.TabIndex = 0;
            this.fuli_pbox.TabStop = false;
            // 
            // Encouragement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(464, 641);
            this.Controls.Add(this.morepic_btn);
            this.Controls.Add(this.showimg_btn);
            this.Controls.Add(this.fuli_pbox);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Encouragement";
            this.Text = "Encouragement";
            this.Load += new System.EventHandler(this.Encouragement_Load);
            ((System.ComponentModel.ISupportInitialize)(this.fuli_pbox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox fuli_pbox;
        private System.Windows.Forms.Button morepic_btn;
        private System.Windows.Forms.Button showimg_btn;
    }
}