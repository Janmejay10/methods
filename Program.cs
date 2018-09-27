using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace methods
{
   public class Program
    {
        public void evenNum()
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
            Program a1 = new Program();
            a1.evenNum();
            Console.Read();
        }
    }
}
