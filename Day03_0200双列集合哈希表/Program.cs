using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day03_0200双列集合哈希表
{
    class Program
    {
        static void Main(string[] args)
        {
            #region 01.双列集合HashTable（哈希表）
            Hashtable table = new Hashtable();  //table中的一个item=key+value
            table.Add("ICBC", "工商银行");
            table.Add("ABC", "农业银行");
            table.Add("CBC","中国建设银行");

            //根据key获取value
            Object bankName=table["ICBC"];
            Console.WriteLine(bankName);
            Console.WriteLine("===============================");
            //遍历的手段
            //foreach  for 因为HashTable 只有key没有索引，for 通过下标取值
            //Value   方式一：通过Key取出Value
            foreach (Object key in table.Keys)
            {
                Console.WriteLine(key);
                //索引器
                Console.WriteLine(table[key]);
            }
            //直接Value，如果我们能拿到所有值的集合  。
            foreach (Object value in table.Values)
            {
                Console.WriteLine(value);    
            }
            //key+value 迭代  ，一次拿到的是key+value的组合
            foreach (DictionaryEntry item in table)
            {
                //Console.WriteLine("");
                Console.WriteLine(item.Key);
                Console.WriteLine(item.Value);
            }
	       #endregion

        }
    }
}
