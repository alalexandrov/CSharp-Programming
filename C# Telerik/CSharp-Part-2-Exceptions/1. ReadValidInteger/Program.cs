using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.ReadValidInteger
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter valid integer number: ");
            int number = 0;
            try
            {
                number = int.Parse(Console.ReadLine());
                if (number < 0)
                {
                    throw new ArgumentException("Number must be positive !");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Invalid number, {0}", ex.Message);
            }
        }
    }
}
