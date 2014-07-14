using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5.CalculatingFactorielFraction2
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

            //Calculating N!*K! / (K-N)!
 
            //Calculating N!
            long NFactorial = 1;
            for (int i = numberN; i > 0; i--)
            {
                NFactorial *= i;
            }

            //Calculating K! / (K-N)!
            long fractionFactorial = 1;
            int count = numberK - numberN;
            for (int i = numberK; i > count; i--)
            {
                fractionFactorial *= i;
            }

            long result = NFactorial * fractionFactorial;
            Console.WriteLine("The result of N!*K! / (K-N)! is: {0}", result);
        }
    }
}
