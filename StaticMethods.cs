using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace methods
{
     class StaticMethods
    {
        public static void evenNum()
        {
            Console.WriteLine("eneter your number");
            int a = Convert.ToInt32(Console.ReadLine());
            if (a % 2 == 2)
            {
                Console.WriteLine("given number is even");
            }
            else
            {
                Console.WriteLine("number is odd");
            }
        }
        public static void Main(string[] args)
        {
            StaticMethods a1 = new StaticMethods(); // static method is called by the instance of class(type)
            Console.Read();                 // here we do not have to use the reference 
        }
    }
}
