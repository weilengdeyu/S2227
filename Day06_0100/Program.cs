using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day06_0100
{
    class Program
    {
        static void Main(string[] args)
        {
            //int的类型到底是什么     GetType:获取一个类型的类型
            Student stu = new Student();
            Console.WriteLine(stu.GetType());

            int num = 3;
            num.ToString();
        }
    }
}
