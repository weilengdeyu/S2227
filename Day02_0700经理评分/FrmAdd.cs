using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Day02_0700经理评分
{
    public partial class FrmAdd : Form
    {
        public FrmAdd()
        {
            InitializeComponent();
        }
        public ListViewItem selectdItem;
        private void FrmAdd_Load(object sender, EventArgs e)
        {
            txtName.Text = selectdItem.SubItems[1].Text;
        }

        private void btn_Score_Click(object sender, EventArgs e)
        {
            //获取界面上用户填写的评分
            
            //赋值给selectdItem的对应列
            selectdItem.SubItems[4].Text = txtScore.Text;
        }
    }
}
