using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13.BitExchange
{
    class Program
    {
        static void Main(string[] args)
        {
            //exchanges bits 3, 4 and 5 with bits 24, 25 and 26 of given 32-bit unsigned integer.
            int number = 56;
            Console.WriteLine(Convert.ToString(number, 2).PadLeft(32, '0'));

            //Exchanges 3 with 24 bit
            int ThirdBitValue = GetBitAt(3, number);         
            int TwentyFourBitValue = GetBitAt(24, number);
            number = SetBitAt(3, TwentyFourBitValue, number);
            number = SetBitAt(24, ThirdBitValue, number);

            Console.WriteLine(Convert.ToString(number, 2).PadLeft(32, '0'));

            //Exchanges 4 with 25 bit
            int FourthBitValue = GetBitAt(4, number);
            int TwentyFiveBitValue = GetBitAt(25, number);
            number = SetBitAt(4, TwentyFiveBitValue, number);
            number = SetBitAt(25, FourthBitValue, number);

            Console.WriteLine(Convert.ToString(number, 2).PadLeft(32, '0'));

            //Exchanges 5 and 26 bit
            int FiveBitValue = GetBitAt(5, number);
            int TwentySixBitValue = GetBitAt(26, number);
            number = SetBitAt(5, TwentySixBitValue, number);
            number = SetBitAt(26, FiveBitValue, number);

            Console.WriteLine(Convert.ToString(number, 2).PadLeft(32, '0'));
        }

        public static int GetBitAt(int position, int number)
        {
            int mask = 1 << position;
            int nandMask = number & mask;

            int bitValue = nandMask >> position;

            return bitValue;
        }
        public static int SetBitAt(int position, int value, int number)
        {
            int result;
            if (value == 0)
            {
                int mask = ~(1 << position);
                result = number & mask;
            }
            else if (value == 1)
            {
                int mask = 1 << position;
                result = number | mask;
            }
            else
            {
                throw new ArgumentException("The value must be '0' or '1' !");
            }

            return result;
        }
    }
}
