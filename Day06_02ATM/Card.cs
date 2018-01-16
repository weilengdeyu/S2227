using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day06_02ATM
{
    //银行卡父类
   public class Card
    {
       //属性  卡号 密码  余额
        public string CardNo { get; set; }
        public string CardPassWord { get; set; }
        public double CardBalance { get; set; }

       //持卡人
        public string accountOwner { get; set; }
        public Card() { }
        public Card(string cardno,string cardpassword,double cardbalance,string owner) 
        {
            this.CardNo = cardno;
            this.CardPassWord = cardpassword;
            this.CardBalance = cardbalance;
            this.accountOwner = owner;
        }
    }
}
