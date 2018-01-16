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
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
        }

        private void FrmMain_Load(object sender, EventArgs e)
        {
            //设置整行选中
            lVList.FullRowSelect = true;
            //设置ListView只能有一行被选中
            lVList.MultiSelect = false;
            //01.我将3个员工信息放入到一个对象数组中
            InitData();

            //02.我从对象数组中取出每个员工对象 绑定到ListVIew上 每个员工对象占一行（ListViewItem）
            BindData();
        }

        //定义长度为3的对象数组
        SE[] emps = new SE[3];
        //绑定数据
        private void BindData()
        {
            foreach (SE se in emps)
            {
                //每一个se都应该成为一个ListViewItem对象
                ListViewItem lvItem = new ListViewItem(se.EmpId);
                lvItem.SubItems.Add(se.EmpName);
                lvItem.SubItems.Add(se.EmpAge.ToString());
                lvItem.SubItems.Add(se.EmpAssert);
                lvItem.SubItems.Add(se.EmpScore.ToString());
                //让lvItem隶属于listView称为他的一项
                lVList.Items.Add(lvItem);
            }
        }
        //初始化数据
        private void InitData()
        {
            SE se1 = new SE();
            se1.EmpId = "001";
            se1.EmpName = "王康";
            se1.EmpAge = 20;
            se1.EmpScore = 0;
            se1.EmpAssert = "未评价";

            SE se2 = new SE();
            se2.EmpId = "002";
            se2.EmpName = "王鸿";
            se2.EmpAge = 20;
            se2.EmpScore = 0;
            se2.EmpAssert = "未评价";

            SE se3 = new SE();
            se3.EmpId = "003";
            se3.EmpName = "王晓圆";
            se3.EmpAge = 20;
            se3.EmpScore = 0;
            se3.EmpAssert = "未评价";

            emps[0] = se1;
            emps[1] = se2;
            emps[2] = se3;

        }
         //双击时间
        private void lVList_DoubleClick(object sender, EventArgs e)
        {
            FrmAdd frm = new FrmAdd();
            //能获取到ListView当中  选中的一行对象
            ListViewItem selectdItem = lVList.SelectedItems[0];
            frm.selectdItem = selectdItem;

            frm.Show();
        }
    }
}
