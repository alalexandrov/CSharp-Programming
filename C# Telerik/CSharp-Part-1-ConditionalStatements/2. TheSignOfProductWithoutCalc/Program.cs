using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.TheSignOfProductWithoutCalc
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
                Console.Write("Enter num 1: ");
                input = Console.ReadLine();
            } while (!int.TryParse(input, out NumA));

            do
            {
                Console.Write("Enter num 2: ");
                input = Console.ReadLine();
            } while (!int.TryParse(input, out NumB));

            do
            {
                Console.Write("Enter num 3: ");
                input = Console.ReadLine();
            } while (!int.TryParse(input, out NumC));

            
            if (NumA != 0 && NumB != 0 && NumC != 0)
            {
                int negativeNumCount = 0;
                if (NumA < 0)
                {
                    negativeNumCount++;
                }

                if (NumB < 0)
                {
                    negativeNumCount++;
                }

                if (NumC < 0)
                {
                    negativeNumCount++;
                }

                if (negativeNumCount % 2 == 0)
                {
                    Console.WriteLine("The sign of product is: ' + '");
                }
                else
                {
                    Console.WriteLine("The sign of product is: ' - '");
                }
            }
            else
            {
                Console.WriteLine("The product is: ' 0 '");
            }
        }
    }
}
