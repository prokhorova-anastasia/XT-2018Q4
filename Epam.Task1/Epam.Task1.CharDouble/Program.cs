using System;
using System.Text;

namespace Epam.Task1.CharDouble
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter first string: ");
            string s1 = Console.ReadLine();
            Console.WriteLine("Enter second string: ");
            string s2 = Console.ReadLine();

            var sb = new StringBuilder();

            for (int i = 0; i < s1.Length; i++)
            {
                sb.Append(s1[i]);
                if (s2.Contains(s1[i]))
                    sb.Append(s1[i]);
            }


            Console.WriteLine("Double string: {0}", sb);
        }
    }
}
