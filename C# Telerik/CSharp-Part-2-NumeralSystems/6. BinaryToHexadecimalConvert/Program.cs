using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6.BinaryToHexadecimalConvert
{
    class Program
    {
        static void Main(string[] args)
        {
            string binaryNum = "100111100";
            Console.WriteLine(binaryNum + " (2)");
            Console.WriteLine(ConvertToHex(binaryNum) + " (16)");

        }

        public static string ConvertToHex(string binaryNum)
        {
            string currentNum = "";
            string HexNum = "";

            for (int i = 0; i < binaryNum.Length - 3; i+=4)
            {
                currentNum = binaryNum[i].ToString() +
                    binaryNum[i + 1].ToString() +
                    binaryNum[i + 2].ToString() +
                    binaryNum[i + 3].ToString();

                switch (currentNum)
                {
                    case "0000": HexNum += "0"; break;
                    case "0001": HexNum += "1"; break;
                    case "0010": HexNum += "2"; break;
                    case "0011": HexNum += "3"; break;
                    case "0100": HexNum += "4"; break;
                    case "0101": HexNum += "5"; break;
                    case "0110": HexNum += "6"; break;
                    case "0111": HexNum += "7"; break;
                    case "1000": HexNum += "8"; break;
                    case "1001": HexNum += "9"; break;
                    case "1010": HexNum += "A"; break;
                    case "1011": HexNum += "B"; break;
                    case "1100": HexNum += "C"; break;
                    case "1101": HexNum += "D"; break;
                    case "1110": HexNum += "E"; break;
                    case "1111": HexNum += "F"; break;
                    default: throw new ArgumentException("Invalid binary value !!!");
                }
            }
            return HexNum;
        }
    }
}
