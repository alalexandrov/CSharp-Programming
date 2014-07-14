using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13.DifferentTasksSolver
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Tasks: ");
            Console.WriteLine("To reverse digits of given decimal number enter '1'");
            Console.WriteLine("To calculate average of given numbers enter '2'");
            Console.WriteLine("To solve linear equation a * x + b = 0 enter '3'");
            Console.Write("Your choice is: ");
            string choise = Console.ReadLine();
            Console.Clear();

            try
            {
                switch (choise)
                {
                    case "1":
                        Console.Write("Enter valid decimal number: ");
                        decimal number = decimal.Parse(Console.ReadLine());
                        Console.WriteLine("The reversed number is: {0}", ReverseDigits(number));
                        break;
                    case "2":
                        Console.Write("How many numbers want to enter: ");
                        int length = int.Parse(Console.ReadLine());
                        double[] numbers = new double[length];
                        for (int i = 0; i < length; i++)
                        {
                            Console.Write("Enter num {0}: ", i + 1);
                            numbers[i] = double.Parse(Console.ReadLine());
                        }
                        Console.WriteLine("Average of numbers is: {0}", GetAvg(numbers));
                        break;
                    case "3":
                        Console.Write("Enter param 'a': ");
                        double paramA = double.Parse(Console.ReadLine());
                        Console.Write("Enter param 'b': ");
                        double paramB = double.Parse(Console.ReadLine());
                        Console.WriteLine("X = {0}", SolveEquation(paramA, paramB));
                        break;
                    default:
                        Console.WriteLine("Wrong choise !!!");
                        break;
                }
            }
            catch (FormatException fe)
            {
                Console.WriteLine("You enter invalid value !", fe);
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }
            finally
            {
                Console.WriteLine("\nGood bye !!!");
            }
        }

        public static decimal ReverseDigits(decimal number)
        {
            if (number < 0)
            {
                throw new ArgumentException("The given decimal number must be positive !");
            }

            string NumStr = number.ToString();
            string ReversedNumStr = string.Join("", NumStr.Reverse());
            return decimal.Parse(ReversedNumStr);
        }

        public static double GetAvg(double[] numbers)
        {
            if (numbers == null)
            {
                throw new ArgumentException("Given array can't be null !");
            }

            if (numbers.Length == 0)
            {
                throw new ArgumentException("The given sequence of numbers should not be empty !");
            }

            double sum = 0;
            for (int i = 0; i < numbers.Length; i++)
            {
                sum += numbers[i];
            }

            return sum / numbers.Length;
        }

        public static double SolveEquation(double paramA, double paramB)
        {
            if (paramA == 0)
            {
                throw new ArgumentException("The parameter 'a' can't be '0'");
            }

            return (paramB / paramA) * (-1);
        }
    }
}
