using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
namespace Day08_0300Xml解析
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //1.将硬盘上文档     找一个C#中的类型与之对应
            XmlDocument doc = new XmlDocument();
            //2.加载硬盘上指定路径的一个xml文件作为文档内容
            doc.Load("Book.xml");
            //3.获取根节点
            XmlNode root=doc.DocumentElement;
            foreach (XmlNode book in root.ChildNodes)
            {
                //Console.WriteLine(book["bookid"].InnerText);
                //Console.WriteLine(book["bookname"].InnerText);
                //Console.WriteLine(book["bookauthor"].InnerText);
                //Console.WriteLine(book["bookprice"].InnerText);
                //一个book对象就对应着 Xml文件中的一个Book节点
                foreach (XmlNode item in book.ChildNodes)
                {
                    //一个item就是xml中的一个Book中的子节点  bookid  bookname 
                    if (item.Name.Equals("bookid"))
                    {
                        Console.WriteLine("id"+item.InnerText);
                    }
                    else if (item.Name.Equals("bookname"))
                    {
                        Console.WriteLine("name" + item.InnerText);
                    }
                }
            }
            Console.WriteLine("xxxx");
            
        }
    }
}
