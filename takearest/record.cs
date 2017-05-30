using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using System.Xml;

namespace takearest
{
    public partial class record : Form 
    {
        string RECORD_FILE = Application.StartupPath + @"\codeRecord.xml";//历史文件路径
        Dictionary<string, int> code_type_chart = new Dictionary<string, int>();
        public record()
        {
            InitializeComponent();
            statistic();
        }

        private void record_Load(object sender, EventArgs e)
        {
            try {
                DataSet dds = new DataSet();
                dds.ReadXml(RECORD_FILE);
                this.DGV.DataSource = dds.Tables[0].DefaultView;
                CreateChart();
            }
            catch(Exception ex)
            {
                MessageBox.Show("还没有记录呢！");
                this.Close();
            }
            
        }

        void statistic()
        {
            string path = this.RECORD_FILE;
            if (File.Exists(path))
            {
                try
                {
                    XmlDocument xml_doc = new XmlDocument();
                    xml_doc.Load(path);
                    string str = string.Empty;
                    XmlNodeList work_list = xml_doc.SelectNodes("/history/your_work");

                    if (work_list != null)
                    {
                        foreach (XmlNode a_note in work_list)
                        {
                            string codeType = a_note["type"].InnerText;
                            int costTime = Convert.ToInt32(a_note["coding_time"].InnerText.Split(' ')[0]);
                            if (!code_type_chart.ContainsKey(codeType))
                                code_type_chart.Add(codeType, costTime);
                            else
                            {
                                code_type_chart[codeType] += costTime;
                            }
                        }
                    }

                }
                catch (Exception es)
                {
                    MessageBox.Show(es.Message);
                }
            }
        }

        void CreateChart()
        {
            List<string> xValues = new List<string>();
            List<int> yValues = new List<int>();
            foreach (KeyValuePair<string, int> kvp in code_type_chart)
            {
                xValues.Add(kvp.Key);
                yValues.Add(kvp.Value);
            }
            //ChartAreas,Series,Legends 基本設定-------------------------------------------------
            Chart Chart1 = new Chart();
            Chart1.ChartAreas.Add("ChartArea1"); //圖表區域集合
            Chart1.Legends.Add("Legends1"); //圖例集合說明
            Chart1.Series.Add("Series1"); //數據序列集合

            //設定 Chart-------------------------------------------------------------------------
            Chart1.Width = 770;
            Chart1.Height = 400;
            Title title = new Title();
            title.Text = "你的编程时间分布";
            title.Alignment = ContentAlignment.MiddleCenter;
            title.Font = new System.Drawing.Font("微软雅黑", 14F, FontStyle.Bold);
            Chart1.Titles.Add(title);

            //設定 ChartArea1--------------------------------------------------------------------
            Chart1.ChartAreas["ChartArea1"].Area3DStyle.Enable3D = true;
            Chart1.ChartAreas[0].AxisX.Interval = 1;

            //設定 Legends-------------------------------------------------------------------------                
            //Chart1.Legends["Legends1"].DockedToChartArea = "ChartArea1"; //顯示在圖表內
            Chart1.Legends["Legends1"].Docking = Docking.Top; //自訂顯示位置
            //背景色
            Chart1.Legends["Legends1"].BackColor = Color.FromArgb(235, 235, 235);
            //斜線背景
            Chart1.Legends["Legends1"].BackHatchStyle = ChartHatchStyle.DarkDownwardDiagonal;
            Chart1.Legends["Legends1"].BorderWidth = 1;
            Chart1.Legends["Legends1"].BorderColor = Color.FromArgb(200, 200, 200);

            //設定 Series1-----------------------------------------------------------------------
            Chart1.Series["Series1"].ChartType = SeriesChartType.Pie;
            //Chart1.Series["Series1"].ChartType = SeriesChartType.Doughnut;
            Chart1.Series["Series1"].Points.DataBindXY(xValues, yValues);
            Chart1.Series["Series1"].LegendText = "#VALX:    [ #PERCENT{P1} ]"; //X軸 + 百分比
            Chart1.Series["Series1"].Label = "#VALX\n#PERCENT{P1}"; //X軸 + 百分比
            //Chart1.Series["Series1"].LabelForeColor = Color.FromArgb(0, 90, 255); //字體顏色
            //字體設定
            Chart1.Series["Series1"].Font = new System.Drawing.Font("Trebuchet MS", 10, System.Drawing.FontStyle.Bold);
            Chart1.Series["Series1"].Points.FindMaxByValue().LabelForeColor = Color.Red;
            //Chart1.Series["Series1"].Points.FindMaxByValue().Color = Color.Red;
            //Chart1.Series["Series1"].Points.FindMaxByValue()["Exploded"] = "true";
            Chart1.Series["Series1"].BorderColor = Color.FromArgb(255, 101, 101, 101);

            //Chart1.Series["Series1"]["DoughnutRadius"] = "80"; // ChartType為Doughnut時，Set Doughnut hole size
            //Chart1.Series["Series1"]["PieLabelStyle"] = "Inside"; //數值顯示在圓餅內
            //Chart1.Series["Series1"]["PieLabelStyle"] = "Outside"; //數值顯示在圓餅外
            Chart1.Series["Series1"]["PieLabelStyle"] = "Disabled"; //不顯示數值
            //設定圓餅效果，除 Default 外其他效果3D不適用
            Chart1.Series["Series1"]["PieDrawingStyle"] = "Default";
            //Chart1.Series["Series1"]["PieDrawingStyle"] = "SoftEdge";
            //Chart1.Series["Series1"]["PieDrawingStyle"] = "Concave";

            //Random rnd = new Random();  //亂數產生區塊顏色
            //foreach (DataPoint point in Chart1.Series["Series1"].Points)
            //{
            //    //pie 顏色
            //    point.Color = Color.FromArgb(150, rnd.Next(0, 255), rnd.Next(0, 255), rnd.Next(0, 255)); 
            //}
            this.Controls.Add(Chart1);
        }

        private void show_his_Click(object sender, EventArgs e)
        {
            if (this.DGV.Visible == true)
            {
                this.DGV.Visible = false;
                this.show_his.Text = "显示历史记录";
            }
            else
            {
                this.DGV.Visible = true;
                this.show_his.Text = "折叠历史记录";
            } 
        }
    }
}
