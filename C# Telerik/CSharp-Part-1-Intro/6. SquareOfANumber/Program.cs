using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6.SquareOfANumber
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = 12345;
            double SquareNum = Math.Round(Math.Sqrt(number),2);
            Console.WriteLine(SquareNum);
        }
    }
}
