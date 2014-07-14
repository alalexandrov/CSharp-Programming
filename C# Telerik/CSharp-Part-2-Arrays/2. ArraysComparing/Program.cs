using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.ArraysComparing
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = "";

            //Read valid array length
            int firstArrLength = 0;
            do
            {
                Console.Write("Enter first array lenght (N > 0): ");
                input = Console.ReadLine();
            } while (!int.TryParse(input, out firstArrLength) || firstArrLength <= 0);

            int[] firstArr = new int[firstArrLength];

            //Read first array elements
            for (int i = 0; i < firstArr.Length ; i++)
            {
                do
                {
                    Console.Write("Enter el.{0}: ", (i + 1));
                    input = Console.ReadLine();
                } while (!int.TryParse(input, out firstArr[i]));
            }

            //Read valid array length
            int secondArrLength = 0;
            do
            {
                Console.Write("Enter second array lenght (N > 0): ");
                input = Console.ReadLine();
            } while (!int.TryParse(input, out secondArrLength) || secondArrLength <= 0);

            int[] secondArr = new int[secondArrLength];

            //Read second array elements
            for (int i = 0; i < secondArr.Length; i++)
            {
                do
                {
                    Console.Write("Enter el.{0}: ", (i + 1));
                    input = Console.ReadLine();
                } while (!int.TryParse(input, out secondArr[i]));
            }

            //Comparing arrays
            bool AreEqual = true;

            if (firstArrLength != secondArrLength)
            {
                AreEqual = false;
            }
            else
            {
                for (int i = 0; i < firstArrLength; i++)
                {
                    if (firstArr[i] != secondArr[i])
                    {
                        AreEqual = false;
                        break;
                    }
                }
            }

            Console.WriteLine("The arrays are equal ?: {0}", AreEqual);
        }
    }
}
