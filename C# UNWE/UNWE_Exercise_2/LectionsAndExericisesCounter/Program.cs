using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LectionsAndExericisesCounter
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Enter start of semester. (date in format: dd.mm.yyyy)");
                DateTime StartDate = //DateTime.Parse(Console.ReadLine());

                StartDate = DateTime.Parse("01.01.2014");
                Console.WriteLine("Enter end of semester.");

                DateTime EndDate = //DateTime.Parse(Console.ReadLine());
                EndDate = DateTime.Parse("05.06.2014");

                if ((EndDate - StartDate).TotalDays < 0)
                {
                    throw new ArgumentException("Invalid date period !");
                }

                Console.WriteLine();
                Console.WriteLine("Enter day of week");
                Console.WriteLine(new string('*', 20));
                Console.WriteLine("'1' for Monday");
                Console.WriteLine("'2' for Tuesday");
                Console.WriteLine("'3' for Wednesday");
                Console.WriteLine("'4' for Thursday");
                Console.WriteLine("'5' for Friday");
                Console.WriteLine("'6' for Saturday");
                Console.WriteLine("'7' for Sunday");
                Console.WriteLine(new string('*', 20));

                Console.Write("Your choice is:");
                int dayOfWeekNum = int.Parse(Console.ReadLine());
                string WeekDay = "";
                switch (dayOfWeekNum)
                {
                    case 1: WeekDay = "Monday"; break;
                    case 2: WeekDay = "Tuesday"; break;
                    case 3: WeekDay = "Wednesday"; break;
                    case 4: WeekDay = "Thursday"; break;
                    case 5: WeekDay = "Friday"; break;
                    case 6: WeekDay = "Saturday"; break;
                    case 7: WeekDay = "Sunday"; break;
                    default: throw new ArgumentException("Invalid day of week number !");
                }

                int counter = 0;
                while (StartDate <= EndDate)
                {
                    if (StartDate.DayOfWeek.ToString() == WeekDay)
                    {
                        //Console.WriteLine(StartDate.ToShortDateString());
                        counter++;
                    }

                    StartDate = StartDate.AddDays(1);
                }

                Console.WriteLine("There are {0} {1}'s in that period !", counter, WeekDay);
            }

            catch (FormatException)
            {
                Console.WriteLine("You entered invalid date format !");
            }

            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
