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
            int [] numbers = {2, 1, 1, 2, 3, 3, 2, 2, 2, 2, 1};
            int Len = 1;
            int BestLen = 0;
            int LenElement = 0;
            int BestLenElement = 0;

            for (int i = 0; i < numbers.Length - 1; i++)
            {
                if (numbers[i] == numbers[i + 1])
                {
                    Len++;
                    LenElement = numbers[i];

                    if (Len > BestLen)
                    {
                        BestLen = Len;
                        BestLenElement = LenElement;
                    }

                }
                else
                {
                    Len = 1;
                }
            }

            Console.Write("The MAX sequance of equal numbers is: { ");      
            for (int i = 0; i < BestLen; i++)
            {
                Console.Write("{0}", BestLenElement);
                if (i != BestLen - 1)
                {
                    Console.Write(", ");
                }
            }
            Console.WriteLine(" }");
        }
    }
}
