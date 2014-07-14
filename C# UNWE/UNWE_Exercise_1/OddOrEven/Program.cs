using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OddOrEven
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Please enter integer number: ");
            string value = Console.ReadLine();
            int number = 0;

            while (!int.TryParse(value, out number))
            {
                Console.Write("Please enter a valid integer number !: ");
                value = Console.ReadLine();
            }

            if (number % 2 == 0)
            {
                Console.WriteLine("Entered number is Even !");
            }
            else
            {
                Console.WriteLine("Entered number is Odd !");
            }
        }
    }
}
