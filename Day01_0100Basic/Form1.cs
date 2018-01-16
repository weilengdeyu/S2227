using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
namespace Day01_0100Basic
{
    //WebClient web客户端
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        //Load指的是窗体出现前就会执行的代码区域
        private void Form1_Load(object sender, EventArgs e)
        {
            
            WebClient wc = new WebClient();
            Uri uri = new Uri("http://assets.kgc.cn/upload/ad/20171218/1513585999642203.jpg");
            wc.DownloadFile(uri, "happy.jpg");
            MessageBox.Show("下载成功");
            wb.Url = new Uri("https://www.baidu.com");
        }
    }
}
