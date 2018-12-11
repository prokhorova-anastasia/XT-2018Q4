using System;
using System.Collections.Generic;

namespace Epam.Task3.Lost
{
    class Program
    {
        public static int SearchOfLast(Queue<int> roundOfPeople)
        {
            bool f = true;
            while (roundOfPeople.Count != 1)
            {
                if (f)
                {
                    roundOfPeople.Enqueue(roundOfPeople.Dequeue());
                    f = !f;
                }
                else
                {
                    roundOfPeople.Dequeue();
                    f = !f;
                }
            }

            return roundOfPeople.Peek();
        }

        static void Main(string[] args)
        {
            try
            {
                Queue<int> roundOfPeople = new Queue<int>();

                Console.WriteLine("Enter n: ");
                int.TryParse(Console.ReadLine(), out int n);
                for (int i = 0; i < n; i++)
                {
                    roundOfPeople.Enqueue(i);
                }

                Console.WriteLine("Last is {0}", SearchOfLast(roundOfPeople));
            }
            catch
            {
                Console.WriteLine("Error. Wrong input");
            }
        }
    }
}
