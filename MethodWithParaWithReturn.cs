using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace methods
{
    class MethodWithParaWithReturn
    {
        static int factorial(int n)
        {
            int f = 1;
            for(int i = 1; i <= n; i++)
            {
                f = f * i;
            }
            return f;
        }

        static void Main(string[] args)
        {
            Console.WriteLine("enter the number for factorial");
            int n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("factorial of your number is: " + factorial(n));
            Console.Read();
        }
    }

}
