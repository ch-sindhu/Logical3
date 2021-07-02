using System;

namespace Totavg
{
    class Program
    {
        static void Main(string[] args)
        {
            string div;
            Console.WriteLine("Enter Rollnumber");
            int rol = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter student name");
            string name = Console.ReadLine();
            Console.WriteLine("Enter marks for maths");
            double math = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter marks for physics");
            double phy = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter marks for chemistry");
            double chem = Convert.ToDouble(Console.ReadLine());
            double total= math + phy + chem;
            double per = total / 3;
            if (per >= 60)
                div = "First";
            else if (per <= 60 && per >= 48)
                div = "second";
            else if (per <= 48 && per >= 36)
                div = "pass";
            else
                div = "Fail";
            Console.WriteLine("total marks={0}\n percentage ={1}\n Division={2}", total, per, div);

            
            






        }
    }
}
