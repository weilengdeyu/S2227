using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day02_0500装箱和拆箱
{
    class Program
    {
        static void Main(string[] args)
        {
            //很贱

            int num = 1;
            object obj = num;  //有装箱操作
            int result = (int)obj; //拆箱操作
            //要想拆箱，先有装箱。 
        }
    }
}
