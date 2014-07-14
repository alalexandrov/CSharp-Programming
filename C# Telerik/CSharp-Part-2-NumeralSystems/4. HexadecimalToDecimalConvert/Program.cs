using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4.HexadecimalToDecimalConvert
{
    class Program
    {
        static void Main(string[] args)
        {
            string numInHex = "1F4";
            Console.WriteLine(numInHex + " (16)");
            Console.WriteLine(ConvertToDecimal(numInHex) + " (10)");
        }

        public static int ConvertToDecimal(string hex)
        {
            string hexReverse = string.Join("", hex.Reverse());
            int decimalNum = 0;
            int CurrentNum = 0;
            for (int i = 0; i < hexReverse.Length; i++)
            {        
                if (!int.TryParse(hexReverse[i].ToString(), out CurrentNum))
                {
                    switch (hexReverse[i].ToString())
                    {
                        case "A": CurrentNum = 10; break;
                        case "B": CurrentNum = 11; break;
                        case "C": CurrentNum = 12; break;
                        case "D": CurrentNum = 13; break;
                        case "E": CurrentNum = 14; break;
                        case "F": CurrentNum = 15; break;
                    }
                }

                decimalNum += (int)(CurrentNum * Math.Pow(16, i));
            }
            return decimalNum;
        }
    }
}
