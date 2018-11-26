using System;

namespace Epam.Task1.ArrayProcessing
{
    class Program
    {
        static void QuickSort(ref int[] arr, int start, int end)
        {

            if (start >= end) 
            {
                return;
            }

            int pivot = arr[(start + end) / 2];
            int temp;

            int i = start;
            int j = end;

            while(i <= j)
            {
                while (arr[i] < pivot)
                {
                    i++;
                }
                while (arr[j] > pivot)
                {
                    j--;
                }
                if (i <= j)
                {
                    temp = arr[i];
                    arr[i] = arr[j];
                    arr[j] = temp;
                    i++;
                    j--;
                }
            }

            QuickSort(ref arr, start, j);
            QuickSort(ref arr, i, end);

        }

        static int Max(int[] arr)
        {
            int max = arr[0];
            for (int i = 1; i < arr.Length; i++)
            {
                if(max < arr[i])
                {
                    max = arr[i];
                }
            }

            return max;
        }

        static int Min(int[] arr)
        {
            int min = arr[0];
            for (int i = 1; i < arr.Length; i++)
            {
                if (min > arr[i])
                {
                    min = arr[i];
                }
            }

            return min;
        }

        static void Main(string[] args)
        {
            int[] arr = new int[10];

            Random r = new Random();
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = r.Next(100);
            }

            Console.WriteLine("Array: ");
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write("{0} ", arr[i]);
            }

            Console.WriteLine();

            Console.WriteLine("Maximum of elements: {0}", Max(arr));
            Console.WriteLine("Minimum of elements: {0}", Min(arr));

            Console.WriteLine("Sorted array: ");
            QuickSort(ref arr, 0, arr.Length - 1);

            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write("{0} ", arr[i]);
            }

        }
    }
}
