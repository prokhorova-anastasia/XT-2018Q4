using System;

namespace Epam.Task1.Rectangle
{
    class Program
    {
        static void Main(string[] args)
        {
            int a;
            int b;

            try
            {
                Console.WriteLine("Enter a: ");
                a = int.Parse(Console.ReadLine());

                while(a <= 0)
                {
                    Console.WriteLine("a shoul be positive. Enter a: ");
                    a = int.Parse(Console.ReadLine());
                }

                Console.WriteLine("Enter b: ");
                b = int.Parse(Console.ReadLine());

                while (b <= 0)
                {
                    Console.WriteLine("b shoul be positive. Enter a: ");
                    b = int.Parse(Console.ReadLine());
                }

                Console.WriteLine("Area rectangle: {0}", a * b);
            }
            catch
            {
                Console.WriteLine("Error. You should enter positive numbers!");
            }
        }
    }
}
