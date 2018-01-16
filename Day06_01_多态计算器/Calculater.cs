using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day06_01_多态计算器
{
    /// <summary>
    /// 计算的父类
    /// </summary>
    public class Calculater
    {
        //定义成员变量
        //第一个操作数
        public int NumLeft { get; set; }
        //第二个操作数
        public int NumRight { get; set; }
        //calc需要参数吗？ 用的话，加几个？不用的话，为什么？
        public virtual int calc() 
        {
            //不需要有实现
            return 0;
        }
    }
}
