using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6.CalcSumOfFactorielFraction
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = "";
            Console.WriteLine("Enter positive N AND X ");

            //Read valid N
            int numberN = 0;
            do
            {
                Console.Write("Enter N: ");
                input = Console.ReadLine();

            } while ((!int.TryParse(input, out numberN)) || numberN <= 0);

            //Read valid X
            int numberX = 0;
            do
            {
                Console.Write("Enter X: ");
                input = Console.ReadLine();

            } while ((!int.TryParse(input, out numberX)) || numberX <= 0);

            //Calculating the sum: S = 1 + 1!/X + 2!/X2 + … + N!/X^N

            decimal sum = 1;
            for (int i = 1; i <= numberN; i++)
            {
                //Calculating N factorial
                long NFactorial = 1;
                for (int j = i; j > 0; j--)
                {
                    NFactorial *= j;
                }

                //Calculating X^N
                decimal Denominator = (decimal)Math.Pow(numberX, i);

                sum += NFactorial / Denominator;
            }

            Console.WriteLine("The sum '1 + 1!/X + 2!/X2 + … + N!/X^N' is: {0}", Math.Round(sum, 4));
        }
    }
}
