using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day0_06_0300访问修饰符
{
    class Program:UserInfo
    {
        static void Main(string[] args)
        {
           

        }
        public void Say() 
        {
            this.path = "xxxxxxx";
        }
    }
}
