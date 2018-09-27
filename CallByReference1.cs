using System;
namespace methods
{
    class CallByReference1
    {

        public void Show(ref string s1)
        {
            Console.WriteLine("enter  a second your name");
            string s2 = Console.ReadLine();
            s1 = s2; //here the value are being Manipulated value  
            Console.WriteLine("name inside the show function :" + s1);

        }

        static void Main(string[] args)
        {
            Console.WriteLine("enter a your name");
            string s1 = Console.ReadLine();
            CallByReference1 c1 = new CallByReference1();
            Console.WriteLine("name before calling the function :" + s1);
            c1.Show(ref s1); // Calling Function by passing value            
            Console.WriteLine("name after calling the function :" + s1);
            Console.Read();
        }
    }
}