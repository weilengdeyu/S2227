using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day04_0300对象间交互
{
    //遥控器
    public class Contol
    {
        public void Open(Tv tv)
        {
            tv.Open();
        }
        public void Close(Tv tv) 
        {
            tv.Close();
        }
        public void ChangeChannel(Tv tv,string channelName)
        {
            tv.ChangeChannel(channelName);
        }
    }
}
