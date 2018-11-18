using System;

namespace Epam.Task1.Simple
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number: ");
            int n = int.Parse(Console.ReadLine());
            bool f = true;

            for (int i = 2; i <= Math.Sqrt(n); i++)
            {
                if (n % i == 0)
                {
                    f = false;
                    Console.WriteLine("The number is not simple!");
                    break;
                }
            }

            if (f == true)
                Console.WriteLine("The number is simple!");
        }
    }
}
