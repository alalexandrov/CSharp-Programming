using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12.RemoveAllGivenWordsFromFile
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                //Reading text from first file
                StreamReader TextReader = new StreamReader("..\\..\\Text.txt");
                string InputText = "";

                using (TextReader)
                {
                    InputText = TextReader.ReadToEnd();
                }

                //Reading words from second file
                StreamReader WordsReader = new StreamReader("..\\..\\WordsToRemove.txt");
                List<string> Words = new List<string>();
                using (WordsReader)
                {
                    string line = WordsReader.ReadLine();
                    while (line != null)
                    {
                        Words.Add(line.Trim());
                        line = WordsReader.ReadLine();
                    }
                }

                //Removing given words from input text
                foreach (var word in Words)
                {
                    InputText = ReplaceWord(InputText, word, "");
                }

                //Override first file text with input text
                //StreamWriter writer = new StreamWriter("..\\..\\Text.txt");
                //using (writer)
                //{
                //    writer.WriteLine(Text);
                //}

                Console.WriteLine("The output text is");
                Console.WriteLine(InputText);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            
        }
        public static string ReplaceWord(string text, string OldWord, string NewWord)
        {
            if (text == null || OldWord == null || NewWord == null)
            {
                throw new ArgumentException("The given text, old word and new word can't be null");
            }

            //Getting words with punctoation
            char[] characters = { ' ' };
            string[] Words = text.Split(characters, StringSplitOptions.RemoveEmptyEntries);

            for (int i = 0; i < Words.Length; i++)
            {
                string Current = Words[i];
                bool IsSameWord = false;

                //Check is current is same as old word
                if (Current.Contains(OldWord))
                {
                    if (Current.Length == OldWord.Length)
                    {
                        IsSameWord = true;
                    }
                    else
                    {
                        bool WordBeginCheck = Current.First() == OldWord.First() || !char.IsLetter(Current.First());
                        bool WordEndCheck = Current.Last() == OldWord.Last() || !char.IsLetter(Current.Last());
                        IsSameWord = WordBeginCheck && WordEndCheck;
                    }
                }

                //If current is same as old word -> replace old word with new word
                if (IsSameWord)
                {
                    Words[i] = Current.Replace(OldWord, NewWord);
                }

            }

            // Joining back words
            text = string.Join(" ", Words);

            return text;
        }
    }
}
