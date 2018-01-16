using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day06_0100值传递和引用传递
{
    class Program
    {
        static void Main(string[] args)
        {
            #region 01.ref 对于值类型数据的影响
            //int num1 = 3;
            //int num2 = 5;
            //Console.WriteLine("交换前:num1的值{0}\tnum2的值{1}", num1, num2);
            ////最简单的两个变量交换
            ////借助第三方
            //Change(ref num1, ref num2);
            //Console.WriteLine("交换后:num1的值{0}\tnum2的值{1}", num1, num2); 
            #endregion


            #region 02.ref对于引用类型的影响
            Voter voter = new Voter();

            //被选举人   马立强 
            SE se = new SE();
            se.popularity = 10;


            voter.Vote(se);

            voter.Vote(se);

            Console.WriteLine(se.popularity);

            #endregion


        }
        static void Change(ref int num1,ref int num2) 
        {
            int temp = num1;
            num1 = num2;
            num2 = temp;
        }
    }

}
