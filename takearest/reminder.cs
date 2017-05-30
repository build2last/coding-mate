using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace takearest
{
    public partial class reminder : Form
    {

        public reminder()
        {
            InitializeComponent();
        }

        private void reminder_Load(object sender, EventArgs e)
        {
            mp.URL = System.IO.Path.Combine(System.Environment.CurrentDirectory, "提示音频.mp3");
            mp.Ctlcontrols.play();
            //MessageBox.Show(mp.URL);
        }

        private void showimg_btn_Click(object sender, EventArgs e)
        {
            Encouragement FuliForm = new Encouragement();
            FuliForm.Show();
        }
    }
}
