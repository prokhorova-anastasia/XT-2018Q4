using System;
using System.Text;


namespace Epam.Task1.Sequence
{
    class Program
    {
        static string Sequence(int N)
        {
            StringBuilder sb = new StringBuilder("1");

            for (int i = 2; i <= N; i++)
            {
                sb.Append(", ").Append(i.ToString());
            }

            string s;
            s = sb.ToString();

            return s;
        }


        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number: ");
            int N = int.Parse(Console.ReadLine());

            string sequence = Sequence(N);

            Console.WriteLine("Sequence: {0}", sequence);
        }
    }
}
