using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day06_01_多态计算器
{
    //计算工厂
    public class OperationFactory
    {
        //VS2012 代码段  
        public static Calculater GetInstace(string oper) 
        {
            Calculater calc = null;
            //3.进行判定  运算符和 +   -
            switch (oper)
            {
                case "+":
                    calc = new Add();
                    break;
                case "-":
                    calc = new Sub();
                    break;
                case "*":
                    calc = new Multi();
                    break;
                case "/":
                    calc = new Div();
                    break;
                default:
                    break;
            }
            return calc;
        }
    }
}
