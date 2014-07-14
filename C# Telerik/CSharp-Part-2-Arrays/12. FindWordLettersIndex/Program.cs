using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12.FindWordLettersIndex
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] AlphabetLetters = { "A", "B", "C", "D", "E", "F", "G", "H", "I", "J", "K", "L", "M", "N", "O", "P", "Q", "R", "S", "T", "U", "V", "W", "X", "Y", "Z" };

            Console.Write("Enter word: ");
            string word = Console.ReadLine();

            for (int i = 0; i < word.Length; i++)
            {
                for (int j = 0; j < AlphabetLetters.Length; j++)
                {
                    if (word[i].ToString().ToUpper() == AlphabetLetters[j])
                    {
                        Console.WriteLine("{0} -> index {1}", word[i].ToString(), j);
                    }
                }
            }
        }
    }
}
