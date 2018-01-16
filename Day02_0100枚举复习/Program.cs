using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day02_0100枚举复习
{
    class Program
    {
        static void Main(string[] args)
        {
            Student stu = new Student();
            stu.Age = 20;
            stu.Name = "张林老师";
            stu.Sex = Gender.Male;
        }
    }
}
