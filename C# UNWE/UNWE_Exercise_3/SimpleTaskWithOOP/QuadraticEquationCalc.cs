using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UNWE_Exercise_3
{
    class QuadraticEquationCalc:Task
    {
        private string Equation = "";

        public QuadraticEquationCalc(string equation)
        {
            this.Equation = equation;
            this.TaskName = equation;
        }

        public override void ExecuteTask()
        {          
            try
            {
                //value = "-2x^2+3x+5=0";
                double a = 0;
                double b = 0;
                double c = 0;
                string result = "";

                if (this.Equation[0] == '-' || this.Equation[0] == '+')
                {
                    a = double.Parse(this.Equation[0].ToString() + this.Equation[1].ToString());
                    b = double.Parse(this.Equation[5].ToString() + this.Equation[6].ToString());
                    c = double.Parse(this.Equation[8].ToString() + this.Equation[9].ToString());
                }
                else
                {
                    a = double.Parse(this.Equation[0].ToString());
                    b = double.Parse(this.Equation[4].ToString() + this.Equation[5].ToString());
                    c = double.Parse(this.Equation[7].ToString() + this.Equation[8].ToString());
                }

                double Discriminant = b * b - 4 * a * c;

                if (Discriminant > 0)
                {
                    double x1 = Math.Round(((-b) + Math.Sqrt(Discriminant)) / (2 * a), 2);
                    double x2 = Math.Round(((-b) - Math.Sqrt(Discriminant)) / (2 * a), 2);
                    result = string.Format("The equation have two real roots: X1 = {0} and X2 = {1}", x1, x2);
                    
                }
                else if (Discriminant == 0)
                {
                    double x = Math.Round((-b) / (2 * a), 2);
                    result = string.Format("The equation have one real root: X = {0}", x);
                }
                else
                {
                    result = "The equation not have real roots !";
                }

                ShowResult(result);
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
