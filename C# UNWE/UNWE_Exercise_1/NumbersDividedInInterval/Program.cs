using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumbersDividedInInterval
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.Write("Enter start of interval: ");
                int start = int.Parse(Console.ReadLine());
                Console.Write("Enter end of interval: ");
                int end = int.Parse(Console.ReadLine());

                if (start >= end)
                {
                    throw new ArgumentException("Start of interval must be bigger than end !");
                }

                Console.WriteLine();
                Console.WriteLine("Enter 1 for numbers divide by 3");
                Console.WriteLine("Enter 2 for numbers divide by 4");
                Console.WriteLine("Enter 3 for numbers divide by 9");
                Console.Write("Your choice is ? : ");

                int choice = int.Parse(Console.ReadLine());
                int divider = 0;

                switch (choice)
                {
                    case 1: divider = 3; break;
                    case 2: divider = 4; break;
                    case 3: divider = 9; break;
                    default: throw new ArgumentException("Choice must be: 1, 2 or 3 !");
                }

                // Getting numbers divide by divider without remainder 
                List<int> numbers = new List<int>();
                for (int i = start; i <= end; i++)
                {
                    if (i % divider == 0)
                    {
                        numbers.Add(i);
                    }
                }

                Console.WriteLine("*******************************");
                Console.Write("The numbers divide by {0} is: ", divider);
                Console.WriteLine(string.Join(",", numbers));
            }

            catch(FormatException)
            {
                Console.WriteLine("You entered invalid arguments !");
            }

            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
