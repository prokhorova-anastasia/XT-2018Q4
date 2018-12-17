using System;
using System.Threading;

namespace Epam.Task4.SortingUnit
{
    public class Program
    {
        public delegate void ThreadSort<T>(T[] elements, int left, int right, Func<T, T, int> comparator);

        public delegate void MethodContainer();

        public static event MethodContainer SortEnded;

        public static int AgeComparator(Person x, Person y)
        {
            if (x is null)
            {
                return -1;
            }

            if (y is null)
            {
                return 1;
            }

            if (x == y)
            {
                return 0;
            }

            if (x.Age > y.Age)
            {
                return 1;
            }
            else
            {
                return -1;
            }
        }

        public static void CustomQSort<T>(T[] elements, int l, int r, Func<T, T, int> comparator)
        {
            int i = l, j = r;
            T pivot = elements[(l + r) / 2];

            while (i <= j)
            {
                while (comparator(elements[i], pivot) < 0)
                {
                    i++;
                }

                while (comparator(elements[j], pivot) > 0)
                {
                    j--;
                }

                if (i <= j)
                {
                    T tmp = elements[i];
                    elements[i] = elements[j];
                    elements[j] = tmp;

                    i++;
                    j--;
                }
            }

            if (l < j)
            {
                CustomQSort(elements, l, j, comparator);
            }

            if (i < r)
            {
                CustomQSort(elements, i, r, comparator);
            }
        }

        public static void ThreadCustomQSort<T>(T[] elements, int l, int r, Func<T, T, int> comparator)
        {
            ThreadSort<T> func = new ThreadSort<T>(CustomQSort);
            Thread th1 = new Thread(() => func(elements, l, r, comparator));
            th1.Start();
            th1.Join();
            SortEnded();
        }

        public static void PersonsPrinter(Person[] elements)
        {
            foreach (var i in elements)
            {
                Console.WriteLine("{0} {1}", i.Name, i.Age);
            }

            Console.WriteLine();
        }

        public static void Main(string[] args)
        {
            Person[] person = new Person[10];
            SortedEnd sortedEnd = new SortedEnd();
            SortEnded += sortedEnd.Message;
            person[0] = new Person { Name = "Anna", Age = 30 };
            person[1] = new Person { Name = "Andey", Age = 20 };
            person[2] = new Person { Name = "Selena", Age = 40 };
            person[3] = new Person { Name = "Hue", Age = 32 };
            person[4] = new Person { Name = "Kim", Age = 38 };
            person[5] = new Person { Name = "Kylie", Age = 21 };
            person[6] = new Person { Name = "Kendall", Age = 22 };
            person[7] = new Person { Name = "Kortney", Age = 39 };
            person[8] = new Person { Name = "Khloe", Age = 34 };
            person[9] = new Person { Name = "Kris", Age = 63 };

            Console.WriteLine("Original list of persons for sorting:");
            PersonsPrinter(person);

            ThreadCustomQSort(person, 0, person.Length - 1, AgeComparator);

            Console.WriteLine("Sorted by age list of persones:");
            PersonsPrinter(person);
        }

        private static void Program_SortEnded()
        {
            throw new NotImplementedException();
        }
    }
}
