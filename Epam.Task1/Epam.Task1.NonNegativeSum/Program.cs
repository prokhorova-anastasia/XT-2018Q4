using System;

namespace Epam.Task1.NonNegativeSum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[10];

            Random r = new Random();

            for (int i = 0; i < 10; i++)
            {
                arr[i] = r.Next(-100, 100);
            }

            int sum = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] >= 0)
                {
                    sum += arr[i];
                }
            }

            Console.WriteLine("Sum of non-negative: {0}", sum);
        }
    }
}
