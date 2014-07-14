using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7.NumberDigitsReverseMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal num = 123456.1M;

            Console.WriteLine(num);
            Console.WriteLine("Reversed number");
            Console.WriteLine(ReverseDigits(num));
        }
        public static decimal ReverseDigits(decimal number)
        {
            string NumStr = number.ToString();
            string ReversedNumStr = string.Join("", NumStr.Reverse());

            return decimal.Parse(ReversedNumStr);
        }
    }
}
