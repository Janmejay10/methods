using System;
namespace methods
{
    class CallByValue1
    {

        public void Show(string s1)
        {
            Console.WriteLine("enter  a second your name");
            string s2 = Console.ReadLine();
            s1 = s2; //here the value are being Manipulated value  
            Console.WriteLine("Value inside the show function :" + s1);

        }

        static void Main(string[] args)
        {
            Console.WriteLine("enter a your name");
            string s1 = Console.ReadLine();
            CallByValue1 c1 = new CallByValue1();
            Console.WriteLine("name before calling the function :" + s1);
            c1.Show(s1); // Calling Function by passing value            
            Console.WriteLine("name after calling the function :" + s1);
            Console.Read();
        }
    }
}