using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace methods
{
    class TestExtensionMethod
    {
        static void Main(string[] args)
        {
            ExtensionMethod em = new ExtensionMethod();
            em.test1();
            em.test2();
            em.test3();
            Console.ReadLine();
        }
        
    }
}
