using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UNWE_Exercise_3
{
    class Program
    {
        public static void Main()
        {
            try
            {
                Console.WriteLine("To solve Quadratic equation enter '1' and Press Enter ! \n");
                Console.WriteLine("To extract info from Human ID number enter '2' and Press Enter ! \n");
                Console.Write("Your choice is:");
                int choice = int.Parse(Console.ReadLine());
                string input = "";


                switch (choice)
                {
                    case 1: Console.WriteLine("\nPlease enter qudratic equation like this: 'ax^2+bx+c=0'");
                        input = Console.ReadLine();
                        QuadraticEquationCalc Equation = new QuadraticEquationCalc(input);
                        Equation.ExecuteTask();
                        break;
                    case 2: Console.Write("\nPlease enter your ID number: ");
                        input = Console.ReadLine();
                        IdInfoExtractor Id = new IdInfoExtractor(input);
                        Id.ExecuteTask();
                        break;
                    default: throw new ArgumentException();
                }
            }
            
            catch (Exception)
            {
                Console.WriteLine("Invalid choice !!!");
            }
        }
    }
}
