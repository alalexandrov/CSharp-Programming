using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3.LastDigitExtractMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = 1235;
            string LastDigitName = GetLastDigit(number);
            Console.WriteLine("The name of last digit of {0} is: {1}", number, LastDigitName);
        }

        public static string GetLastDigit(int number)
        {
            int LastDigit = number % 10;

            switch (LastDigit)
            {
                case 0: return "zero";
                case 1: return "one";
                case 2: return "two";
                case 3: return "three";
                case 4: return "four";
                case 5: return "five";
                case 6: return "six";
                case 7: return "seven";
                case 8: return "eight";
                case 9: return "nine";
                default: return "#";
            }
        }
    }
}
