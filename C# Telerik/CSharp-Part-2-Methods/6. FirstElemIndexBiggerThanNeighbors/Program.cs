using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6.FirstElemIndexBiggerThanNeighbors
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = { 1, 2, 2, 2, 1, 0, 44, 3 };

            //Test
            //numbers = new int[] { 1, 1, 1, 1, 1, 1 };

            Console.WriteLine("Array: {0}", string.Join(", ", numbers));

            //Get first element bigger than neighbors
            int ElemIndex = GetFirstBiggerNeighbor(numbers);

            Console.WriteLine("The first element bigger than its neighbors is at index: {0}", ElemIndex);
        }

        public static int GetFirstBiggerNeighbor(int[] Arr)
        {
            if (Arr != null)
            {
                for (int i = 0; i < Arr.Length; i++)
                {
                    if (IsBiggerThanNeighbors(i, Arr))
                    {
                        return i;
                    }
                }
                return -1;
            }
            else
            {
                throw new ArgumentException("The given array can't be null !");
            }
        }
        public static bool IsBiggerThanNeighbors(int position, int[] Arr)
        {
            if (Arr != null)
            {
                if (position < 0 || position >= Arr.Length)
                {
                    throw new ArgumentException("Invalid given position !");
                }

                if (position != 0 && position != Arr.Length - 1)
                {
                    if (Arr[position] > Arr[position - 1] &&
                        Arr[position] > Arr[position + 1])
                    {
                        return true;
                    }
                }

                return false;
            }
            else
            {
                throw new ArgumentException("The given array can't be null !");
            }
        }
    }
}
