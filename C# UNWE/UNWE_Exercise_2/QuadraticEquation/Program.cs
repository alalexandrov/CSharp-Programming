using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuadraticEquation
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Quadratic equation calculator");
                Console.WriteLine("Enter the equation like this : ax^2+bx+c=0.");
                string value = Console.ReadLine();
                //value = "-2x^2+3x+5=0";
                double a = 0;
                double b = 0;
                double c = 0;

                if (value[0] == '-' || value[0] == '+')
                {
                    a = double.Parse(value[0].ToString() + value[1].ToString());
                    b = double.Parse(value[5].ToString() + value[6].ToString());
                    c = double.Parse(value[8].ToString() + value[9].ToString());
                }
                else
                {
                    a = double.Parse(value[0].ToString());
                    b = double.Parse(value[4].ToString() + value[5].ToString());
                    c = double.Parse(value[7].ToString() + value[8].ToString());
                }

                double Discriminant = b * b - 4 * a * c;

                if (Discriminant > 0)
                {
                    double x1 = Math.Round(((-b) + Math.Sqrt(Discriminant)) / (2 * a), 2);
                    double x2 = Math.Round(((-b) - Math.Sqrt(Discriminant)) / (2 * a), 2);
                    Console.WriteLine("The equation have two real roots: X1 = {0} and X2 = {1}", x1, x2);
                }
                else if (Discriminant == 0)
                {
                    double x = Math.Round((-b) / (2 * a), 2);
                    Console.WriteLine("The equation have one real root: X = {0}", x);
                }
                else
                {
                    Console.WriteLine("The equation not have real roots !");
                }
            }
            catch (FormatException)
            {
                Console.WriteLine("You enter invalid format of equation !");
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
