using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DivideBy_5_and_7_Check
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

            if (number % 5 == 0 && number % 7 == 0)
            {
                Console.WriteLine("Entered number is divide by 7 and 5 without remainder !");
            }
            else
            {
                Console.WriteLine("Entered number is NOT divide by 7 and 5 without remainder !");
            }
        }
    }
}
