using System;

namespace Epam.Task0.Sequence
{
    class Program
    {
        static void Sequence(int n)
        {
            Console.Write("1");
            for (int i = 2; i <= n; i++)
            {
                Console.Write(", {0}", i);
            }
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Enter a positive and integer number: ");
            int n;

            try
            {
                n = int.Parse(Console.ReadLine());
                while (n < 1 || n % 1 != 0)
                {
                    Console.WriteLine("The number should be positive and integer. Enter a new one: ");
                    n = int.Parse(Console.ReadLine());
                }
            }
            catch
            {
                Console.WriteLine("Error! You should enter a positive and integer number. Enter a new one: ");
                n = int.Parse(Console.ReadLine());
            }

            Sequence(n);
        }
    }
}
