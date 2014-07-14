using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5.WorkDaysCounter
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime EndDate = new DateTime(2015, 1, 1);
            int WorkDaysCount = CountWorkDays(EndDate);
            Console.WriteLine("The workdays between today and {0} are: {1}", EndDate.ToShortDateString(), WorkDaysCount);
        }

        public static int CountWorkDays(DateTime EndDate)
        {
            DateTime[] holidays = { new DateTime(2014, 7, 7), 
                                  new DateTime(2014, 8, 5),
                                  new DateTime(2014, 9, 2),
                                  new DateTime(2014, 10, 13),
                                  new DateTime(2014, 11, 8)};

            int count = 0;
            DateTime currentDate = DateTime.Now;

            while (currentDate <= EndDate)
            {
                if (!holidays.Contains(currentDate) &&
                    currentDate.DayOfWeek.ToString() != "Sunday" &&
                    currentDate.DayOfWeek.ToString() != "Saturday")
                {
                    count++;
                }

                currentDate = currentDate.AddDays(1);
            }

            return count;
        }
    }
}
