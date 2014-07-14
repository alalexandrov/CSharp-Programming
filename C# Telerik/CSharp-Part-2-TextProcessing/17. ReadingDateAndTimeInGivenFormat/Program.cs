using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _17.ReadingDateAndTimeInGivenFormat
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                //Read date from console in format (day.month.year hour:minutes:seconds)
                Console.WriteLine("Enter date (day.month.year hour:minutes:seconds): ");
                DateTime date = DateTime.ParseExact(Console.ReadLine(), "d.M.yyyy H:m:s", CultureInfo.InvariantCulture);

                //Adding 6 hours and 30 minutes
                date = date.AddHours(6);
                date = date.AddMinutes(30);

                //Printing to console with bulgarian culture
                Console.OutputEncoding = Encoding.GetEncoding("windows-1251");
                Console.WriteLine(date.ToString("d.MM.yyyy HH:mm:ss"));
                Console.WriteLine(date.ToString("dddd", new CultureInfo("bg-BG")));
            }
            catch (FormatException fe)
            {
                Console.WriteLine("Invalid date !", fe);
            }
        }
    }
}
