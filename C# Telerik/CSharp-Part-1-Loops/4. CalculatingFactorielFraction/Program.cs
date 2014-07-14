using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4.CalculatingFactorielFraction
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = "";
            Console.WriteLine("Enter N AND K where 1<N<K");

            //Read valid N
            int numberN = 0;
            do
            {
                Console.Write("Enter N: ");
                input = Console.ReadLine();

            } while ((!int.TryParse(input, out numberN)) || numberN <= 0);

            //Read valid K
            int numberK = 0;
            do
            {
                Console.Write("Enter K: ");
                input = Console.ReadLine();

            } while ((!int.TryParse(input, out numberK)) || numberK <= numberN);

            //Calculting N!/K!
            byte numerator = 1;
            long denominator = 1;
            int count = numberN;

            for (int i = numberK; i > count; i--)
            {
                denominator *= i;
            }

            decimal fraction = (decimal)numerator / denominator;
            Console.WriteLine("The result of N!/K! is: {0}", fraction);

        }
    }
}
