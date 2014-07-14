using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7.PrimeNumberCheck
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = 37;
            int divider = 2;
            double maxDivider = Math.Sqrt(number);
            bool isPrime = true;

            while (divider <= maxDivider)
            {
                if (number % divider == 0)
                {
                    isPrime = false;
                    break;
                }
                divider++;
            }

            Console.WriteLine("The number {0} is prime ?: {1}", number, isPrime);
        }
    }
}
