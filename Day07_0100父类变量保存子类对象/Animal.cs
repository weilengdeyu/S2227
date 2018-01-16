using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day07_0100父类变量保存子类对象
{
    //动物父类
    public class Animal
    {
        public virtual void sleep() 
        {
            Console.WriteLine("Animal sleep");
        }
    }
}
