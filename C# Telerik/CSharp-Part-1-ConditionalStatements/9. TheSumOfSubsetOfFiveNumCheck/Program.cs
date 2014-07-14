using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9.TheSumOfSubsetOfFiveNumCheck
{
    class Program
    {
        static void Main(string[] args)
        {

            int[] numbers = new int[5];

            //numbers = new int[] { 0, -2, 1, 1, 8 };

            //Reading input
            string input = "";
            for (int i = 0; i < numbers.Length; i++)
            {
                do
                {
                    Console.Write("Enter valid integer number {0}: ", (i + 1));
                    input = Console.ReadLine();

                } while (!int.TryParse(input, out numbers[i]));
            }

            Console.WriteLine("The subsets of with sum 0 are");

            //Checking sum of subsets with one num
            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] == 0)
                {
                    Console.WriteLine("Subset: {0}", numbers[i]);
                }
            }

            //Checking sum of subsets with two nums
            for (int i = 0; i < numbers.Length - 1; i++)
            {
                for (int i1 = i + 1; i1 < numbers.Length; i1++)
                {
                    if (numbers[i] + numbers[i1] == 0)
                    {
                        Console.WriteLine("Subset: {0}, {1}", numbers[i], numbers[i1]);
                    }
                }
            }

            //Checking sum of subsets with three nums
            for (int i = 0; i < numbers.Length - 2; i++)
            {
                for (int i1 = i + 1; i1 < numbers.Length - 1; i1++)
                {
                    for (int i2 = i1 + 1; i2 < numbers.Length; i2++)
                    {

                        if (numbers[i] + numbers[i1] + numbers[i2] == 0)
                        {
                            Console.WriteLine("Subset: {0}, {1}, {2}", numbers[i], numbers[i1], numbers[i2]);
                        }
                    }
                }
            }

            //Checking sum of subsets with four nums
            for (int i = 0; i < numbers.Length - 3; i++)
            {
                for (int i1 = i + 1; i1 < numbers.Length - 2; i1++)
                {
                    for (int i2 = i1 + 1; i2 < numbers.Length - 1; i2++)
                    {
                        for (int i3 = i2 + 1; i3 < numbers.Length; i3++)
                        {

                            if (numbers[i] + numbers[i1] + numbers[i2] + numbers[i3] == 0)
                            {
                                Console.WriteLine("Subset: {0}, {1}, {2}, {3}", numbers[i], numbers[i1], numbers[i2], numbers[i3]);
                            }
                        }
                    }
                }
            }

            //Checking sum of subset with all num
            if (numbers.Sum() == 0)
            {
                Console.WriteLine("Subset with sum 0: {0}, {1}, {2}, {3}, {4}", numbers[0], numbers[1], numbers[2], numbers[3], numbers[4]);
            }
        }
    }
}
