using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Day08_0200保证播放窗体是单例的
{
    public partial class FrmPlay : Form
    {
        //构造私有
        private FrmPlay()
        {
            InitializeComponent();
        }
        //2.静态成员变量
        private static FrmPlay play;
        //3.定义一个公有的  静态的 返回类类型的方法
        public static FrmPlay GetInstance() 
        {
            if (play==null)
            {
                play = new FrmPlay();
            }
            return play;
        }
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            //女孩儿  卸妆之后   都是  凤姐

            //男孩儿  卸妆之后   都是  刘德华

        }
        public string path;

        private void FrmPlay_Load(object sender, EventArgs e)
        {
        
        }
        public void PlayMusic() 
        {
            player1.URL = path;
        }
    }
}
