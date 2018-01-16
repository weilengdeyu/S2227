using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day04_0200方法重载
{
    //表演者
    public class Player
    {
        //构造函数也可以构成重载
        public Player() 
        {

        }

        public Player(int age) 
        {

        }


        public void Say() { }

        public string Say(int age)
        { 
            return "1"; 
        }

        //public void Eat(int num) 
        //{ }


        //public void Eat(int num2)
        //{ }

        public void Eat(int age,string name) 
        {

        }

        public void Eat(string name, int age)
        {

        }






        //方法重载：如果在一个类中，如果多个方法方法名称相同，但是参数列表不同，就是方法重载。和返回值类型没有关系
        public int Play(Music music)
        {
            return 1;
        }
        public void Play(Song song)
        {

        }
        public void Play(Script script)
        {

        }
    }
}
