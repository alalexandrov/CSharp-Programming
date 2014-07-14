using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5.HexadecimalToBinaryConvert
{
    class Program
    {
        static void Main(string[] args)
        {
            string hexNum = "1F4";
            Console.WriteLine(hexNum + " (16)");
            Console.WriteLine(ConvertToBinary(hexNum) + " (2)");
        }
        public static string ConvertToBinary(string hex)
        {
            StringBuilder BinaryNum = new StringBuilder();
            for (int i = 0; i < hex.Length; i++)
            {
                switch (hex[i].ToString())
                {
                    case "0": BinaryNum.Append("0000"); break;
                    case "1": BinaryNum.Append("0001"); break;
                    case "2": BinaryNum.Append("0010"); break;
                    case "3": BinaryNum.Append("0011"); break;
                    case "4": BinaryNum.Append("0100"); break;
                    case "5": BinaryNum.Append("0101"); break;
                    case "6": BinaryNum.Append("0110"); break;
                    case "7": BinaryNum.Append("0111"); break;
                    case "8": BinaryNum.Append("1000"); break;
                    case "9": BinaryNum.Append("1001"); break;
                    case "A": BinaryNum.Append("1010"); break;
                    case "B": BinaryNum.Append("1011"); break;
                    case "C": BinaryNum.Append("1100"); break;
                    case "D": BinaryNum.Append("1101"); break;
                    case "E": BinaryNum.Append("1110"); break;
                    case "F": BinaryNum.Append("1111"); break;
                    default: throw new ArgumentException("Invalid hex value !!!");
                }
            }
            return BinaryNum.ToString();
        }
    }
}
