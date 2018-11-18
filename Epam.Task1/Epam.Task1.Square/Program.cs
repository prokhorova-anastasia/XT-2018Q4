using System;

namespace Epam.Task1.Square
{
    class Program
    {
        static void Square(int N)
        {
            for (int i = 1; i <= N; i++)
            {
                for (int j = 1; j <= N; j++)
                    if ((i == N / 2 + 1) && (j == N / 2 + 1))
                        Console.Write(' ');
                    else Console.Write('*');
                Console.WriteLine("\n");
            }
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number: ");
            int N = int.Parse(Console.ReadLine());

            Square(N);
        }
    }
}
