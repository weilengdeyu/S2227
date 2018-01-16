using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day04_0300对象间交互
{
    class Program
    {
        static void Main(string[] args)
        {
            //01.买一个电视机
            Tv tv = new Tv();


            //02.买一个遥控器
            Contol control = new Contol();

            //03.进行操作
            control.Open(tv);
            control.ChangeChannel(tv, "凤凰卫视");
            control.Close(tv);


        }
    }
}
