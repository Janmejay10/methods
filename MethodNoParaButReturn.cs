using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace methods
{
    class MethodNoParaButReturn
    {
        static int area()
        {
            Console.WriteLine("enter the length");
            int l = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter the breadth");
            int b = Convert.ToInt32(Console.ReadLine());
            int a = l * b;
            return a;
        }

        static void Main(string[] args)
        {
            int getmeresult = area();
            Console.WriteLine("area of the triangle is: " + getmeresult);
            Console.Read();

        }
    }

    
}
