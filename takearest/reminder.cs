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
        private string back_img_url = "";
        private int pic_index = 0;
        public string globePath = System.Environment.CurrentDirectory;

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

        public void get_img_from_internet()
        {
            Thread t1 = new Thread(new ThreadStart(GetTodayImg));
            t1.IsBackground = true;
            t1.Start();
            Thread t2 = new Thread(new ThreadStart(GetNextImg));
            t2.IsBackground = true;
            t2.Start();
        }
        public void GetTodayImg()
        {
            string file_name = DateTime.Now.ToLongDateString().ToString();
            this.back_img_url = System.IO.Path.Combine(globePath, file_name + ".jpg");
            if (File.Exists(this.back_img_url))
            {
                today_img.ImageLocation = this.back_img_url;
                return;
            }
            try
            {
                HttpWebRequest req = (HttpWebRequest)WebRequest.Create("http://www.meizitu.com/");
                HttpWebResponse res = (HttpWebResponse)req.GetResponse();
                StreamReader sr = new StreamReader(res.GetResponseStream());
                string htmlSource = sr.ReadToEnd();
                string regexImgSrc = @"<img[^>]*?src\s*=\s*[""']?([^'"" >]+?)[ '""][^>]*?style=[^>]*?>";
                MatchCollection matchesImgSrc = Regex.Matches(htmlSource, regexImgSrc, RegexOptions.IgnoreCase | RegexOptions.Singleline);
                string href = matchesImgSrc[0].Groups[1].Value;
                //Console.WriteLine(href);
                using (WebClient myWebClient = new WebClient())
                {
                    //Console.WriteLine(file_name);
                    this.back_img_url = System.IO.Path.Combine(globePath, file_name + System.IO.Path.GetExtension(href));
                    try
                    {
                        myWebClient.DownloadFile(new Uri(href), this.back_img_url);
                        today_img.ImageLocation = this.back_img_url;
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex.Message);
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        public void GetNextImg()
        {
            try
            {
                HttpWebRequest req = (HttpWebRequest)WebRequest.Create("http://www.meizitu.com/");
                HttpWebResponse res = (HttpWebResponse)req.GetResponse();
                StreamReader sr = new StreamReader(res.GetResponseStream());
                string globePath = System.Environment.CurrentDirectory;
                string htmlSource = sr.ReadToEnd();
                string regexImgSrc = @"<img[^>]*?src\s*=\s*[""']?([^'"" >]+?)[ '""][^>]*?style=[^>]*?>";
                MatchCollection matchesImgSrc = Regex.Matches(htmlSource, regexImgSrc, RegexOptions.IgnoreCase | RegexOptions.Singleline);
                int img_index = 0;
                foreach (Match m in matchesImgSrc)
                {
                    string href = m.Groups[1].Value;
                    Console.WriteLine(href);
                    using (WebClient myWebClient = new WebClient())
                    {
                        string file_name = DateTime.Now.ToUniversalTime().ToString();
                        try
                        {
                            img_index++;
                            if(File.Exists(System.IO.Path.Combine(globePath, DateTime.Now.ToLongDateString().ToString() + "-" + (img_index).ToString() + System.IO.Path.GetExtension(href))))
                            {
                                continue;
                            }
                            myWebClient.DownloadFile(new Uri(href), System.IO.Path.Combine(globePath, DateTime.Now.ToLongDateString().ToString() + "-" + (img_index).ToString() + System.IO.Path.GetExtension(href)));
                        }
                        catch (Exception ex)
                        {
                            Console.WriteLine(ex.Message);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

        }

        private void showimg_btn_Click(object sender, EventArgs e)
        {
            get_img_from_internet();
            today_img.Visible = true;
        }

        private void morepic_btn_Click(object sender, EventArgs e)
        {
            int current_index = this.pic_index;
            while (true)
            {
                this.pic_index++;
                string img_path = System.IO.Path.Combine(globePath, DateTime.Now.ToLongDateString().ToString() + "-" + (this.pic_index).ToString() + ".jpg");
                if (File.Exists(img_path))
                {
                    today_img.ImageLocation = img_path;
                    break;
                }
                else
                {
                    if (this.pic_index > 15)
                    {
                        this.pic_index = 1;
                        break;
                    }
                }
            }
        }

    }
}
