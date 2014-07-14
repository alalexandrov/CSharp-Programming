using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20.PolindromesFromTextExtract
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = "abba is not lammal and exe is not kapak  but abba is exe";

            //Getting words from text
            char[] characters = { ' ', ',', '.', '!', '?' };
            string[] TextWords = text.Split(characters, StringSplitOptions.RemoveEmptyEntries);

            //Checking words for polindromes
            List<string> polindromes = new List<string>();
            foreach (var word in TextWords)
            {
                if (IsPolindrome(word) && !polindromes.Contains(word))
                {
                    polindromes.Add(word);
                }
            }

            Console.WriteLine("The polindromes are:");
            Console.WriteLine(string.Join(", ", polindromes));
        }

        public static bool IsPolindrome(string word)
        {
            for (int i = 0; i < word.Length / 2; i++)
            {
                if (word[i] != word[word.Length - i - 1])
                {
                    return false;
                } 
            }
            return true;
        }
    }
}
