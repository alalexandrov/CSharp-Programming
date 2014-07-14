using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8.GreatestCommonDivisorOfTwoNum
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = "";
            Console.WriteLine("Enter positive A AND B ");
            //Read valid A
            int numberA = 0;
            do
            {
                Console.Write("Enter A: ");
                input = Console.ReadLine();

            } while ((!int.TryParse(input, out numberA)) || numberA <= 0);

            //Read valid B
            int numberB = 0;
            do
            {
                Console.Write("Enter B: ");
                input = Console.ReadLine();

            } while ((!int.TryParse(input, out numberB)) || numberB <= 0);

            //Euclidean algorithm simple implementation

            int temp = 0;
            int remainder = numberA;
            int nextRemainder = numberB;

            while (nextRemainder != 0)
            {
                temp = nextRemainder;
                nextRemainder = remainder % nextRemainder;
                remainder = temp;
            }

            Console.WriteLine("The greatest common divisor of {0} and {1} is: {2}", numberA, numberB, remainder);
        }
    }
}
