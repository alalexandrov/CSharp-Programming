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
            Console.WriteLine("Quadratic equation solver 'ax^2 + bx + c = 0'");
            Console.Write("Enter A: ");
            double a = double.Parse(Console.ReadLine());

            Console.Write("Enter B: ");
            double b = double.Parse(Console.ReadLine());

            Console.Write("Enter C: ");
            double c = double.Parse(Console.ReadLine());

            double discriminant = (b * b) - (4 * a * c);
            double rootX1;
            double rootX2;

            if (discriminant > 0)
            {
                rootX1 = ((-b) - Math.Sqrt(discriminant)) / (2 * a);
                rootX2 = ((-b) + Math.Sqrt(discriminant)) / (2 * a);

                Console.WriteLine("The equation have two real roots");
                Console.WriteLine("X1 = {0}", Math.Round(rootX1));
                Console.WriteLine("X2 = {0}", Math.Round(rootX2));
            }
            else if (discriminant == 0)
            {
                rootX1 = (-b) / (2 * a);

                Console.WriteLine("The equation have one real root");
                Console.WriteLine("X = {0}", Math.Round(rootX1));
            }
            else
            {
                Console.WriteLine("No real roots !!!");
            }
        }
    }
}
