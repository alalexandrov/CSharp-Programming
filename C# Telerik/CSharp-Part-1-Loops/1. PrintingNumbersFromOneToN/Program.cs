using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.PrintingNumbersFromOneToN
{
    class Program
    {
        static void Main(string[] args)
        {
            
            string input = "";
            //Read valid N
            int number = 0;
            do
            {
                Console.Write("Enter positive integer number N: ");              
                input = Console.ReadLine();

            } while ((!int.TryParse(input, out number)) || number <= 0);

            for (int i = 1; i <= number; i++)
            {
                Console.WriteLine(i);
            }

        }
    }
}
