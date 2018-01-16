using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day04_0300对象间交互
{
    /// <summary>
    /// 电视机
    /// </summary>
    public class Tv
    {
        //维护一个状态
        bool state = false;//关闭
        public void Open() 
        {
            if (state==false)//关闭的
            {
                state = true;//状态切换到开 机状态
                Console.WriteLine("电视机打开啦！！！！！~~~~~");
            }   
        }
        public void Close()
        {
            if (state == true)//开着的
            {
                state = false;//状态切换到关 机状态
                Console.WriteLine("电视机关闭啦！！！！！~~~~~");
            }
        }

        public void ChangeChannel(string channelName)
        {
            if (state==true)
            {
                Console.WriteLine("您已经成功切换到"+channelName);
            }
        }

    }
}
