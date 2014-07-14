using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13.ReversingWordsInSentence
{
    class Program
    {
        static void Main(string[] args)
        {
            string sentence = "C# is not C++ and PHP is not Delphi";
            string[] words = sentence.Split(' ');

            Console.WriteLine("Sentence");
            Console.WriteLine(sentence);

            //Reversing words in sentence
            string Reversed = string.Join(" ", words.Reverse());

            Console.WriteLine("\nReversed");
            Console.WriteLine(Reversed);
        }
    }
}
