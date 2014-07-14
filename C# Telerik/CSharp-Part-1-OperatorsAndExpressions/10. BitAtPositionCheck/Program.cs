using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10.BitAtPositionCheck
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = 5;
            int positions = 1;
            Console.WriteLine(Convert.ToString(number, 2).PadLeft(32, '0'));       

            int mask = 1 << positions;
            Console.WriteLine(Convert.ToString(mask, 2).PadLeft(32, '0'));
            int nandMask = number & mask;

            int BitValue = nandMask >> positions;

            // Check the if the bit value is 1;
            bool check = BitValue == 1;
            Console.WriteLine("bit at posittion {0} is 1: {1}", positions, check);
        }
    }
}
