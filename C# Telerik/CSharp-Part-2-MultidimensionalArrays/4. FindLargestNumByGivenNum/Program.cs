using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4.FindLargestNumByGivenNum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] Arr = ReadArr();
            //int[] Arr = new int[] { 1, 2, 3, 4, 10, 11, 129 };

            //Read valid K number
            string input = "";
            int numberK = 0;
            do
            {
                Console.Write("Enter integer K: ");
                input = Console.ReadLine();
            } while (!int.TryParse(input, out numberK));

            Array.Sort(Arr);
            Console.WriteLine("\nArray is: {0}", string.Join(", ", Arr));

            int index = Array.BinarySearch(Arr, numberK);

            //Find bigger number who is less than number K
            if (numberK < 0)
            {
                Console.WriteLine("\nThere is no number N <= K !");
            }
            else
            {
                if (index >= 0)
                {
                    Console.WriteLine("\nThe the searched number is at index: {0}", index);
                }
                else
                {
                    Console.WriteLine("\nThe largest number N <= K is {0} at index: {1}",Arr[~index - 1] ,~index - 1);
                }
            }

            
            
        }
        public static int[] ReadArr()
        {
            //Read valid arr length
            string input = "";
            int ArrLength = 0;
            do
            {
                Console.Write("Enter array length (N > 0): ");
                input = Console.ReadLine();
            } while (!int.TryParse(input, out ArrLength));

            int[] Arr = new int[ArrLength];

            //Read valid array values
            for (int i = 0; i < ArrLength; i++)
            {
                do
                {
                    Console.Write("Enter int. val {0}: ", i + 1);
                    input = Console.ReadLine();
                } while (!int.TryParse(input, out Arr[i]));
            }

            return (int[])Arr.Clone();
        }
    }
}
