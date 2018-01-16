using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day07_0100父类变量保存子类对象
{
    class Program
    {
        static void Main(string[] args)
        {

            Animal animal = new Animal();

            Dog dog = new Dog();

            Cat cat = new Cat();
            //解释这一行代码   父类变量  保存子类对象   或者 父类引用保存子类的对象
            //里氏替换是在代码中渗透的     一种思想
            //里氏替换：在一个软件系统中，如果子类能替代父类出现的位置，而整对整个软件功能没有任何影响。

            Animal d2 = new Dog();

            d2.sleep();
            ((Dog)d2).eat();
        }
    }
}
