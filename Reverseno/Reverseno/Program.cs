using System;

namespace Reverseno
{
    class Program
    {
        static void Main(string[] args)
        {
            int reverse=0;
            Console.WriteLine("Enter a 5-digit no");
            int no = Convert.ToInt32(Console.ReadLine());
            
            while(no>0)
            {
                int remainder = no % 10; ;
                reverse = (reverse * 10) + remainder;
                no = no / 10;
            }
            Console.WriteLine("reverse no is" + reverse);
        }
       
    }
}
