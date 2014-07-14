using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3.DecimalToHexadecimalConvert
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = 256;
            Console.WriteLine(number + " (10)");
            Console.WriteLine(ConvertToHex(number) + " (16)");
        }

        public static string ConvertToHex(int number)
        {
            string hexNum = "";
            int remainder = 0;

            while (number > 0)
            {
                remainder = number % 16;

                if (remainder <= 9)
                {
                    hexNum += remainder.ToString();
                }
                else
                {
                    switch (remainder)
                    {
                        case 10: hexNum += "A"; break;
                        case 11: hexNum += "B"; break;
                        case 12: hexNum += "C"; break;
                        case 13: hexNum += "D"; break;
                        case 14: hexNum += "E"; break;
                        case 15: hexNum += "F"; break;
                    }
                }
                number /= 16;
            }

            hexNum += "x0";
            return string.Join("", hexNum.Reverse());
        }
    }
}
