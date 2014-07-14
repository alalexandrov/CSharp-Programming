using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5.NameOfDigitInEnglish
{
    class Program
    {
        static void Main(string[] args)
        {
            int digit = 0;
            string output = "";
            string input = "";
            do
            {
                Console.Write("Enter valid integer digit: ");
                input = Console.ReadLine();
            } while (!int.TryParse(input, out digit));

            switch (digit)
            {
                case 0: output = "zero"; break;
                case 1: output = "one"; break;
                case 2: output = "two"; break;
                case 3: output = "three"; break;
                case 4: output = "four"; break;
                case 5: output = "five"; break;
                case 6: output = "six"; break;
                case 7: output = "seven"; break;
                case 8: output = "eight"; break;
                case 9: output = "nine"; break;
                default: output = "DIGITS ARE BETWEEN 0 AND 9"; break;
            }

            Console.WriteLine("Output is: {0}", output);
        }
    }
}
