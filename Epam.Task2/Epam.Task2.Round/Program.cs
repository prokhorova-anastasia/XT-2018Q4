using System;

namespace Epam.Task2.Round
{
    class Program
    {
        static void Main(string[] args)
        {
            try 
            {
                Round round = new Round();

                Console.WriteLine("Enter x: ");
                round.X = double.Parse(Console.ReadLine());

                Console.WriteLine("Enter y: ");
                round.Y = double.Parse(Console.ReadLine());

                Console.WriteLine("Enter radius: ");
                round.Radius = double.Parse(Console.ReadLine());

                double area = round.Area;
                double lengthRound = round.LengthRound;

                Console.WriteLine("x = {0}, y = {1}, radius = {2}", round.X, round.Y, round.Radius);

                Console.WriteLine("Area = {0}", area);
                Console.WriteLine("Length = {0}", lengthRound);

            }
            catch
            {
                Console.WriteLine("You have entered wrong data!");
            }
        }
    }
}
