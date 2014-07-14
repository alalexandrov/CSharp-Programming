using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11.PrintingMatrixByGivenNum
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = "";

            //Read valid N
            int number = 0;
            do
            {
                Console.Write("Enter positive integer number N (N<20): ");
                input = Console.ReadLine();

            } while ((!int.TryParse(input, out number)) || number <= 0 || number >= 20);

            //Printing matrix
            for (int row = 1; row <= number; row++)
            {
                for (int col = row; col <= row + number - 1; col++)
                {
                    Console.Write(" {0} ", col);
                }

                Console.WriteLine();
            }
        }
    }
}
