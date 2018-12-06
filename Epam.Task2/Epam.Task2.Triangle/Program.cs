using System;

namespace Epam.Task2.Triangle
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Triangle triangle = new Triangle();
                Console.WriteLine("Enter triangle side a: ");
                triangle.A = double.Parse(Console.ReadLine());

                Console.WriteLine("Enter triangle side b: ");
                triangle.B = double.Parse(Console.ReadLine());

                Console.WriteLine("Enter triangle side c: ");
                triangle.C = double.Parse(Console.ReadLine());

                if ((triangle.A + triangle.B > triangle.C) && (triangle.A + triangle.C > triangle.B) && (triangle.B + triangle.C > triangle.A))
                {
                    double area = triangle.Area;
                    double perimeter = triangle.Perimeter;

                    Console.WriteLine("Perimeter = {0}", perimeter);
                    Console.WriteLine("Area = {0}", area);
                }
                else
                {
                    Console.WriteLine("Triangle is not exist!");
                }
            }
            catch
            {
                Console.WriteLine("You have entered wrong data! May be violated the condition of the existence of a triangle.");
            }
        }
    }
}
