using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RectangleAreaAndPerimeterCalc
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.Write(@"Enter rectangle side ""A"": ");
                decimal SideA = decimal.Parse(Console.ReadLine());
                Console.Write(@"Enter rectangle side ""B"": ");
                decimal SideB = decimal.Parse(Console.ReadLine());

                if (SideA <= 0 || SideB <= 0)
                {
                    throw new ArgumentException("The sides must be positive number !!!");
                }

                decimal RectangleArea = Math.Round(SideA * SideB, 2);
                decimal RectanglePerimeter = Math.Round(2 * SideA + 2 * SideB, 2);

                Console.WriteLine("The RectangleArea is: {0}", RectangleArea);
                Console.WriteLine("The RectanglePerimeter is: {0}", RectanglePerimeter);
            }

            catch (FormatException f)
            {
                Console.WriteLine("Sides must be numbers !!!", f);
            }
            catch (Exception a)
            {
                Console.WriteLine(a.Message);
            }
        }
    }
}
