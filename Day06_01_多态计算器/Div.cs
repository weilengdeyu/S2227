using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day06_01_多态计算器
{
    public class Div:Calculater
    {
        public override int calc()
        {
            //小学老师说过，除数不能为0 ，如果除数为0 ， 5/0 没有意义（相当于0分之五）
            //程序中如何保证 除数不为o
            if (NumRight==0)
            {
                throw new Exception("亲，除数不能为0啊！脑子被驴踢了吧！");
            }
            return this.NumLeft / this.NumRight;
        }
    }
}
