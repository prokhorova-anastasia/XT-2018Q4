using System;

namespace Epam.Task1.AverageStringLength
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter string: ");
            string s = Console.ReadLine();

            int averageLength = 0;
            int count = 0; 
            int temp_count = 0;

            if (s.Length != 0)
            {
                for (int i = 0; i < s.Length; i++)
                {
                    if (Char.IsLetter(s[i]) || char.IsNumber(s[i]))
                    {
                        temp_count++;
                    }
                    if (char.IsPunctuation(s[i]) || char.IsSeparator(s[i]) || i == s.Length - 1)
                    {
                        averageLength += temp_count;
                        count++;
                        temp_count = 0;
                    }
                }
                Console.WriteLine("Average string length: {0}", averageLength / count);
            }
            else
                Console.WriteLine("Average string length: 0");
        }
    }
}
