using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day06_02ATM
{
    /// <summary>
    /// 本地卡
    /// </summary>
   public class LocalCard:Card
    {
       public LocalCard() { }
       public LocalCard(string cardno, string password, double balance, string owner)
           : base(cardno, password, balance, owner) 
       {

       }
    }
}
