using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6.KElemWithMaxSum
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = "";
            //Read valid array length
            int ArrLength = 0;
            do
            {
                Console.Write("Enter array lenght (N > 0): ");
                input = Console.ReadLine();
            } while (!int.TryParse(input, out ArrLength) || ArrLength <= 0);

            int[] Arr = new int[ArrLength];

            //Read array elements
            for (int i = 0; i < Arr.Length; i++)
            {
                do
                {
                    Console.Write("Enter el.{0}: ", (i + 1));
                    input = Console.ReadLine();
                } while (!int.TryParse(input, out Arr[i]));
            }

            //Read valid К
            int numberK = 0;
            do
            {
                Console.Write("Enter K (N > K > 0): ");
                input = Console.ReadLine();
            } while (!int.TryParse(input, out numberK) || numberK <= 0 || numberK > ArrLength);


            //Arr = new int[] { 11, 2, 33, 4, 5, 6 };
            //numberK = 3;

            //Find in the array those K elements that have maximal sum
            int sum = 0;
            int MaxSum = int.MinValue;
            for (int i = 0; i <= Arr.Length - numberK; i++)
            {
                for (int j = i; j < i + numberK; j++)
                {
                    sum += Arr[j];
                    if (sum > MaxSum)
                    {
                        MaxSum = sum;
                    }
                }
                sum = 0;
            }

            Console.Write("Array: ");
            Console.WriteLine(string.Join(" ", Arr));
            Console.WriteLine("The maximal sum of K elements is: {0}", MaxSum);
        }
    }
}
