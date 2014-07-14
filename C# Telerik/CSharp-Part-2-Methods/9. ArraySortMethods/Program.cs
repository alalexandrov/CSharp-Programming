using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9.ArraySortMethods
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };

            //numbers = new int[] { 9, 8, 7, 6, 5, 4, 3, 2, 1 };

            Console.WriteLine("Array: {0}", String.Join(", ", numbers));
            Sort(numbers, true);
            //Sort(numbers, false);

            Console.WriteLine("Sorted Array: {0}", String.Join(", ", numbers));
        }

        public static void Sort(int[] Arr, bool desc = false)
        {
            if (Arr == null)
            {
                throw new ArgumentException("The given array can't be null !");
            }

            if (!desc)
            {
                for (int i = 0; i < Arr.Length; i++)
                {
                    int MaxElIndex = GetMaxAfter(Arr.Length - i - 1, Arr);
                    if (i != MaxElIndex)
                    {
                        int temp = Arr[i];
                        Arr[i] = Arr[MaxElIndex];
                        Arr[MaxElIndex] = temp;
                    }
                }
            }
            else
            {
                for (int i = 0; i < Arr.Length; i++)
                {
                    int MaxElIndex = GetMaxAfter(i, Arr);
                    if (i != MaxElIndex)
                    {
                        int temp = Arr[i];
                        Arr[i] = Arr[MaxElIndex];
                        Arr[MaxElIndex] = temp;
                    }
                }
            }
        }
        public static int GetMaxAfter(int startIndex, int[] Arr)
        {
            if (Arr == null)
            {
                throw new ArgumentException("The given array can't be null !");
            }

            if (startIndex < 0 || startIndex > Arr.Length)
            {
                throw new ArgumentException("Invalid start index !");
            }
            
            //Getting index of max num in array by given start index
            int MaxNum = int.MinValue;
            int MaxNumIndex = 0;
            for (int i = startIndex; i < Arr.Length; i++)
            {
                if (Arr[i] > MaxNum)
                {
                    MaxNum = Arr[i];
                    MaxNumIndex = i;
                }
            }

            return MaxNumIndex;
        }
    }
}
