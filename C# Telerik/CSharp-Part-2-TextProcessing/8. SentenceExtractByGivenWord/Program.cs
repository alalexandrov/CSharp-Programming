using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8.SentenceExtractByGivenWord
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = "We are living in a yellow submarine. We don't have anything else. Inside the submarine is very tight. So we are drinking all the day. We will move out of it in 5 days.";
            char[] symbols = {'.'};
            string[] sentences = text.Split(symbols, StringSplitOptions.RemoveEmptyEntries);
            string Word = "in";

            //Getting sentences that contain word 'in'
            Console.WriteLine(text + "\n");
            Console.WriteLine("The sentences containing word '{0}' are:\n", Word);
            foreach (var sentence in sentences)
            {
                if (IsContainWord(sentence, Word))
                {
                    Console.WriteLine(sentence.Trim() + ".");
                }
            }
            Console.WriteLine();
        }

        public static bool IsContainWord(string text, string word)
        {
            int index = text.IndexOf(word);
            if (index != -1)
            {
                while (index != -1)
                {
                    bool WordBeginCheck = index == 0 || !char.IsLetter(text[index - 1]);
                    bool WordEndCheck = index + word.Length == text.Length || !char.IsLetter(text[index + word.Length]);

                    if (WordBeginCheck && WordEndCheck)
                    {
                        return true;
                    }

                    index = text.IndexOf(word, index + 1);
                }
            }
            return false;
        }
    }
}
