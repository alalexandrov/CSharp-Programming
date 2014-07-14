using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace Exercise_1
{
    class Program
    {
        static void Main(string[] args)
        {
            string Input = "a";
            while (Input != "")
            {
                Console.WriteLine("Please enter date in format (dd/mm/yyyy): ");
                Input = Console.ReadLine();
                if (Input == "")
                {
                    Console.Clear();
                    Console.WriteLine("Good bye :)");
                    break;
                }

                DateTime date = new DateTime();
                try
                {
                    date = DateTime.Parse(Input, System.Globalization.CultureInfo.CurrentCulture);
                }
                catch (FormatException)
                {
                    Console.Clear();
                    Console.WriteLine("Invalid date !\n");
                    continue;
                }

                string WeekDayOnEnglish = date.DayOfWeek.ToString();
                string WeekDayOnBulgarian = "";
                switch (WeekDayOnEnglish)
                {
                    case "Monday": WeekDayOnBulgarian = "Ponedelnik"; break;
                    case "Tuesday": WeekDayOnBulgarian = "Vtornik"; break;
                    case "Wednesday": WeekDayOnBulgarian = "Srqda"; break;
                    case "Thursday": WeekDayOnBulgarian = "Chetvurtuk"; break;
                    case "Friday": WeekDayOnBulgarian = "Petak"; break;
                    case "Saturday": WeekDayOnBulgarian = "Subota"; break;
                    case "Sunday": WeekDayOnBulgarian = "Nedelq"; break;
                }

                Console.Clear();
                Console.WriteLine(date.ToShortDateString());
                Console.WriteLine("Day of week: {0}", WeekDayOnEnglish);
                Console.WriteLine("Den ot sedmicata: {0}\n", WeekDayOnBulgarian);
            }
        }
    }
}
