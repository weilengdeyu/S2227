using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day02_0200值类型和引用类型
{
    class Program
    {
        static void Main(string[] args)
        {
            #region 01============值类型赋值原理
            //张浩和李明去年身高都是170cm，今年李明长到了180cm，张浩没有变化，
            //输出去年和今年两人身高
            //int zhheight = 170;
            //int lmheigt = zhheight;
            //Console.WriteLine("去年张浩身高是{0}\t李明的身高是{1}", zhheight, lmheigt);
            //lmheigt = 180;
            //Console.WriteLine("今年张浩身高是{0}\t李明的身高是{1}", zhheight, lmheigt); 
            #endregion


            #region 02.===========引用类型赋值原理
            //int[] zhArray={170,60};
            //int[] lmArray = zhArray;
            //Console.WriteLine("去年张浩身高是{0},体重是{1}\t李明的身高是{2}，体重是{3}", zhArray[0],zhArray[1], lmArray[0],lmArray[1]);
            //Console.WriteLine("================我是高贵的分割线======================");
            //lmArray[0] = 180;
            //lmArray[1] = 70;
            //Console.WriteLine("今年张浩身高是{0},体重是{1}\t李明的身高是{2}，体重是{3}", zhArray[0], zhArray[1], lmArray[0], lmArray[1]);
            #endregion


            #region 03.解决引用类型赋值问题
            int[] zhArray = { 170, 60 };
            int[] lmArray = new int[2];
            for (int i = 0; i < zhArray.Length; i++)
            {
                lmArray[i] = zhArray[i];
            }
            Console.WriteLine("去年张浩身高是{0},体重是{1}\t李明的身高是{2}，体重是{3}", zhArray[0], zhArray[1], lmArray[0], lmArray[1]);
            Console.WriteLine("================我是高贵的分割线======================");
           
            lmArray[0] = 180;
            lmArray[1] = 70;
            Console.WriteLine("今年张浩身高是{0},体重是{1}\t李明的身高是{2}，体重是{3}", zhArray[0], zhArray[1], lmArray[0], lmArray[1]);
            #endregion

            #region 04.关于数组中元素初值问题的探讨      char 默认值  '\u0000'   
            char[] chars = new char[2];
            for (int i = 0; i < chars.Length; i++)
            {
                Console.WriteLine(chars[i]);
            }
            foreach (char item in chars)
            {
                Console.WriteLine(item);
            }
            //Console.WriteLine(chars[1]+"===========");  //null 0 
            #endregion
        }
    }
}
