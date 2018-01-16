using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Day03_0100泛型初步
{
    class Program
    {
        static void Main(string[] args)
        {
            #region 01.集合使用
            ArrayList list = new ArrayList();
            //1.1  扔数据进去   逻辑思维
            list.Add("罗振宇===时间的朋友===跨年演讲");
           
            list.Add("前HP CEO 卡莉·菲奥莉娜 康柏");
            list.Add("王鸿 ====曾经的网红===那些年，粉丝也是   过亿的！！！！");
            list.Add("隔壁老王");
            list.Insert(1,"我是老二吧！");
            Console.WriteLine("集合中元素总量"+list.Count);
            Console.WriteLine("集合中集合容量" + list.Capacity); //容量

            //1.2  遍历集合
            foreach (string item in list) //自动迭代  有一个迭代器
            {
                Console.WriteLine(item);
            }
            //1.3  删除数据
            //方式一：下标
           // list.RemoveAt(0);
            //方式二：根据内容删除
            list.Remove("罗振宇===时间的朋友===跨年演讲");
            Console.WriteLine("==========删除后===============");
            foreach (string item in list) //自动迭代  有一个迭代器
            {
                Console.WriteLine(item);
            }
            //判定某个元素 是否在集合中
            bool flag=list.Contains("李小龙");
            if (flag)
            {
                Console.WriteLine("Exists");
            }
            else
            {
                Console.WriteLine("Not Exists");
            }
            #endregion

            #region 02。集合初始化器
            ArrayList list2 = new ArrayList()   //集合初始化
            {
                new SE(){Name="张靓颖",Age=20}, //对象初始化器
                new SE()
            };
            #endregion
        }
    }
}
