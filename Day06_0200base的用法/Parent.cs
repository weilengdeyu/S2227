using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day06_0200base的用法
{
    public class Parent
    {

       
        public string Sname { get; set; }
        public int Sage { get; set; }
        public Parent() { }
        public Parent(string name,int age) 
        {
            this.Sname = name;
            this.Sage = age;
        }
    }
}
