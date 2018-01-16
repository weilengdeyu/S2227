using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day04_0200方法重载
{
    class Program
    {
        static void Main(string[] args)
        {
            //1.找一个演奏家 Player
            Player player = new Player();

            //2.我想唱歌
            player.Play(new Song());

            //3.我想表演剧本
            player.Play(new Script());
            //4.我想演奏乐器
            player.Play(new Music());

            Console.WriteLine(1);
            Console.WriteLine("1");
            Console.WriteLine("1",2,3,4,5,6,7,8);
            Console.WriteLine();

            MagicClass mc = new MagicClass();
            mc.Say();

            mc.Say(1);

            mc.Say("1");

            mc.Say("1", 2, 3, 4, 5, 6, 7, 8);

        }
    }
}
