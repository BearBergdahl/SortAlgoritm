using System.Collections.Generic;

namespace SortAlgoritm
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 1, 33, 1, 3, 6, 4, 67, 7, 9, 7, 6, 48, 49, 9, 42, 11, 3, 4, 44, 43, 5, 66, 17, 98, 29, 210, 11, 9912, 413, 114, };
            insertionSort(arr);
            void insertionSort(int[] arr)
            {
                int n1 = arr.Length;
                int n2 = 0;
                for (int i = 1; i < n1; ++i)
                {
                    int key = arr[i];
                    n2 = i - 1;
                    while (n2 >= 0 && arr[n2] > key)
                    {
                        arr[n2 + 1] = arr[n2];
                        n2 = n2 - 1;
                    }
                    arr[n2 + 1] = key;
                }
                Console.WriteLine($"Den inre loopen gör {n2} operationer på varje n1-loop");
                Console.WriteLine($"Totala antalet steg i yttre loopen n1: {n1}");
                Console.WriteLine("Vi gör n1*n2 operationer där n2 är nära n1: " + n1 * n2);
            }

            void quickSort(int[] arr, int begin, int end)
            {
                if (begin < end)
                {
                    int partitionIndex = partition(arr, begin, end);

                    quickSort(arr, begin, partitionIndex - 1);
                    quickSort(arr, partitionIndex + 1, end);
                }
            }

            int partition(int[] arr, int begin, int end)
            {
                int pivot = arr[end];
                int i = (begin - 1);

                for (int j = begin; j < end; j++)
                {
                    if (arr[j] <= pivot)
                    {
                        i++;
                        // tuple swap
                        (arr[j], arr[i]) = (arr[i], arr[j]);
                    }
                }

                int swapTemp = arr[i + 1];
                arr[i + 1] = arr[end];
                arr[end] = swapTemp;

                return i + 1;
            }
        }
    }
}