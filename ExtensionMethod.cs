using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace methods
{
    class ExtensionMethod
    {
        public void test1()
        {
            Console.WriteLine("method : 1");
        }
        public void test2()
        {
            Console.WriteLine("method : 2");
        }
        static void Main(string[] args)
        {
            ExtensionMethod em = new ExtensionMethod();
            em.test1();
            em.test2();
            Console.Read();
        }
    }
}
