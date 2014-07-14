using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4.FindMaximalSequenceOfEqualElem
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 2, 1, 1, 2, 3, 3, 2, 2, 2, 1 };

            int len = 1;
            int lenStartIndex = 0;
            int bestLen = 0;
            int bestLenStartIndex = 0;

            for (int i = 0; i < arr.Length - 1; i++)
            {
                if (arr[i] == arr[i + 1])
                {
                    len++;
                    if (len == 2)
                    {
                        lenStartIndex = i;
                    }

                    if (len > bestLen)
                    {
                        bestLen = len;
                        bestLenStartIndex = lenStartIndex;
                    }
                }
                else
                {
                    len = 1;
                }
            }

            Console.WriteLine(string.Join(" ", arr));
            Console.WriteLine("The maximal sequence of equal elements is: ");
            for (int i = bestLenStartIndex; i < bestLen + bestLenStartIndex; i++)
            {
                Console.Write("{0} ",arr[i]);
            }
            Console.WriteLine();
        }
    }
}
