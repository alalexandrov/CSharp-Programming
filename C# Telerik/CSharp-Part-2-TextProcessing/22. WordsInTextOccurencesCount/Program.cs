using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _22.WordsInTextOccurencesCount
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter text: ");
            string text = Console.ReadLine();

            char[] characters = { ' ', ',', '.', '!', '?' };
            string[] words = text.Split(characters, StringSplitOptions.RemoveEmptyEntries);

            //Getting how many times each word is found in text
            Dictionary<string, int> WordCounts = new Dictionary<string, int>();

            for (int i = 0; i < words.Length; i++)
            {
                if (WordCounts.ContainsKey(words[i]))
                {
                    WordCounts[words[i]]++;
                }
                else
                {
                    WordCounts.Add(words[i], 1);
                }
            }

            //Printing words with their occurences
            foreach (var word in WordCounts)
            {
                Console.WriteLine("{0} -> {1} times", word.Key, word.Value);
            }
        }
    }
}
