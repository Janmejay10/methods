using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace methods
{
    class MethodNoParaNoReturn
    {
        class Name
        {
            static void CompanyName()
            {
                Console.WriteLine("tell me the company name");
                string s1 = Console.ReadLine();
                Console.WriteLine("your company name is: " + s1);
            }

            
            static void Main(string[] args)
            {              
                CompanyName();
                Console.Read();
            }
        }
    }
}
