using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.CirclePerimeterAndAreaCalc
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Please enter radius of circle: ");
            double radius = double.Parse(Console.ReadLine());

            double circlePerimeter = Math.Round(2 * Math.PI * radius, 2);
            double circleArea = Math.Round(Math.PI * radius * radius, 2);

            Console.WriteLine("The circle perimeter is: {0}", circlePerimeter);
            Console.WriteLine("The circle area is: {0}", circleArea);
        }
    }
}
