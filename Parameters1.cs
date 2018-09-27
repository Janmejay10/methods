using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace methods
{
    public class Parameters1
    {
        public static void multiply(int limit)
        {
            
            Console.WriteLine("eneter your number");
            int a = Convert.ToInt32(Console.ReadLine());
            while (a <= limit)
            {
                a = a + 2;
                Console.WriteLine(a);
                
            }
            
        }
        public static void Main(string[] args)
        {
            Parameters1.multiply(30); 
            Console.Read();
            
        }
    }
}

