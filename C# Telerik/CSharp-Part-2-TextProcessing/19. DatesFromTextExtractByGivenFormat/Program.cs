using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _19.DatesFromTextExtractByGivenFormat
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = "I was born at 14.06.1980. My sister was born at 3.7.1984. In 5/1999 I graduated my high school. The law says (see section 7.3.12) that we are allowed to do this (section 7.4.2.9).";

            //Getting words in text
            char[] characters = { ' ', ',', '!', '?', '(', ')' };
            string[] words = text.Split(characters, StringSplitOptions.RemoveEmptyEntries);

            //Checking dates which match format d.M.yyyy and printing them to console
            DateTime date = new DateTime();
            Console.WriteLine("Dates in text are: ");
            foreach (var word in words)
            {
                if (DateTime.TryParseExact(word.Trim('.'), "d.M.yyyy", CultureInfo.InvariantCulture, DateTimeStyles.None, out date))
                {
                    Console.WriteLine(date.ToString("yyyy-MM-dd", new CultureInfo("en-CA")));
                }
            }
        }
    }
}
