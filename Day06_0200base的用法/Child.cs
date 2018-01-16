using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day06_0200base的用法
{
   public class Child:Parent
    {
       public Child() { }
       public Child(string name,int age):base(name,age) 
       {
           this.Sname = name;
           this.Sage = age;
       }
    }
}
