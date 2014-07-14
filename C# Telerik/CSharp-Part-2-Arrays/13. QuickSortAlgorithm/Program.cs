using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13.QuickSortAlgorithm
{
    class Program
    {
        static void Main()
        {
            string[] Arr = { "1", "23", "44", "17", "0" };
            Console.WriteLine("Array: {0}", string.Join(", ", Arr));

            QuickSort(Arr, 0, Arr.Length - 1);

            Console.WriteLine("Sorted array: {0}", string.Join(", ", Arr));
        }
        static void SwapElements(string[] arr, int first, int second)
        {
            string temp = arr[first];
            arr[first] = arr[second];
            arr[second] = temp;
        }

        static int Partition(string[] arr, int left, int right, int pivotIndex)
        {
            string pivot = arr[pivotIndex];
            SwapElements(arr, pivotIndex, right);

            int storeIndex = left;
            for (int i = left; i < right; i++)
            {
                if (string.Compare(arr[i], pivot) <= 0)
                {
                    SwapElements(arr, storeIndex, i);
                    storeIndex++;
                }
            }
            SwapElements(arr, storeIndex, right);
            return storeIndex;
        }

        static void QuickSort(string[] arr, int left, int right)
        {
            if (left >= right)
            {
                return;
            }

            int pivotIndex = left + (right + 1 - left) / 2;
            int pivotNewIndex = Partition(arr, left, right, pivotIndex);
            QuickSort(arr, left, pivotNewIndex - 1);
            QuickSort(arr, pivotNewIndex + 1, right);
        }
    }
}
