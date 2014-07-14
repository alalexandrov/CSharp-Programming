using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4.ThirdDigitCheck
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = 1732;
            int ThirdDigit = (number / 100) % 10;
            Console.WriteLine(ThirdDigit);

            bool result = ThirdDigit == 7;

            Console.WriteLine(result);
        }
    }
}
