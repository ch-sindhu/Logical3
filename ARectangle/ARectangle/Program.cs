using System;

namespace ARectangle
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Length");
            double length = Convert.ToDouble(Console.ReadLine()); 
            Console.WriteLine("Enter Breadth");
            double breadth = Convert.ToDouble(Console.ReadLine());
            double Area = length * breadth;
            Console.WriteLine("Area of Rectangle " + Area);
        }
    }
}
