using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4.SortThreeValuesWithCondStatement
{
    class Program
    {
        static void Main(string[] args)
        {
            int NumA = 0;
            int NumB = 3;
            int NumC = 5;
            string input = "";

            Console.WriteLine("Enter three valid integer numbers");
            do
            {
                Console.Write("Enter first num: ");
                input = Console.ReadLine();
            } while (!int.TryParse(input, out NumA));

            do
            {
                Console.Write("Enter second num: ");
                input = Console.ReadLine();
            } while (!int.TryParse(input, out NumB));

            do
            {
                Console.Write("Enter third num: ");
                input = Console.ReadLine();
            } while (!int.TryParse(input, out NumC));

            if (NumA < NumB)
            {
                int temp = 0;
                temp = NumA;
                NumA = NumB;
                NumB = temp;
            }

            if (NumB < NumC)
            {
                int temp = 0;
                temp = NumB;
                NumB = NumC;
                NumC = temp;
            }

            if (NumA < NumB)
            {
                int temp = 0;
                temp = NumA;
                NumA = NumB;
                NumB = temp;
            }

            Console.WriteLine("The number sorted in descending order is: {0}, {1}, {2}", NumA, NumB, NumC);
        }
    }
}
