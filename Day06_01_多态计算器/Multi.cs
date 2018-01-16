using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day06_01_多态计算器
{
    public class Multi:Calculater
    {
        public override int calc()
        {
            return this.NumLeft * this.NumRight;
        }
    }
}
