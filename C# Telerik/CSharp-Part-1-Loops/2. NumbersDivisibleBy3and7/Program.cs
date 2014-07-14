using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.NumbersDivisibleBy3and7
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

            //Printing numbers divisible without remainder by 3 and 7
            for (int i = 1; i <= number; i++)
            {
                if (i % (3 * 7) == 0)
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}
