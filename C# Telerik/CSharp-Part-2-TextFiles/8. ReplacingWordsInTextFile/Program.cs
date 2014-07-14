using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8.ReplacingWordsInTextFile
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {

                StreamReader reader = new StreamReader("..\\..\\Text3Small.txt");
                StreamWriter writer = new StreamWriter("..\\..\\Result.txt");

                using (writer)
                {
                    using (reader)
                    {
                        //Reading text file line by line and replacing word start with word finish
                        string CurrentLine = reader.ReadLine();

                        while (CurrentLine != null)
                        {
                            CurrentLine = ReplaceWord(CurrentLine, "start", "finish");
                            writer.WriteLine(CurrentLine);
                            CurrentLine = reader.ReadLine();
                        }
                    }
                }

                Console.WriteLine("The result is saved at Result.txt");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        public static string ReplaceWord(string text, string OldWord, string NewWord)
        {
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
