using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day02_0400结构体初探
{
    class Program
    {
        static void Main(string[] args)
        {
            //使用结构体
            MyPointer pointer=new MyPointer();
            pointer.Age = 20;
            pointer.show();
        }
    }
}
