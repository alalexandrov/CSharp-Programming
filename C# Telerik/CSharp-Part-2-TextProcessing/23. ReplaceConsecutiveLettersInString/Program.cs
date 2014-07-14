using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _23.ReplaceConsecutiveLettersInString
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter string: ");
            string input = Console.ReadLine();

            //Printing consecutive letters one single time 
            for (int i = 0; i < input.Length - 1; i++)
            {
                if (input[i] != input [i + 1])
                {
                    Console.Write(input[i]);
                }
            }
            Console.WriteLine();
        }
    }
}
