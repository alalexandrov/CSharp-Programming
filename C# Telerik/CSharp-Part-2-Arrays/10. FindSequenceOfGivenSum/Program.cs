using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10.FindSequenceOfGivenSum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] Arr = { 4, 3, 1, 4, 2, 5, 6 };
            int GivenSum = 11;
            int CurrentSum = 0;

            Console.WriteLine("Array: {0}", string.Join(", ", Arr));
            Console.WriteLine("The sequences with sum = {0} are:", GivenSum);

            for (int i = 0; i < Arr.Length; i++)
            {
                for (int j = i; j < Arr.Length; j++)
                {
                    CurrentSum += Arr[j];
                    if (CurrentSum == GivenSum)
                    {
                        for (int k = i; k <= j; k++)
                        {
                            Console.Write("{0} ", Arr[k]);
                        }
                        Console.WriteLine();
                    }
                }

                CurrentSum = 0;
            }
        }
    }
}
