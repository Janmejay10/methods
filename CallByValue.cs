using System;
namespace methods
{
    class CallByValue
    {
        
        public void Show(int a)
        {
            a = 10 + a; //here the value are being Manipulated value  
            Console.WriteLine("Value inside the show function :" + a);
             
        }
        
        static void Main(string[] args)
        {
            Console.WriteLine("enter a value");
            int a = Convert.ToInt32(Console.ReadLine());
            CallByValue c1 = new CallByValue();   
            Console.WriteLine("Value before calling the function :" + a);
            c1.Show(a); // Calling Function by passing value            
            Console.WriteLine("Value after calling the function :" + a);
            Console.Read();
        }
    }
}