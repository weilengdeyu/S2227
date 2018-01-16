using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day07_0100父类变量保存子类对象
{
    public class Dog:Animal
    {
        public override void sleep() 
        {
            Console.WriteLine("狗狗sleep");
        }
        public void eat() {
        }
    }
}
