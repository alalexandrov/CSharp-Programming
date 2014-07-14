using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7.SumOfNumbersCalc
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = 0;
            int sum = 0;

            while (true)
            {
                Console.Write("Enter num: ");
                try
                {
                    number = int.Parse(Console.ReadKey().KeyChar.ToString());
                }
                catch (Exception)
                {
                    Console.WriteLine("\nEnter valid number !");
                    continue;               
                }

                sum += number;
                Console.WriteLine();
                Console.WriteLine("The sum of entered numbers is: {0}", sum);
            }
        }
    }
}
