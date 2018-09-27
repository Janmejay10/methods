using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace methods
{
    class MethodParaButNoReturn
    {
        static void year(int x)
        {
            Console.WriteLine("enter the year");
            int y = Convert.ToInt32(Console.ReadLine());
            if(y % 4 == 0)
            {
                Console.WriteLine( y +" is a leap year");
            }
            else
            {
                Console.WriteLine(y + " is not a leap year");
            }

        }

        static void Main(string[] args)
        {
            int x = 10;
            year(x);
            Console.Read();
        }

    }

    
}
