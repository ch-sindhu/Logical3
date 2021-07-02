using System;

namespace asceordesc
{
    class Program
    {
        static void Main(string[] args)
        {

            int i;
            int[] a = new int[5];
            Console.Write("Enter the Number of values to be Sort : ");
            int n = Convert.ToInt16(Console.ReadLine());
            for (i = 1; i <= n; i++)
            {
                Console.Write("Enter the No " + i + ":");

                a[i] = Convert.ToInt32(Console.ReadLine());
            }

            for (i = 1; i <= n; i++)
            {
                for (int j = 1; j <= n - 1; j++)
                {
                    if (a[j] > a[j + 1])
                    {
                        int temp = a[j];
                        a[j] = a[j + 1];
                        a[j + 1] = temp;
                    }
                }
            }

            Console.Write("Ascending Sort : ");
            for (i = 1; i <= n; i++)
            {
                Console.Write(a[i] + " ");
            }
            Console.Write("Desecnding Sort : ");
            for (i = n; i >= 1; i--)
            {
                Console.Write(a[i] + " ");
            }
        }   
    }
}
