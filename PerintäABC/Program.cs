using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PerintäABC
{
    class Program
    {
        static void Main(string[] args)
        {
            childclass ch = new childclass();
            ch.sum();
            child2 ch2 = new child2();
            ch2.message();
            child3 ch3 = new child3();
            ch3.message();
        }
    }

    abstract class baseclass
    {
        public int num = 8;
        public abstract void sum();
    }
    class childclass : baseclass
    {
        public override void sum()
        {
            Console.WriteLine("Yhteensä : " + num * num);
        }
    }

    class classbase
    {
        public virtual void message()
        {
            Console.WriteLine("Olen esimerkki Virtual Methodista.");
        }
    }
    class child2 : classbase
    {
        public override void message()
        {
            Console.WriteLine("Olen esimerkki lapsiluokasta.");
        }
    }
    class child3 : classbase
    {
    }
}