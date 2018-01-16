using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day08_0100单例模式
{
    class Program
    {
        static void Main(string[] args)
        {
            Play p1=Play.getOnlyOne();
            Play p2 = Play.getOnlyOne();
          
        }
    }
}
