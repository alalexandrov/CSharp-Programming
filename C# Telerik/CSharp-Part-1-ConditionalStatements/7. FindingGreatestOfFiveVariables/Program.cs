using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7.FindingGreatestOfFiveVariables
{
    class Program
    {
        static void Main(string[] args)
        {
            
            string input = "";
            double[] numbers = new double[] { 1, 2, 3, 4, 5 };

            //Reading input
            for (int i = 0; i < numbers.Length; i++)
            {
                do
                {
                    Console.Write("Enter valid number {0}: ", (i + 1));
                    input = Console.ReadLine();

                } while (!double.TryParse(input, out numbers[i]));
            }

            //Finding max number
            double MaxNum = double.MinValue;
            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] > MaxNum)
                {
                    MaxNum = numbers[i];
                }
            }

            Console.WriteLine("The MAX number is: {0}", MaxNum);
        }
    }
}
