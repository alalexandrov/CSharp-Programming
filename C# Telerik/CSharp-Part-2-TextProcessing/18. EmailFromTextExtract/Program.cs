using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _18.EmailFromTextExtract
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = "Please contact us by phone (+359 222 222 222) or by email at example@abv.bg or at baj.ivan@yahoo.co.uk. This is not email: test@test. This also: @telerik.com. Neither this: a@a.b.";

            //Getting emails from text who mathes pattern
            string pattern = @"(([\w-]+\.)+[\w-]+|([a-zA-Z]{1}|[\w-]{2,}))@"
           + @"((([0-1]?[0-9]{1,2}|25[0-5]|2[0-4][0-9])\.([0-1]?[0-9]{1,2}|25[0-5]|2[0-4][0-9])\."
             + @"([0-1]?[0-9]{1,2}|25[0-5]|2[0-4][0-9])\.([0-1]?[0-9]{1,2}|25[0-5]|2[0-4][0-9])){1}|"
           + @"([a-zA-Z]+[\w-]+\.)+[a-zA-Z]{2,4})";

            Regex emailRegex = new Regex(pattern, RegexOptions.IgnoreCase);
            MatchCollection emailMatches = emailRegex.Matches(text);

            //Printing emails to console
            Console.WriteLine("Emails:\n");
            foreach (Match emailMatch in emailMatches)
            {
                Console.WriteLine(emailMatch.Value);
            }     
        }
    }
}
