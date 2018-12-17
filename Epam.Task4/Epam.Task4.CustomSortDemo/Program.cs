using System;

namespace Epam.Task4.CustomSortDemo
{
    public class Program
    {
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

        public static int StringByAlphaComparator(string x, string y)
        {
            if (x.CompareTo(y) > 0)
            {
                return 1;
            }
            else
            {
                return -1;
            }
        }

        public static int StringByLengthComparator(string x, string y)
        {
            if (x is null)
            {
                return -1;
            }

            if (y is null)
            {
                return 1;
            }

            if (ReferenceEquals(x, y))
            {
                return 0;
            }

            if (x.Length > y.Length)
            {
                return 1;
            }
            else if (x.Length < y.Length)
            {
                return -1;
            }
            else
            {
                return StringByAlphaComparator(x, y);
            }
        }

        public static void Main(string[] args)
        {
            int n = 5;
            string[] arrayOfStrings = new string[n];

            Console.WriteLine("Enter {0} string, that you want to sort by it's length: ", n);
            for (int i = 0; i < n; i++)
            {
                arrayOfStrings[i] = Console.ReadLine();
            }

            Console.WriteLine();

            CustomQSort(arrayOfStrings, 0, arrayOfStrings.Length - 1, StringByLengthComparator);

            Console.WriteLine("Sorted strings: ");
            for (int i = 0; i < n; i++)
            {
               Console.WriteLine(arrayOfStrings[i]);
            }
        }
    }
}
