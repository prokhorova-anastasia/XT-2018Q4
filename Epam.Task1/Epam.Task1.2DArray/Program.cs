using System;

namespace Epam.Task1._2DArray
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter count of row: ");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter count of columns: ");
            int m = int.Parse(Console.ReadLine());

            Random r = new Random();

            int sum = 0;

            int[,] arr = new int[n, m];
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    arr[i, j] = r.Next(-100, 100);
                }
            }

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    if ((i + j) % 2 == 0)
                    {
                        sum += arr[i, j];
                    }
                }
            }

            Console.WriteLine("Sum of chetnoe: {0}", sum);
        }
    }
}
