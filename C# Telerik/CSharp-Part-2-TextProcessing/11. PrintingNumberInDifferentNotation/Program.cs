using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11.PrintingNumberInDifferentNotation
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter decimal number: ");
            int number = 0;
            try
            {
                number = int.Parse(Console.ReadLine());
            }
            catch (FormatException fe)
            {
                Console.WriteLine("You enter invalid decimal number !!!", fe);
                return;
            }

            //Printing number in different notation
            Console.WriteLine("{0,15} - Number in decimal number notation", number);
            Console.WriteLine("{0,15:X} - Number in hex number notation", number);
            Console.WriteLine("{0,15:P} - Number in percentage number notation", number);
            Console.WriteLine("{0,15:E} - Number in scientific number notation", number);
            
        }
    }
}
