using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.DecimalToBinaryConvert
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = 3111;
            Console.WriteLine(ConvertToBinary(number));
            // Check validity
            Console.WriteLine(Convert.ToString(number,2).PadLeft(32, '0'));
        }
        public static string ConvertToBinary(int number)
        {
            StringBuilder binatyStr = new StringBuilder();

            while (number > 0)
            {
                binatyStr.Append(number % 2);
                number /= 2;
            }

            return string.Join("", binatyStr.ToString().PadRight(32,'0').Reverse());
        }
    }
}
