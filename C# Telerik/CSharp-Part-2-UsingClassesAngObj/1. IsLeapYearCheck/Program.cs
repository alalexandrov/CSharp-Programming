using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.IsLeapYearCheck
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter year: ");
            int year = 0;
            try
            {
                year = int.Parse(Console.ReadLine());
            }
            catch (FormatException fe)
            {
                Console.WriteLine("You enter invalid year !!!", fe);
            }
            
            bool result = DateTime.IsLeapYear(year);
            Console.WriteLine("Year {0} is leap ?: {1}", year, result);
        }
    }
}
