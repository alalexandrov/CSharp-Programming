using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = 0;
            while (true)
            {
                Console.WriteLine("Please enter positive integer number: ");              
                try
                {
                    number = int.Parse(Console.ReadLine());

                    if (number < 0)
                    {
                        Console.Clear();
                        Console.WriteLine("The number must be positive !\n");
                        continue;
                    }
                    break;
                }
                catch (FormatException)
                {
                    Console.Clear();
                    Console.WriteLine("Invalid integer number !\n");
                }
            }

            if (number == 0)
            {
                Console.Clear();
                Console.WriteLine("Good bye !!!");
                return;
            }

            List<int> PrimeNumbers = new List<int>();
            for (int i = 2; i <= number; i++)
            {
                if (IsPrime(i))
                {
                    PrimeNumbers.Add(i);
                }
            }

            Console.Clear();
            Console.WriteLine("The prime numbers from 0 to N are: ");
            if (PrimeNumbers.Count != 0)
            {
                Console.WriteLine(string.Join(",", PrimeNumbers));
            }
            else
            {
                Console.WriteLine("No numbers !");
            }
            
            
        }

        public static bool IsPrime(int Number)
        {
            if (Number < 2)
            {
                return false;
            }

            double MaxDivider = Math.Sqrt(Number);
            for (int i = 2; i <= MaxDivider; i++)
            {
                if (Number % i == 0)
                {
                    return false;
                }
            }
            return true;
        }
    }
}
