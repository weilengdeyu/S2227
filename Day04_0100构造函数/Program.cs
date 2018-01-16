using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day04_0100构造函数
{
    class Program
    {
        static void Main(string[] args)
        {

            //实例化两本书   
            Book book = new Book();
            book.Price = 100;
            book.Name = "偷影子的人";
            book.Author = "未知";

            Book book2 = new Book(50, "思绪飘零", "微冷的雨");


           //1.构造强化

            //2.方法重载


            //3.对象间交互

            //4.UML  类图  S1 JavaLogic   用例图   时序图/序列图



        }
    }
}
