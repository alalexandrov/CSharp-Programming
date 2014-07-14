using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8.PrintingNumbersFrom1ToN
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = 0;
            string input = "";
            do
            {
                Console.Write("Enter valid integer number N: ");
                input = Console.ReadLine();

            } while (!int.TryParse(input, out number));

            Console.WriteLine("Printed numbers are:");

            for (int i = 1; i <= number; i++)
            {
                Console.WriteLine(i);
            }
        }
    }
}
