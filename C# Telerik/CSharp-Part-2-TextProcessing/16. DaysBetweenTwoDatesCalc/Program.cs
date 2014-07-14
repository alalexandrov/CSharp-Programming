using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _16.DaysBetweenTwoDatesCalc
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                //Reading two dates from console
                Console.Write("Enter the first date (day.month.year): ");
                DateTime firstDate = DateTime.ParseExact(Console.ReadLine(), "d.M.yyyy", CultureInfo.InvariantCulture);

                Console.Write("Enter the second date (day.month.year): ");
                DateTime secondDate = DateTime.ParseExact(Console.ReadLine(), "d.M.yyyy", CultureInfo.InvariantCulture);

                //Calculate absolute difference between dates in days
                int DaysDifference = Math.Abs((firstDate - secondDate).Days);
                Console.WriteLine("The number of days between this dates is: {0} days", DaysDifference);
            }
            catch (FormatException fe)
            {
                Console.WriteLine("Incorect date !!!", fe);
            }
            
        }
    }
}
