using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Day03_0500
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        //01.我得有一个集合容器 
        List<SE> emps = new List<SE>();
        private void Form1_Load(object sender, EventArgs e)
        {
            //告诉控件不要帮我生成列
            dgvList.AutoGenerateColumns = false;
        }

        //databind方法
        public void BindDGV() 
        {
            dgvList.DataSource = new BindingList<SE>(emps);
        }
        //添加
        private void ts_btnAdd_Click(object sender, EventArgs e)
        {
            FrmAdd frm = new FrmAdd();
            frm.emps = emps;
            frm.frm1 = this;//意思是当前窗体对象作为添加窗体的一个属性值存在
            frm.Show();
        }
    }
}
