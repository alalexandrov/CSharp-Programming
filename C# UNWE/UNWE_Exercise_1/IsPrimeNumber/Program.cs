using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IsPrimeNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.Write("Please enter integer number: ");
                int number = int.Parse(Console.ReadLine());

                Console.WriteLine("Enter 1 to use Algorith 1");
                Console.WriteLine("Enter 2 to use Algorith 2");
                Console.Write("Your choice is: ");
                int choice = int.Parse(Console.ReadLine());
                bool IsPrime = false;

                switch (choice)
                {
                    case 1: IsPrime = IsPrimeAlg1(number); break;
                    case 2: IsPrime = IsPrimeAlg2(number); break;
                    default: throw new ArgumentException("Invalid choice !");
                }

                Console.WriteLine("###################");
                Console.WriteLine("Entered number is Prime ? : " + IsPrime);
            }

            catch (FormatException)
            {
                Console.WriteLine("You enter invalid integer number !");
            }

            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

        private static bool IsPrimeAlg2(int number)
        {
            double MaxDivider = number / 2;
            bool IsPrime = true;
            for (int i = 2; i <= MaxDivider; i++)
            {
                if (number % i == 0)
                {
                    IsPrime = false;
                    break;
                }
            }
            return IsPrime;
        }

        private static bool IsPrimeAlg1(int number)
        {
            double MaxDivider = Math.Sqrt(number);
            bool IsPrime = true;
            for (int i = 2; i <= MaxDivider; i++)
            {
                if (number % i == 0)
                {
                    IsPrime = false;
                    break;
                }
            }
            return IsPrime;
        }
    }
}
