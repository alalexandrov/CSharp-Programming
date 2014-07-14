using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5.ThirdBitCheck
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = 24;
            int positions = 3;
            Console.WriteLine(Convert.ToString(number, 2).PadLeft(32, '0'));

            int mask = 1 << positions;
            Console.WriteLine(Convert.ToString(mask, 2).PadLeft(32, '0'));
            int nandMask = number & mask;

            int BitValue = nandMask >> positions;

            // Check the if the third bit value is 1;
            bool check = BitValue == 1;
            Console.WriteLine("Third bit is 1: {0}", check);

        }
    }
}
