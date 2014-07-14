using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11.FindIndexOfElemWIthBinarySearch
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] Arr = { 11, 2, 3, 4, 5, 6, 7, 8, 9 };

            Array.Sort(Arr);
            //Binary search implementation
            int leftIndex = 0;
            int rightIndex = Arr.Length - 1;
            int searchValue = 8;
            int indexOfValue = -1;

            while (leftIndex <= rightIndex)
            {
                int middle = (leftIndex + rightIndex) / 2;
                if (Arr[middle] == searchValue)
                {
                    indexOfValue = middle;
                    break;
                }
                else if(Arr[middle] > searchValue)
                {
                    rightIndex = middle - 1;
                }
                else
                {
                    leftIndex = middle + 1;
                }
            }

            Console.WriteLine("Array: {0}", String.Join(", ", Arr));
            Console.WriteLine("Index of value '{0}' is: [{1}]", searchValue, indexOfValue);
        }
    }
}
