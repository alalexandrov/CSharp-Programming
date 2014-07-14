using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6.QuadraticEquationSolver
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = "";
            double paramA = 0;
            double paramB = 0;
            double paramC = 0;

            Console.WriteLine("Enter parameters of quadratic equation.");
            do
            {
                Console.Write("Enter valid param A: ");
                input = Console.ReadLine();
            } while (!double.TryParse(input, out paramA));

            do
            {
                Console.Write("Enter valid param B: ");
                input = Console.ReadLine();
            } while (!double.TryParse(input, out paramB));

            do
            {
                Console.Write("Enter valid param C: ");
                input = Console.ReadLine();
            } while (!double.TryParse(input, out paramC));

            double discriminant = (paramB * paramB) - (4 * paramA * paramC);

            if (discriminant > 0)
            {
                double rootX1 = ((-paramB) + Math.Sqrt(discriminant)) / (2 * paramA);
                double rootX2 = ((-paramB) - Math.Sqrt(discriminant)) / (2 * paramA);
                Console.WriteLine("The equation have 2 real roots");
                Console.WriteLine("X1 = {0}", Math.Round(rootX1, 2));
                Console.WriteLine("X2 = {0}", Math.Round(rootX2));
            }
            else if (discriminant == 0)
            {
                double rootX = (-paramB) / (2 * paramA);
                Console.WriteLine("The equation have 1 real root");
                Console.WriteLine("X = {0}", Math.Round(rootX));
            }
            else
            {
                Console.WriteLine("The equation didn't have real roots !");
            }
        }
    }
}
