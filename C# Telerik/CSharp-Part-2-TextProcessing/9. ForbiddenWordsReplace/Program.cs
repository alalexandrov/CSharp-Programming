using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9.ForbiddenWordsReplace
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = "Microsoft announced its next generation PHP compiler today. It is based on .NET Framework 4.0 and is implemented as a dynamic language in CLR.";
            string words = "PHP, CLR, Microsoft";

            char[] characters = { ' ', ',' };
            string[] ForbiddenWords = words.Split(characters, StringSplitOptions.RemoveEmptyEntries);

            Console.WriteLine("Text");
            Console.WriteLine(text);

            //Replace forbidden words in text with '*'
            foreach (var word in ForbiddenWords)
            {
                text = text.Replace(word, new string('*', word.Length));
            }

            Console.WriteLine("\nThe result is ");
            Console.WriteLine(text);
        }
    }
}
