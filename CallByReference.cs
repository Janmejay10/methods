using System;
namespace methods
{
    class CallByReference
    {

        public void Show(ref int a)
        {
            a = 10 + a; //here the value are being Manipulated value  
            Console.WriteLine("Value inside the show function :" + a);

        }

        static void Main(string[] args)
        {
            Console.WriteLine("enter a value");
            int a = Convert.ToInt32(Console.ReadLine());
            CallByReference c1 = new CallByReference();
            Console.WriteLine("Value before calling the function :" + a);
            c1.Show(ref a); // Calling Function by passing reference            
            Console.WriteLine("Value after calling the function :" + a);
            Console.Read();
        }
    }
}