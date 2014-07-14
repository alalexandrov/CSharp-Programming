using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3.MaxAndMinNumberFinder
{
    class Program
    {
        static void Main(string[] args)
        {
            
            string input = "";

            //Read valid Length
            int numbersLength = 0;
            do
            {
                Console.Write("Enter how many numbers want to enter: ");              
                input = Console.ReadLine();

            } while ((!int.TryParse(input, out numbersLength)) || numbersLength <= 0);

            int [] numbers = new int [numbersLength];

            for (int i = 0; i < numbers.Length; i++)
            {
                do
                {
                    Console.Write("Enter valid integer number {0}: ", (i + 1));
                    input = Console.ReadLine();
                } while (!int.TryParse(input, out numbers[i]));
            }

            //Finding max and min num
            int MaxNum = int.MinValue;
            int MinNum = int.MaxValue;
            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] > MaxNum)
                {
                    MaxNum = numbers[i];
                }

                if (numbers[i] < MinNum)
                {
                    MinNum = numbers[i];
                }
            }

            Console.WriteLine("The min number is: {0}", MinNum);
            Console.WriteLine("The max number is: {0}", MaxNum);
        }
    }
}
