using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day03_0300泛型集合
{
    class Program
    {
        static void Main(string[] args)
        {
            #region 01.泛型集合先导课程
            //PM pm = new PM();

            //SE s1 = new SE();

            //SE s2 = new SE();

            //ArrayList list = new ArrayList();
            //list.Add(pm);
            //list.Add(s1);
            //list.Add(s2);

            //foreach (Object item in list)
            //{

            //}

            //PM pmResult=(PM)list[0];
            //SE seResult1 = (SE)list[1];
            //SE seResult2 = (SE)list[2]; 
            #endregion

            #region 02.泛型集合
            ////<真实类型> 限定 Add()入参的类型  
            //List<SE> list = new List<SE>();
            //SE se=new SE();
            //se.Name = "比尔·盖茨";

            //SE se2 = new SE();
            //se2.Name = "李彦宏";
            //list.Add(se);
            //list.Add(se2);

            //foreach (SE item in list)
            //{
            //    Console.WriteLine(item.Name);
            //}
            #endregion

            #region 03.双列集合  Dictionay<K,V>

            Dictionary<string, string> dic = new Dictionary<string, string>();
            dic.Add("ICBC","中国工商银行");

            dic.Add("ABC", "中国农业银行");

            dic.Add("CBC", "中国建设银行");

            //找一下 EBank 有没有在集合中
            bool flag=dic.ContainsKey("EBank");
            if (flag)
            {
                Console.WriteLine("存在");
            }
            else
            {
                Console.WriteLine("不存在");
            }

            //双列集合遍历方案
            //方式一：
            foreach (string key in dic.Keys)
            {
                Console.WriteLine(key);
                Console.WriteLine(dic[key]);
            }
            //方式二;直接获取Value
            foreach (string value in dic.Values)
            {
                Console.WriteLine(value);
            }
            //方式三：key+value =======item
            foreach (KeyValuePair<string,string> item in dic)
            {
                Console.WriteLine(item.Key);
                Console.WriteLine(item.Value);
            }


            #endregion
        }
    }
}
