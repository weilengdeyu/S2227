using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day06_0400isa
{
    public class Employee
    {
        public string Name { get; set; }
        //虚方法定义的目的就是为了给子类同名方法    重新实现  用的
        public virtual void sayHello() 
        {
            Console.WriteLine("父类的SayHello");
        }
    }
}
