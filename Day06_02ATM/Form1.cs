using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Day06_02ATM
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //容器保存N张卡的信息  卡号做为key   卡对象做为Value

        //集合 Dictionary<string,Card> dic=null;
        Dictionary<string, Card> dic = new Dictionary<string,Card>();
        public void InitData() 
        {
            lblBalance.Text = "";
            lblCardNum.Text = "";
            lblAccountName.Text = "";

            //让三个按键不可用
            btnQuery.Enabled = false;
            btnGet.Enabled = false;
            btnPost.Enabled = false;

            //让文本框获取焦点
            txtGetMoney.Focus();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            //界面数据的初始化
            InitData();

            //2.伪造数据
            InitDictory();

        }

        private void InitDictory()
        {
            //实例化一张本地卡
            LocalCard localCard = new LocalCard("6226 6202 0494 9861","6375196",1000,"微冷的雨");
            //实例化一张外地卡
            OtherCard otherCard = new OtherCard("6226 6202 0898 9861","6375196",2000,"巩俐");

            //银行里可以存储N张银卡卡信息 
            dic.Add(localCard.CardNo,localCard);
            dic.Add(otherCard.CardNo,otherCard);
        }

        //插卡操作
        private void btnInsert_Click(object sender, EventArgs e)
        {
            //判空  null ""
            if (String.IsNullOrEmpty(txtCardNum.Text))
            {
                MessageBox.Show("请您输入卡号，大爷");
                return;
            }
            if (String.IsNullOrEmpty(txtPwd.Text))
            {
                MessageBox.Show("请您输入密码，大爷");
                return;//如果在一个方法中，返回为void return后不跟任何内容，代表结束当前方法的执行，
                //后续的code没有执行权
            }
            //证明用户输入了信息
            //write a little ,debug a little 写一点点，调试一点点
            //拿合法数据和集合中的每张卡的 卡号 和密码 一一对比？
            //接收到用户录入的卡号
            string userCardNo=txtCardNum.Text;
            bool flag=dic.ContainsKey(userCardNo);
            if (flag)
            {
                 //It means we have a cardno match which we write in the ui interface
                // 它说明了有一张卡的卡号     匹配我们在     界面接口上   录入的卡号
                //嵌套if判定密码是否匹配
                string password = txtPwd.Text;
                Card card=dic[userCardNo]; //卡对象
                if (password.Equals(card.CardPassWord))
                {
                    //密码匹配
                    //将信息显示到UI的对应控件上
                    //3个按键重新启用
                    btnQuery.Enabled = true;
                    btnGet.Enabled = true;
                    if (card is LocalCard)
                    {
                        //是本地卡，解锁转账按键
                        btnPost.Enabled = true;
                    }
                  

                    //赋值操作
                    lblCardNum.Text = userCardNo;
                    lblAccountName.Text = card.accountOwner;

                }
                else
                {
                    //密码不正确
                    MessageBox.Show("密码不正确，请重新输入");
                }
            }
            else
            {
                int num = 2;
                //没有该卡
                MessageBox.Show("亲，你是哪位？小娜不认识!!!~~~~");
            }
        }
    }
}
