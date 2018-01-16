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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            //让DGV整行选中
            dgvList.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            //DGV和ContextMenuStrip bind 绑定
            dgvList.ContextMenuStrip = cms;

            
            List<Song> songList = new List<Song>() 
            {
                new Song(1,"祝你一路顺风","E:\\KuGou\\孤独是我的骨头.mp3"),
                new Song(2,"奔跑","E:\\KuGou\\妈妈.mp3"),
                new Song(3,"下一站是幸福","E:\\KuGou\\所谓朋友.mp3")
            };

            dgvList.DataSource=new BindingList<Song>(songList);


        }
        //Click  Play  
        private void tsmi_play_Click(object sender, EventArgs e)
        {
            FrmPlay play = FrmPlay.GetInstance();

            //获取当前选中行
            string path=dgvList.SelectedRows[0].Cells["Location"].Value.ToString();
            play.path = path;
            play.Show();
            play.PlayMusic();
        }
    }
}
