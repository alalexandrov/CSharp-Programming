using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10.BonusScoresCalc
{
    class Program
    {
        static void Main(string[] args)
        {

            int digit = 0;
            string input = "";
            do
            {
                Console.Write("Enter digit in interval [1...9]: ");
                input = Console.ReadLine();

            } while (!int.TryParse(input, out digit));

            switch (digit)
            {
                case 1:
                case 2:
                case 3:
                    digit *= 10; break;
                case 4:
                case 5:
                case 6:
                    digit *= 100; break;
                case 7:
                case 8:
                case 9:
                    digit *= 1000; break;
                default: Console.WriteLine("The digit must be in interval [0..9] !!!"); break;
            }

            Console.WriteLine("The score is: {0}", digit);
        }
    }
}
