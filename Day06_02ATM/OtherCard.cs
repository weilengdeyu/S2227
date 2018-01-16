using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day06_02ATM
{
   public class OtherCard:Card
    {
       public OtherCard() { }
       public OtherCard(string cardno, string password, double balance, string owner)
           : base(cardno, password, balance,owner) 
       {

       }
    }
}
