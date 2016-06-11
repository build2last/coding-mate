using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace takearest
{
    public partial class record : Form
    {
        string RECORD_FILE = Application.StartupPath + @"\codeRecord.xml";//历史文件路径
        public record()
        {
            InitializeComponent();
        }

        private void record_Load(object sender, EventArgs e)
        {
            try {
                DataSet dds = new DataSet();
                dds.ReadXml(RECORD_FILE);
                this.DGV.DataSource = dds.Tables[0].DefaultView;
            }
            catch(Exception ex)
            {
                MessageBox.Show("还没有记录呢！");
            }
        }
    }
}
