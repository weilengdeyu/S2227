using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day08_0100单例模式
{
   public class Play
    {
       private Play() { }
       private static Play play;
       public static Play getOnlyOne()
       {
           if (play == null)
           {
               //证明内存中一个对象都没有
               play = new Play();
           }
           return play;
       }
    }
}
