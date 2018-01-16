using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day06_0100
{
    public class PM:Employee
    {
        public void say()
        {
            //this代表的是当前对象的实例
            this.Name = "老王";
            this.Age = 20;
            this.Gender = "男";
            this.Number = "001";

        }
    }
}
