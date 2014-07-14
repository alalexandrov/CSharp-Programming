using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15.GeneratingAllVariationsByGivenNk
{
    class Program
    {
        public static void Main()
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


            Console.WriteLine("The variations of {0} elements with {1} class are: ", ArrLength, numberK);
            GenerateVariations(Arr, numberK);
        }
        public static void GenerateVariations(int[] items, int k)
        {
            Generator(items, new int[k], 0);
        }

        private static void Generator(int[] items, int[] path, int startIndex)
        {
            if (startIndex == path.Length)
            {
                Console.Write("{ ");
                Console.Write(string.Join(", ", path));
                Console.WriteLine(" }");
                return;
            }

            for (int i = 0; i < items.Length; i++)
            {
                path[startIndex] = items[i];
                Generator(items, path, startIndex + 1);
            }
        }
    }
}
