using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
namespace ConsoleApplication14
{
    abstract class AbstractMethod
    {
        public int add(int i, int j)
        {
            return i + j;
        }
        public abstract int mul(int i, int j);
    }
    class test1 : AbstractMethod
    {
        public override int mul(int i, int j)
        {
            return i * j;
        }
    }
    class test2 : AbstractMethod
    {
        public override int mul(int i, int j)
        {
            return i - j;
        }
    }
    class test3 : test2
    {
        public override int mul(int i, int j)
        {
            return i + j;
        }
    }
    class myclass 
    {
        static void main(string[] args)
        {
            test1 ob = new test1();
            int a = ob.mul(2, 4);
            AbstractMethod ob1 = new test1();
            int b = ob1.mul(4, 2);
            AbstractMethod ob2 = new test2();
            int c = ob2.mul(4, 2);
            Console.Write("{0},{1},{2}", a, b, c);
            Console.ReadLine();
        }
    }
}