using System;

namespace Epam.Task1.SumOfNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int sum1 = 0;
            int sum2 = 0;

            for (int i = 1; i < 10; i++)
                if (i % 3 == 0 || i % 5 == 0)
                    sum1 += i;
            int i3 = 3;
            int i5 = 5;
            while (i3 < 10 || i5 < 10)
            {
                if (i3 != i5)
                {
                    sum2 = sum2 + i3 + i5;
                }
                else sum2 = sum2 + i3;

               // sum2 = i3 == i5? sum2 + i3: sum2 + i3 + i5;
                i3 += 3;
                i5 += 5;
            }


            Console.WriteLine("Sum of numbers: {0} ?= {1}", sum1, sum2);
        }
    }
}
