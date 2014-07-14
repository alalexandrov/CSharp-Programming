using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.BinaryToDecimalConvert
{
    class Program
    {
        static void Main(string[] args)
        {
            string BinaryNum = "00000000000000000000110000100111";
            Console.WriteLine(BinaryNum + " (2)");
            Console.WriteLine(ConvertToDecimal(BinaryNum) + " (10)");
        }

        public static int ConvertToDecimal(string number)
        {
            int length = number.Length;
            string reversedNum = string.Join("", number.Reverse());
            int decimalNum = 0;

            for (int i = 0; i < length; i++)
            {
                if (reversedNum[i] == '1')
                {
                    decimalNum += (int)Math.Pow(2, i);
                }
            }

            return decimalNum;
        }
    }
}
