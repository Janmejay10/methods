using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace methods
{
    class Parameters2
    {
        static int calc(int x, int y, int z)
        {
            int a = x;
            int b = y;
            int c = z;
            int result = x + y * z;
            return result;


        }

        static void Main(string[] args)
        {
            Console.WriteLine("enter the first number you want");
            int x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter the second number you want");
            int y = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter the third number you want");
            int z = Convert.ToInt32(Console.ReadLine());

            int sum = calc(x, y, z);
            Console.WriteLine("the total sum is: " + sum);
            Console.Read();

        }

    }
    
}
