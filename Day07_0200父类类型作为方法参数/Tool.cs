using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day07_0200父类类型作为方法参数
{
    //抽象类
    public abstract class Tool
    {
        //大家可能天真的以为：我只要定义类，一定要有属性和方法。
        //我们只关注对自己业务有用的。
        //抽象类中可以有普通方法

        //限定子类方法的长相的（名字参数  返回值 访问修饰）
        public abstract void Run();
        //public abstract void Stop();
    }
}
