using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11.ValueOfBitAtGivenPositonExtract
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = 5;
            int positions = 2;
            Console.WriteLine(Convert.ToString(number, 2).PadLeft(32, '0'));

            int mask = 1 << positions;
            Console.WriteLine(Convert.ToString(mask, 2).PadLeft(32, '0'));
            int nandMask = number & mask;

            //Getting the bit value
            int result = nandMask >> positions;

            Console.WriteLine("The bit value at posittion {0} is: {1}", positions, result);


        }
    }
}
