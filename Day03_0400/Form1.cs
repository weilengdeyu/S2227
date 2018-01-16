using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Day03_0400
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            try
            {
                 List<string> list = new List<string>();
                 list.RemoveAt(0);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }



            //List<Student> list = new List<Student>() 
            //{
            //    new Student(){Name="李小龙",Age=20},
            //    new Student(){Name="王小康",Age=21}
            //};
            //Student s1=new Student(){Name="李小龙",Age=20};
            //Student s2=new Student(){Name="王小康",Age=21};

            //Dictionary<string, Student> dic = new Dictionary<string, Student>();

            //dic.Add(s1.Name, s1);
            //dic.Add(s2.Name, s2);

            //BindingSource bs = new BindingSource();
            //bs.DataSource = dic.Values;
            //dgvList.DataSource = bs;
            //dgvList.DataSource = new BindingList<Student>(list); //实时监控 到集合数据的修改  而list不能
        }
    }
}
