using System;

namespace ACircle
{
    class Program
    {
        static void Main(string[] args)
        {
            double A;
            Console.WriteLine("Enter the radius");
            int r = Convert.ToInt32(Console.ReadLine());
            A = (3.14) * r * r;
            Console.WriteLine("Area of Cirle " + A);

        }
    }
}
