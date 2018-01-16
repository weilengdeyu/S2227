using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day04_0100构造函数
{
   public class Book
    {
       // 艰难的抉择   你是人间的四月天  解忧杂货店  窗边的小豆豆  红楼梦 三重门  预约死亡  红处方  1988我想和这个世界谈谈
        private int price;
        private string author;
        private string name;
        //为什么系统要自动生成无参构造？是为了给将来给高级框架，高级框架在底层可以通过无参构造给我们的类创建对象。
        public Book() { }

        public Book(int price, string author, string name)
        {
            //当前类的实例 ，用来 区分入参  和成员变量。
            this.price = price;
            this.author = author;
            this.name = name;
            //史铁生    
        }
       //方法
        public int Price
        {
            get { return price; }
            set { price = value; }
        }

    

        public string Author
        {
            get { return author; }
            set { author = value; }
        }
    

        public string Name
        {
            get { return name; }
            set { name = value; }
        }


    }
}
