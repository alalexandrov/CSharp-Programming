using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7.AnyToAnyNumeralSystemConvert
{
    class Program
    {
        static void Main(string[] args)
        {
            string number = "1111";
            Console.WriteLine(number + " (2) ->");
            Console.WriteLine(ConvertToBase(number, 2, 10) + " (10)");
            Console.WriteLine(ConvertToBase(number, 2, 16) + " (16)");
            Console.WriteLine(ConvertToBase(number, 2, 8) + " (8)");
            Console.WriteLine();

            number = "ABCDEF";
            Console.WriteLine(number + " (16) ->");
            Console.WriteLine(ConvertToBase(number, 16, 10) + " (10)");
            Console.WriteLine(ConvertToBase(number, 16, 2) + " (2)");
        }

        public static string ConvertToBase(string number, int fromBase, int toBase)
        {
            if (fromBase < 2 || toBase > 16)
            {
                throw new ArgumentException("Invalid base input !");
            }

            //Convert to any numeral system to decimal         
            string reversedNum = string.Join("", number.Reverse());
            int decimalNum = 0;
            int CurrentNum = 0;

            for (int i = 0; i < reversedNum.Length; i++)
            {
                if (!int.TryParse(reversedNum[i].ToString(), out CurrentNum))
                {
                    switch (reversedNum[i].ToString())
                    {
                        case "A": CurrentNum = 10; break;
                        case "B": CurrentNum = 11; break;
                        case "C": CurrentNum = 12; break;
                        case "D": CurrentNum = 13; break;
                        case "E": CurrentNum = 14; break;
                        case "F": CurrentNum = 15; break;
                    }
                }
                decimalNum += (int)(CurrentNum * Math.Pow(fromBase, i));
            }

            //Convert from decimal to any numeral system
            string outputNum = "";
            int remainder = 0;

            while (decimalNum > 0)
            {
                remainder = decimalNum % toBase;

                if (remainder <= 9)
                {
                    outputNum += remainder.ToString();
                }
                else
                {
                    switch (remainder)
                    {
                        case 10: outputNum += "A"; break;
                        case 11: outputNum += "B"; break;
                        case 12: outputNum += "C"; break;
                        case 13: outputNum += "D"; break;
                        case 14: outputNum += "E"; break;
                        case 15: outputNum += "F"; break;
                    }
                }
                decimalNum /= toBase;
            }

            return string.Join("", outputNum.Reverse());
        }
    }
}
