using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8.BinaryRepresentationOf16BitNum
{
    class Program
    {
        static void Main(string[] args)
        {
            short number = 1992;
            Console.WriteLine("The binary representation of number {0} is:", number);
            Console.WriteLine(GetBinaryRepresent(number));
        }

        public static string GetBinaryRepresent(short number)
        {
            StringBuilder binatyStr = new StringBuilder();
            StringBuilder output = new StringBuilder();

            while (number > 0)
            {
                binatyStr.Append(number % 2);
                number /= 2;
            }

            for (int i = 0; i < binatyStr.Length; i++)
            {
                if (binatyStr[i] == '1')
                {
                    output.Append(string.Format("2^{0} ", i));
                    if (i != binatyStr.Length - 1)
                    {
                        output.Append("+ ");
                    }
                }
                
            }
            return output.ToString();
        }
    }
}
