using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace _9.CatalanNumbersCalc
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

            //Calculating Catalan number by formula (2n)!/(n + 1)! n!

            //Calculating N factorial
            BigInteger Nfactorial = 1;
            for (int i = numberN; i > 0; i--)
            {
                Nfactorial *= i;
            }

            //Calculating (2n)!/(n + 1)!
            BigInteger NumeratorFact = 1;
            for (int i = numberN * 2; i > numberN + 1; i--)
            {
                NumeratorFact *= i;
            }

            BigInteger catalanNum = NumeratorFact / Nfactorial;
            Console.WriteLine("The catalan number is: {0}", catalanNum);
        }
    }
}
