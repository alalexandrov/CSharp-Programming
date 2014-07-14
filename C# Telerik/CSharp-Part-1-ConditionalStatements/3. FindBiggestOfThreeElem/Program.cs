using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3.FindBiggestOfThreeElem
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

            if (NumA > NumB)
            {
                if (NumA > NumC)
                {
                    Console.WriteLine("The MAX is first num: {0}", NumA);
                }
                else
                {
                    Console.WriteLine("The MAX is third num: {0}", NumC);
                }
            }
            else
            {
                if (NumB > NumC)
                {
                    Console.WriteLine("The MAX is second num: {0}", NumB);
                }
                else
                {
                    Console.WriteLine("The MAX is third num: {0}", NumC);
                }
            }
        }
    }
}
