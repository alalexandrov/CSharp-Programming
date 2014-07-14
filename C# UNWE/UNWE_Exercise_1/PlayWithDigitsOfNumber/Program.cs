using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlayWithDigitsOfNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.Write("Please enter 4-digit integer number: ");
              
                int number = int.Parse(Console.ReadLine());

                if (number > 9999 || number < 1000)
                {
                    throw new ArgumentException();
                }

                int firstDigit = (number / 1000) % 10;
                int SecondDigit = (number / 100) % 10;
                int ThirdDigit = (number / 10) % 10;
                int FourthDigit = number % 10;

                Console.WriteLine("The sum of digits is: {0}", (firstDigit + SecondDigit + ThirdDigit + FourthDigit));
                Console.WriteLine("Reversed digits: {3}{2}{1}{0}", firstDigit, SecondDigit, ThirdDigit, FourthDigit);
                Console.WriteLine("Last digit on first place: {3}{0}{1}{2}", firstDigit, SecondDigit, ThirdDigit, FourthDigit);
                Console.WriteLine("Reversed second and third digit: {0}{2}{1}{3}", firstDigit, SecondDigit, ThirdDigit, FourthDigit);
            }

            catch(Exception)
            {
                Console.WriteLine("Enter a valid 4-digit number !");
            }
        }
    }
}
