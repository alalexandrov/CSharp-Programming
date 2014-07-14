using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4.NumberOccurencesInArrCount
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = { 1, 2, 4, 5, 6, 777, 7, 7, 77, 74, 4, 2, 1 };
            int GivenNum = 7;

            // Get occurences of GivenNum int numbers array
            int occurences = GetCount(GivenNum, numbers);

            Console.WriteLine("Array {0}", string.Join(", ", numbers));
            Console.WriteLine("The occurences of {0} is: {1}", GivenNum, occurences);

            //Test
            //occurences = GetCount(GivenNum, null);

        }
        public static int GetCount(int number, int[] arr)
        {
            if (arr != null)
            {
                int count = 0;
                for (int i = 0; i < arr.Length; i++)
                {
                    if (arr[i] == number)
                    {
                        count++;
                    }
                }
                return count;
            }
            else
            {
                throw new ArgumentException("Given array can't be null !");
            }
        }
    }
}
