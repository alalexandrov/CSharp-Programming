using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6.StringPadRightWithStars
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = "";
            do
            {
                Console.Write("Enter string of maximum 20 characters: ");
                input = Console.ReadLine();
            } while (input.Length > 20);

            Console.WriteLine("\nResult is: {0}", input.PadRight(20,'*'));
        }
    }
}
