using System;

namespace Epam.Task4.IntOrNot
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter string: ");
            string str = Console.ReadLine();

            if (str.IsInteger())
            {
                Console.WriteLine("It is integer");
            }
            else
            {
                Console.WriteLine("It is not integer");
            }
        }
    }
}
