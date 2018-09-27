using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace methods
{
   static class StaticMethod4Extension
    {
        public static void test3(this ExtensionMethod em)
        {
            Console.WriteLine("method : 3");
        }
    }
}
