using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day07_0200父类类型作为方法参数
{
    public class Employee
    {
        public string Name { get; set; }
        public void GoHome(Tool tool) 
        {
            tool.Run();
        }
    }
}
