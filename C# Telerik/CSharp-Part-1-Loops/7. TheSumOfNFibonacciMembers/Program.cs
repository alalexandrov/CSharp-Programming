using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7.TheSumOfNFibonacciMembers
{
    class Program
    {
        static void Main(string[] args)
        {
            //Read valid N
            string input = "";      
            int numberN = 0;
            do
            {
                Console.Write("Enter N: ");
                input = Console.ReadLine();

            } while ((!int.TryParse(input, out numberN)) || numberN <= 0);

            //Getting sum ot N Fibonacci members
            long numA = 0;
            long numB = 1;
            long fibonacci = 1;
            long FibonacciSum = 1;

            for (int i = 0; i < numberN - 2; i++)
            {
                FibonacciSum += fibonacci;
                numA = numB;
                numB = fibonacci;
                fibonacci = numA + numB;
            }

            Console.WriteLine("The sum of first {0} members of Fibonacci is: {1}", numberN, FibonacciSum);
        }
    }
}
