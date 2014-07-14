using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3.FloatingPointNumComparison
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal number1 = 5.00000001m;
            decimal number2 = 5.00000003m;

            //Rounded numbers with precision 0.000001
            decimal number1Rounded = Math.Round(number1, 6);
            decimal number2Rounded = Math.Round(number2, 6);

            if (number2Rounded == number1Rounded)
            {
                Console.WriteLine("{0} = {1}", number1Rounded, number2Rounded);
                Console.WriteLine("The numbers are Equal !");
            }
            else
            {
                Console.WriteLine("{0} != {1}", number1Rounded, number2Rounded); 
                Console.WriteLine("The numbers are not Equal !");
            }
        }
    }
}
