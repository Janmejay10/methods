using System;
namespace methods
{
    class CallingByOut
    {

        public void Show(out int a)
        {
            int b = 10;
            a = b;
            a = 10 + a; //here the value are being Manipulated value  
            

        }

        static void Main(string[] args)
        {
            Console.WriteLine("enter a value");
            int a = Convert.ToInt32(Console.ReadLine());
            CallingByOut c1 = new CallingByOut();
            Console.WriteLine("Value before calling the function :" + a);
            c1.Show(out a);             
            Console.WriteLine("Value after calling the function :" + a);
            Console.Read();
        }
    }
}