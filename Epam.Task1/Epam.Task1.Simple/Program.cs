using System;

namespace Epam.Task1.Simple
{
    class Program
    {
        static bool Simple(int n)
        {
            for (int i = 2; i <= Math.Sqrt(n); i++)
            {
                if (n % i == 0)
                {
                    Console.WriteLine("The number is not simple!");
                    return false;
                }
            }
            Console.WriteLine("The number is simple!");
            return true;
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

            Simple(n);
        }
    }
}
