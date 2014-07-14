using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.ExchangingIntegerVariablesByCondition
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = "";
            int FirstVar = 0;
            int SecondVar = 0;

            do
            {
                Console.Write("Enter first number (valid integer): ");
                input = Console.ReadLine();
            } while (!int.TryParse(input, out FirstVar));

            do
            {
                Console.Write("Enter second number (valid integer): ");
                input = Console.ReadLine();
            } while (!int.TryParse(input, out SecondVar));

            if (FirstVar > SecondVar)
            {
                int temp = 0;
                temp = FirstVar;
                FirstVar = SecondVar;
                SecondVar = temp;

                Console.WriteLine("The values of variables are exchanged !");
            }
    
                Console.WriteLine("First var: {0}", FirstVar);
                Console.WriteLine("Second var: {0}", SecondVar);        
        }
    }
}
