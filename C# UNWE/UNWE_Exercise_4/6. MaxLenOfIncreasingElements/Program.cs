using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_6
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = { 3, 2, 3, 4, 2, 2, 4 };
            int Len = 1;
            int BestLen = 0;
            int LenElementIndex = 0;
            int BestLenElementIndex = 0;

            for (int i = 0; i < numbers.Length - 1; i++)
            {
                if (numbers[i] < numbers[i + 1])
                {
                    Len++;
                    LenElementIndex = i + 1;

                    if (Len > BestLen)
                    {
                        BestLen = Len;
                        BestLenElementIndex = LenElementIndex;
                    }

                }
                else
                {
                    Len = 1;
                }
            }

            Console.Write("The MAX sequance of growing numbers is: { ");
            for (int i = BestLenElementIndex - BestLen + 1; i <= BestLenElementIndex; i++)
            {
                Console.Write("{0}", numbers[i]);
                if (i != BestLenElementIndex)
                {
                    Console.Write(", ");
                }
            }
            Console.WriteLine(" }");
        }
    }
}
