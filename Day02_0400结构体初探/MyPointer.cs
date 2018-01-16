using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day02_0400结构体初探
{
    //定一个自己的结构体
    public struct MyPointer
    {

        //成员 属性   结构体的成员变量不能有初值
        private int age;

        public int Age
        {
            get { return age; }
            set { age = value; }
        }
        //结构体中可以定义方法
        public void show() 
        {
           
        }

    }
}
