using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _21.LettersInStringOccurenceCount
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter string: ");
            string input = Console.ReadLine();

            //Get occurences for each letter in string
            Dictionary<char, int> letters = new Dictionary<char, int>();
            for (int i = 0; i < input.Length; i++)
            {
                if (letters.ContainsKey(input[i]))
                {
                    letters[input[i]]++;
                }
                else
                {
                    letters.Add(input[i], 1);
                }
            }

            //Print letters and how many times each letter is found
            foreach (var letter in letters)
            {
                Console.WriteLine("{0} -> {1} times", letter.Key, letter.Value);
            }
        }
    }
}
