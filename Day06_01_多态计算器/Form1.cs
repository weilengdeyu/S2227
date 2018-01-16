using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Day06_01_多态计算器
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            lblResult.Text = "";
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            //1.搜集页面上的两个变量
            int num1 = Convert.ToInt32(txtNum1.Text);
            int num2 = Convert.ToInt32(txtNum2.Text);
            //2,搜集运算符
            string oper = cboOper.Text;
            //code
            Calculater calc = OperationFactory.GetInstace(oper);
            //if (oper.Equals("+"))
            //{
            //    //Add
            //    calc = new Add();
            //}
            //else if (oper.Equals("-"))
            //{
            //    calc = new Sub();
            //    //Sub
            //}
            //else if (oper.Equals("*"))
            //{
            //    //Multi
            //    calc = new Multi();
            //}
            //else if (oper.Equals("/"))
            //{
            //    //Div
            //    calc = new Div();
            //}
            //变量赋值
            calc.NumLeft = num1;
            calc.NumRight = num2;
 
            //4.调度对应子类的calc()实现结果运算并且返回
            //调度方法
            try
            {
                //可能出现异常的code
                    int result = calc.calc();
                    lblResult.Text = result.ToString();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }

            //5.将结果显示在lblResult中
            
        }
    }
}
