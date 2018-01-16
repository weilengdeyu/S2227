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
    public partial class FrmAdd : Form
    {
        public FrmAdd()
        {
            InitializeComponent();
        }
        public List<SE> emps;
        public Form1 frm1;
        private void btnAdd_Click(object sender, EventArgs e)
        {
            //01.搜罗数据++++形成对象
            SE se = new SE();
            se.EmpId = txtId.Text;
            se.EmpName = txtName.Text;
            se.EmpAge = Convert.ToInt32(txtAge.Text);
            se.Gender = cboGender.Text;

            //02.隶属于集合
            emps.Add(se);

            //03.调度 A界面的BindDGV()去做数据绑定
            frm1.BindDGV();

            this.Close();

        }
    }
}
