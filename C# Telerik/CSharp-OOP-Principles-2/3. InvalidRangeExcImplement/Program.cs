using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3.InvalidRangeExcImplement
{
    class Program
    {
        static void Main(string[] args)
        {
            //Test InvalidRangeException class 

            //Test with integers
            int StartRange = 1;
            int EndRange = 100;
            int number = 0;
            while (true)
            {
                Console.WriteLine("Enter number: ");
                try
                {
                    number = int.Parse(Console.ReadLine());
                }
                catch (FormatException)
                {
                    Console.WriteLine("You enter invalid integer number!\n");
                    continue;
                }

                if (number < 1 || number > 100)
                {
                    throw new InvalidRangeException<int>("Invalid number!", StartRange, EndRange);
                }
            }

            //Test with dates

            //DateTime startRangeDate = new DateTime(1980, 1, 1);
            //DateTime endRangeDate = new DateTime(2013, 12, 31);
            //DateTime inputDate = new DateTime();
            //while (true)
            //{
            //    Console.WriteLine("Enter date: ");
            //    try
            //    {
            //        inputDate = DateTime.Parse(Console.ReadLine());
            //    }
            //    catch (FormatException)
            //    {
            //        Console.WriteLine("Invalid date. Date must be in format d.M.yyyy!\n");
            //        continue;
            //    }

            //    if (inputDate < startRangeDate || inputDate > endRangeDate)
            //    {
            //        throw new InvalidRangeException<DateTime>("Invalid date!", startRangeDate, endRangeDate);
            //    }
            //}
        }
    }
}
