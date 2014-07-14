using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace _10.NFactorialForEachElemCalc
{
    class Program
    {
        static void Main(string[] args)
        {
            //Calculating and printing N! from 1 to 100
            for (int i = 1; i <= 100; i++)
            {
                Console.WriteLine("{0}! = {1}", i, FactCalc(i));
            }
        }

        public static BigInteger FactCalc(int number)
        {
            BigInteger Factorial = 1;
            for (int i = 1; i <= number; i++)
            {
                Factorial *= i;
            }

            return Factorial;
        }
    }
}
