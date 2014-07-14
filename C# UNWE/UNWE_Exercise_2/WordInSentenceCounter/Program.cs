using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WordInSentenceCounter
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = "Obicha Alexander obicha portokali. Alexander zaobicha qbulki. Alexander cepi mraka. Obicham da programiram.";
            string word = "obicha";
            char[] symbols = {'.', '!', '?'};
            string[] sentences = text.Split(symbols, StringSplitOptions.RemoveEmptyEntries);
            Console.WriteLine("The sentences with word [ {0} ] :", word);
            Console.WriteLine();
            for (int i = 0; i < sentences.Length; i++)
            {
                if (IsContainsSameWord(word,sentences[i]))
                {
                    Console.WriteLine(sentences[i].Trim());
                }           
            }
            
        }

        private static bool IsContainsSameWord(string word, string sentence)
        {
            int WordIndex = sentence.ToLower().IndexOf(word.ToLower());
            if (WordIndex != -1 && !char.IsLetter(sentence,WordIndex + word.Length))               
            {
                if (WordIndex - 1 == -1 || !char.IsLetter(sentence, WordIndex - 1))
                {
                    return true;
                }
            }
            return false;
        }
    }
}
