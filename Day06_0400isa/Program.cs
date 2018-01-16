using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day06_0400isa
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Employee> list = new List<Employee>();
            //1.PM对象
            PM pm = new PM();

            //2.SE对象
            SE se = new SE();
            list.Add(pm);
            list.Add(se);



            foreach (Employee item in list)
            {
                item.sayHello();
            }
            //foreach (Employee item in list)
            //{
            //    //is 判定的是 当前 item 对象 是不是 PM类型
            //    if (item is PM)
            //    {
            //        PM pm2 = (PM)item;
            //        pm2.sayHello();
            //    }
            //    //判断当前item是不是SE类型
            //    if (item is SE)
            //    {
            //        SE se2 = (SE)item;
            //        se2.sayHello();
            //    }
            //}

        }
    }
}
