using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.IsDividedBy7and5
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = 35;

            if (number % 5 == 0 && number % 7 == 0)
            {
                Console.WriteLine("The number {0} is divided by 7 and 5 without remainder !", number);
            }
            else
            {
                Console.WriteLine("The number {0} is NOT divided by 7 and 5 without remainder !", number);
            }
        }
    }
}
