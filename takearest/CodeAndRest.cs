//如果发现程序数据溢出了，那么说明已经执行了 2^31/60/60/24/365=68.096259766616年之久，向您致敬


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
using System.Media;
using System.Xml;

namespace takearest
{
    public partial class CodeAndRest : Form
    {
        int passedTime = 0;//过去的时间，单位秒。
        int mysetTime;//设置的时间，单位 秒
        int totalCodeTime = 0;// seconds
        string RECORD_FILE=Application.StartupPath + @"\codeRecord.xml";//记录文件路径
        string code_type = string.Empty;//记录这波编码的类型
        string note = string.Empty;

        public CodeAndRest()
        {
            InitializeComponent();
        }


        private void CodeAndRest_Load(object sender, EventArgs e)
        {
            load_file();
            //控件属性初始化
            timer2.Start();
            this.panel1.BackColor = Color.Transparent;
            this.panel2.BackColor = Color.Transparent;
            label1.BackColor = Color.Transparent;
            label2.BackColor = Color.Transparent;
            showPassedTimeLabel.BackColor= Color.Transparent;
            // this.historyBox.BackColor = Color.Transparent;

            showRecord();
        }
     
        //<summary>
        // 创建记录文件codeRecord.xml
        //</summary>
        public void load_file()
        {
            string path = RECORD_FILE;
            if (!File.Exists(path))
                {
                    XmlDocument xmlDoc = new XmlDocument();
                    XmlNode node = xmlDoc.CreateXmlDeclaration("1.0", "utf-8", "");
                    xmlDoc.AppendChild(node);
                    XmlNode root = xmlDoc.CreateElement("history");
                    xmlDoc.AppendChild(root);
                    try
                    {
                        xmlDoc.Save(path);
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine(e.Message);
                    }
                }
        }

        ///<summary>
        /// 编程时间记录信息处理，返回秒
        /// </summary>
        int getaCodeTime(string data)
        {
            string[] strs = data.Split(' ');
            return Convert.ToInt32(strs[0].Trim().ToString());
        }

        string time2fomat(string t)
        {
            string[] strs = t.Split(' ');
            int time=Convert.ToInt32(strs[0].Trim().ToString());
            return "「" + (time / 60).ToString() + "分" + (time % 60).ToString() + "秒」";
        }

        public string second_time_fomat(int seconds_sum)
        {
            string time_str = "0";
            if(seconds_sum > 3600)
            {
                int hours = seconds_sum / 3600;
                int minutes = (seconds_sum % 3600) / 60;
                int seconds = (seconds_sum % 3600) % 60;
                time_str = string.Format("{0}时 {1}分 {2}秒", hours, minutes, seconds);
            }
            else if(seconds_sum < 3600)
            {
                int minutes = seconds_sum/ 60;
                int seconds = seconds_sum % 60;
                time_str = string.Format("{0}分 {1}秒", minutes, seconds);
            }
            return time_str;
        }

        ///<summary>
        ///读取记录文件并处理显示
        ///</summary>
        public void showRecord()
        {
            totalCodeTime = 0;
            string path = RECORD_FILE;
            historyBox.Text = string.Empty;
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
                        XmlNode work = work_list[work_list.Count - 1];
                        historyBox.Text += "你在" + work["begin_time"].InnerText + "在"
                                   + work["type"].InnerText
                                   + "上花费了"
                                   + time2fomat(work["coding_time"].InnerText) + "的时间呢，" + "一直忙到了" + work["end_time"].InnerText
                                   + ". 你想补充的是:" + work["Note"].InnerText + "\r\n";
                        totalCodeTime += getaCodeTime(work["coding_time"].InnerText);
                    }

                    if (work_list != null)
                    {
                        foreach (XmlNode work in work_list)
                        {
                            totalCodeTime += getaCodeTime(work["coding_time"].InnerText);
                        }
                    }
                    string passed_time = second_time_fomat(totalCodeTime);
                    showPassedTimeLabel.Text = "You have coded for " + passed_time;
                }
                catch (Exception es)
                {
                    // MessageBox.Show(es.Message);
                }
            }
        }

        /// <summary>    
        /// 创建节点    
        /// </summary>    
        /// <param name="xmldoc"></param>  xml文档  
        /// <param name="parentnode"></param>父节点    
        /// <param name="name"></param>  节点名  
        /// <param name="value"></param>  节点值  
        ///   
        public void CreateNode(XmlDocument xmlDoc, XmlNode parentNode, string name, string value)
        {
            XmlNode node = xmlDoc.CreateNode(XmlNodeType.Element, name, null);
            node.InnerText = value;
            parentNode.AppendChild(node);
        }


        ///<summary>
        ///开始记录时间
        ///</summary>
        public void startRecord()
        {
            mysetTime = Convert.ToInt32(comboBox1.Text.ToString()) * 60;
            note = note_text.Text;
            this.panel2.Enabled = false;
            timer1.Start();
        }

        ///<summary>
        ///结束计时
        ///</summary>
        public void stopRecord()
        {
            timer1.Stop();
            showPassedTimeLabel.Text = string.Empty;
            //xml交互记录
            XmlDocument doc = new XmlDocument();
            string file_path = RECORD_FILE;
            doc.Load(file_path);
            XmlNode history = doc.SelectSingleNode("/history");
            XmlNode your_work = doc.CreateNode(XmlNodeType.Element, "your_work", null);
            CreateNode(doc, your_work, "begin_time", DateTime.Now.AddSeconds(-passedTime).ToString());
            CreateNode(doc, your_work, "coding_time", passedTime.ToString()+" s");
            CreateNode(doc, your_work, "end_time", DateTime.Now.ToString());
            CreateNode(doc, your_work, "type", this.type_text.Text);
            CreateNode(doc, your_work, "Note",this.note);
            history.AppendChild(your_work);
            doc.Save(file_path);
            //xml交互结束
            passedTime = 0;
            panel2.Enabled = true;

        }

        ///<summary>
        /// 到点提醒
        /// </summary>
        void clock()
        {
            reminder clock_window = new reminder();
            clock_window.Show();
            stopRecord();
            showRecord();//刷新事件记录表格
        }

        ///<summary>
        ///时钟进行事件,程序逻辑
        ///</summary>
        private void timer1_Tick(object sender, EventArgs e)
        {
            passedTime++;
            showPassedTimeLabel.Text = "已过去 " + passedTime.ToString() + " s";
            if (passedTime >= mysetTime)
            {
                clock();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            

            if (this.type_text.Text == string.Empty)
            {
                type_text.Focus();
            }
            else if (note_text.Text == string.Empty)
            {
                note_text.Focus();
            }
            else
            {
                startBtn.Focus();
                this.code_type = "type_text.Text";
                startRecord();
            }
                
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            if(passedTime != 0)
            {
                stopRecord();
                showRecord();
            }
        }
        private void button1_Click_2(object sender, EventArgs e)
        {
            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void comboBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(Char.IsNumber(e.KeyChar)) && e.KeyChar != (char)13 && e.KeyChar != (char)8)
            {
                e.Handled = true;
            }
        }

        private void history_Click(object sender, EventArgs e)
        {
            record re = new record();
            re.Show();
            /*
            if (historyBox.Visible == false)
            {
                historyBox.Visible = true;
                history.Text = "历史（隐）";
            }
            else
            {
                historyBox.Visible = false;
                history.Text = "历史（显）";
            }*/
        }

        private void bindingSource1_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void historyBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            if(historyBox.Left < this.ClientRectangle.Width/2 && historyBox.Right > this.ClientRectangle.Width / 2)
                this.historyBox.Left -= 1;
            else
            if(this.historyBox.Right > 0)
            {
                this.historyBox.Left -= 15;
            }
            else
            {
                this.historyBox.Left -= 30;
            }
            if (historyBox.Right<0)
                historyBox.Left = this.ClientRectangle.Width;
        }

        private void historyBox_Click(object sender, EventArgs e)
        {
            if (timer2.Enabled == true)
                timer2.Stop();
            else
                timer2.Start();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void CodeAndRest_Enter(object sender, EventArgs e)
        {

        }

        private void CodeAndRest_KeyDown(object sender, KeyEventArgs e)
        {
           

        }

        private void CodeAndRest_KeyPress(object sender, KeyPressEventArgs e)
        {
            
            
        }
    }
}
