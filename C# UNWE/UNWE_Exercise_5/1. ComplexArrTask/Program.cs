using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] Array = { 1, 2, 3, 5, 12, -2, 0, 17, 56, 44, 3, -2, 9, 11 };
            List<int> OutputValues = new List<int>();
            int MinValue = int.MaxValue;
            int MinValueIndex = 0;
            for (int i = 0; i < Array.Length; i++)
            {
                if (Array[i] <= MinValue)
                {
                    MinValue = Array[i];
                    MinValueIndex = i;
                }
            }

            for (int i = 0; i < Array.Length; i++)
            {
                if (Array[i] != MinValue && i < MinValueIndex)
                {
                    OutputValues.Add(Array[i]);
                }
            }

            Console.Write("Output Array is: ");
            Console.WriteLine(string.Join(",", OutputValues));
        }
    }
}
