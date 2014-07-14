using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9.FindMostFrequentNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] Arr = { 4, 1, 1, 4, 2, 3, 4, 4, 1, 2, 4, 9, 3 };
            Console.WriteLine("Array: {0}", string.Join(", ", Arr));

            int MostFreqNum = 0;
            int CurrentNumCount = 0;
            int MostFreqNumCount = 0;

            for (int i = 0; i < Arr.Length - 1; i++)
            {
                if (Arr[i] == int.MinValue)
                {
                    continue;
                }

                for (int j = i + 1; j < Arr.Length; j++)
                {            
                    if (Arr[i] == Arr[j] && Arr[j] != int.MinValue)
                    {
                        CurrentNumCount++;                       
                        if (CurrentNumCount > MostFreqNumCount)
                        {
                            MostFreqNumCount = CurrentNumCount;
                            MostFreqNum = Arr[i];
                        }

                        Arr[j] = int.MinValue;
                    }
                }
                CurrentNumCount = 0;
            }

            Console.WriteLine("The most frequent number is: {0} -> {1} times.", MostFreqNum, MostFreqNumCount);
        }
    }
}
