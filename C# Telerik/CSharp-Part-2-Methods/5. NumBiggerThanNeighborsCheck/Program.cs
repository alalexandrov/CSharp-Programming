using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5.NumBiggerThanNeighborsCheck
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = { 1, 2, 3, 2, 1, 0, 44, 3 };

            int position = 6;

            //Tests 
            //position = 1;
            //position = 0;
            //position = numbers.Length - 1;
            //position = -11;
            //position = 22;

            //Check if element at given position is bigger than neigbors
            bool answer = IsBiggerThanNeighbors(position, numbers);

            //answer = IsBiggerThanNeighbors(position, null);

            Console.WriteLine("Array: {0}", string.Join(", ", numbers));
            Console.WriteLine("The num in position {0} is bigger than its two neighbors ?: {1}", position, answer);
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
