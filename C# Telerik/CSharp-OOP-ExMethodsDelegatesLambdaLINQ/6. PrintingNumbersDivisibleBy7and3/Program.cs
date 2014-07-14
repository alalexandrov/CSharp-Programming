using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6.PrintingNumbersDivisibleBy7and3
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = { 1, 2, 3, 21, 4, 5, 6, 7, 42, 5, 5, 3, 21, 84, 336 };

            //Get numbers divisible by 7 and 3 (or divisible by 3*7)

            //With Lambda expression
            var DivisibleNumbers = numbers.Where(n => n % 21 == 0);

            //With LINQ
            var DivisibleNumbersLINQ = from num in numbers
                                       where num % 21 == 0
                                       select num;

            //Printing result to Console
            Console.WriteLine(string.Join(", ",DivisibleNumbers));
            Console.WriteLine(string.Join(", ", DivisibleNumbersLINQ));
        }
    }
}
