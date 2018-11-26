using System;

namespace Epam.Task1.X_mas_Tree
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter number n: ");
            int n = int.Parse(Console.ReadLine());

            for (int l = 1; l <= n; l++)
            {
                for (int i = 1; i <= l; i++)
                {
                    for (int j = 1; j <= n - i; j++)
                        Console.Write(' ');
                    for (int k = 1; k <= i; k++)
                        Console.Write('*');
                    for (int p = 1; p <= i - 1; p++)
                        Console.Write('*');
                    Console.WriteLine();
                }
            }
        }
    }
}
