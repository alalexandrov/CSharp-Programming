using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10.SumWithAccuracy
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal sum = 1;
            decimal oldSum = sum;
            decimal numerator = 1;
            decimal denominator = 2;
            decimal fraction = 0;
            decimal accuracy = 0.001m;

            while (true)
            {
                if (denominator % 2 == 1)
                {
                    denominator *= -1;
                }

                fraction = numerator / denominator;
                denominator = Math.Abs(denominator);
                denominator++;

                sum += fraction;

                if (Math.Abs(sum - oldSum) < accuracy)
                {
                    Console.Write("The sum is: {0}\n", sum);
                    break;
                }

                oldSum += fraction;
            }
        }
    }
}
