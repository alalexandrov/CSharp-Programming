using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6.SumOfValuesFromStrCalc
{
    class Program
    {
        static void Main(string[] args)
        {
            string numbers = "43 68 9 23 318";
            Console.WriteLine("Numbers {0}", numbers);
            Console.WriteLine("The sum of numbers is: {0}", SumNumbers(numbers));
        }
        public static int SumNumbers(string numbers)
        {
            int sum = 0;
            char[] separators = { ' ' };
            string[] values = numbers.Split(separators, StringSplitOptions.RemoveEmptyEntries);

            foreach (var val in values)
            {
                sum += int.Parse(val);
            }

            return sum;
        }
    }
}
