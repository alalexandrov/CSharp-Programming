using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8.SequenceWithMaxSum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] Arr = { 2, 3, -6, -1, 2, -1, 6, 4, -8, 8 };

            int MaxSum = 0;
            int CurrentMax = 0;
            int CurrentStartIndex = 0;
            int StartIndex = 0;
            int EndIndex = 0;

            //Kadan's algorith implementation
            for (int i = 0; i < Arr.Length; i++)
            {
                if (CurrentMax < 0)
                {
                    CurrentMax = Arr[i];
                    CurrentStartIndex = i;
                }
                else
                {
                    CurrentMax += Arr[i];
                }

                if (CurrentMax > MaxSum)
                {
                    MaxSum = CurrentMax;
                    StartIndex = CurrentStartIndex;
                    EndIndex = i;
                }
            }

            Console.WriteLine("Array: {0}", string.Join(" ", Arr));
            Console.Write("The sequence with maximal sum is: ");
            for (int i = StartIndex; i <= EndIndex; i++)
            {
                Console.Write("{0} ", Arr[i]);
            }

            Console.WriteLine();
            Console.WriteLine("The sum of sequence is: {0}", MaxSum);
        }
    }
}
