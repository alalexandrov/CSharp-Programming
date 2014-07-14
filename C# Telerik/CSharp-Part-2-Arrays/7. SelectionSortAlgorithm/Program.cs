using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7.SelectionSortAlgorithm
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] Arr = { 9, 8, 7, 6, 5, 4, 3, 2, 1, 0 };
            Console.WriteLine("Array: {0}", string.Join(", ", Arr));

            //Simple implementation of selection sort
            for (int i = 0; i < Arr.Length - 1; i++)
            {
                for (int j = i + 1; j < Arr.Length; j++)
                {
                    if (Arr[i] > Arr[j])
                    {
                        int temp = Arr[i];
                        Arr[i] = Arr[j];
                        Arr[j] = temp;
                    }
                }
            }

            Console.Write("Sorted array: ");
            Console.WriteLine(string.Join(", ", Arr));
        }
    }
}
