using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_8
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Please enter size of Array: ");
            int ArrLength = int.Parse(Console.ReadLine());
            Console.Write("Please enter count of consecutive numbers: ");
            int NumbersToSumCount = int.Parse(Console.ReadLine());
            int[] numbers = new int[ArrLength];
            for (int i = 0; i < numbers.Length; i++)
            {
                Console.Write("Enter element {0}: ", i + 1);
                numbers[i] = int.Parse(Console.ReadLine());
            }
            
            int CurrentSum = 0;
            int MaxSum = int.MinValue;
            int ElementIndex = 0;
            for (int i = 0; i <= numbers.Length - NumbersToSumCount; i++)
            {
                for (int j = 0; j < NumbersToSumCount  ; j++)
                {
                    CurrentSum += numbers[i + j];
                }

                if (CurrentSum > MaxSum)
                {
                    MaxSum = CurrentSum;
                    ElementIndex = i;
                }

                CurrentSum = 0;
            }

            Console.Write("The consecutive {0} numbers with maximal sum are: ", NumbersToSumCount);
            Console.Write("{ ");
            for (int i = ElementIndex; i < ElementIndex + NumbersToSumCount; i++)
            {
                Console.Write("{0}",numbers[i]);
                if (i != ElementIndex + NumbersToSumCount - 1)
                {
                    Console.Write(", ");
                }
            }

            Console.WriteLine(" }");
        }
    }
}
