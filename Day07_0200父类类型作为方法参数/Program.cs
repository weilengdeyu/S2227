using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day07_0200父类类型作为方法参数
{
    class Program
    {
        static void Main(string[] args)
        {
            //我要回家 Java 
            //Employee
            Employee emp = new Employee();
            Employee emp2 = new Employee();

            //交通工具
            Tool tool = new Car();
            Tool tool2 = new Tube();

            emp.GoHome(tool);
            emp2.GoHome(tool2);

         
        }
    }
}
