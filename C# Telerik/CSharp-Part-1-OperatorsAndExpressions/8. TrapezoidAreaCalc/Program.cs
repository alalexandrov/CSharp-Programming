using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8.TrapezoidAreaCalc
{
    class Program
    {
        static void Main(string[] args)
        {
            double SideA = 5;
            double SideB = 5;
            double Height = 5;

            double TrapezoidArea = Math.Round(((SideA + SideB) * Height) / 2, 2);

            Console.WriteLine("The trapezoid area is: {0}", TrapezoidArea);

        }
    }
}
