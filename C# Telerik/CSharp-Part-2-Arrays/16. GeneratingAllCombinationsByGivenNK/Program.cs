using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _16.GeneratingAllCombinationsByGivenNK
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

            Console.WriteLine("The combinations of {0} elements with {1} class are: ", ArrLength, numberK);
            GenerateCombinations(Arr, numberK);
        }
        
        public static void GenerateCombinations(int[] items, int k)
        {
            Generator(items, new int[k], 0, 0);    
        }

        private static void Generator(int[] items, int[] path, int PathStartIndex, int ItemsStartIndex)
        {
            if (PathStartIndex == path.Length)
            {
                Console.Write("{ ");
                Console.Write(string.Join(", ", path));
                Console.WriteLine(" }");
                return;
            }

            for (int i = ItemsStartIndex; i < items.Length; i++)
            {
                path[PathStartIndex] = items[i];
                Generator(items, path, PathStartIndex + 1, i + 1);
            }
        }
    }
}
