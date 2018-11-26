using System;

namespace Epam.Task1.Square
{
    class Program
    {
        static void Square(int n)
        {
            for (int i = 1; i <= n; i++)
            {
                for (int j = 1; j <= n; j++)
                    if ((i == n / 2 + 1) && (j == n / 2 + 1))
                        Console.Write(' ');
                    else Console.Write('*');
                Console.WriteLine("\n");
            }
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Enter a positive, integer and odd number: ");
            int n;

            try
            {
                n = int.Parse(Console.ReadLine());
                while (n < 1 || n % 1 != 0 || n % 2 == 0)
                {
                    Console.WriteLine("The number should be positive, integer and odd number. Enter a new one: ");
                    n = int.Parse(Console.ReadLine());
                }
            }
            catch
            {
                Console.WriteLine("Error! You should enter a positive, integer and odd number. Enter a new one: ");
                n = int.Parse(Console.ReadLine());
            }

            Square(n);
        }
    }
}
