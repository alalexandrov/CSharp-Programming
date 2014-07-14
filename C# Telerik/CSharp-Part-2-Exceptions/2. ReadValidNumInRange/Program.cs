using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.ReadValidNumInRange
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = new int[10];
            int StartInterval = 1;

            //Reading numbers from console: 1 < a1 < a2 < ... 100
            for (int i = 0; i < numbers.Length; i++)
            {
                try
                {
                    numbers[i] = ReadNumber(StartInterval, 100);
                    StartInterval = numbers[i] + 1;
                }
                catch (ArgumentException ae)
                {
                    Console.WriteLine(ae.Message);
                }            
            }
        }

        public static int ReadNumber(int start, int end)
        {
            Console.Write("Enter number in range [{0}, {1}] : ", start, end);
            string input = Console.ReadLine();
            int number = 0;

            if (!int.TryParse(input, out number))
            {
                throw new ArgumentException("Invalid integer value !");
            }

            if (number < start || number > end)
            {
                throw new ArgumentException(String.Format("The number must be in range [{0}, {1}] !", start, end));
            }

            return number;
        }
    }
}
