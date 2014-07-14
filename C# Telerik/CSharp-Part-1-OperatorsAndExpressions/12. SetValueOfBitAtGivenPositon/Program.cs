using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12.SetValueOfBitAtGivenPositon
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = 5;
            int SetPosition = 2;
            int valueToSet = 0;
            int result;

            Console.Write("{0}-> ", number.ToString().PadRight(3, ' '));
            Console.WriteLine(Convert.ToString(number, 2).PadLeft(32, '0'));

            if (valueToSet == 0)
            {             
                int mask = ~(1 << SetPosition);
                result = number & mask;
            }
            else
            {
                int mask = 1 << SetPosition;
                result = number | mask;
            }

            Console.WriteLine("Result is: ");
            Console.Write("{0}-> ", result.ToString().PadRight(3,' '));
            Console.WriteLine(Convert.ToString(result, 2).PadLeft(32, '0'));
        }
    }
}
