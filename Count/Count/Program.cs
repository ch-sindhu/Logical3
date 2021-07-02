using System;

namespace Count
{
    class Program
    {
        static void Main(string[] args)
        {
            
            int count = 0;
            Console.WriteLine("Enter any no");
            int num = Convert.ToInt32(Console.ReadLine());
            do
            {
                count ++;
                num /= 10;
            } while (num != 0);

            Console.WriteLine(" totaldigits "  + count);
        }
    }
}
