using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13.WordsOccurencesCounter
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                //Reading text from first file
                StreamReader TextReader = new StreamReader("..\\..\\Text5.txt");
                string InputText = "";

                using (TextReader)
                {
                    InputText = TextReader.ReadToEnd();
                }

                //Reading words from second file
                StreamReader WordsReader = new StreamReader("..\\..\\WordsToCount.txt");
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

                //Getting each word occurences
                StringBuilder output = new StringBuilder();
                foreach (var word in Words)
                {
                    output.AppendLine(String.Format("{0} -> {1} times.", word, GetWordCount(InputText, word)));
                }

                //Writing output to file
                StreamWriter writer = new StreamWriter("..\\..\\Result.txt");
                using (writer)
                {
                    writer.WriteLine(output);
                }

                //Printing output to console
                Console.WriteLine("The occurences of each given word are:");
                Console.WriteLine(output);
                Console.WriteLine("The result is saved to Result.txt");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            
        }

        public static int GetWordCount(string text, string Word)
        {
            if (text == null || Word == null )
            {
                throw new ArgumentException("The given text or word can't be null");
            }

            int count = 0;

            //Getting words with punctoation
            char[] characters = { ' ' };
            string[] Words = text.Split(characters, StringSplitOptions.RemoveEmptyEntries);

            for (int i = 0; i < Words.Length; i++)
            {
                string Current = Words[i];
                bool IsSameWord = false;

                //Check is current is same as given word
                if (Current.Contains(Word))
                {
                    if (Current.Length == Word.Length)
                    {
                        IsSameWord = true;
                    }
                    else
                    {
                        bool WordBeginCheck = Current.First() == Word.First() || !char.IsLetter(Current.First());
                        bool WordEndCheck = Current.Last() == Word.Last() || !char.IsLetter(Current.Last());
                        IsSameWord = WordBeginCheck && WordEndCheck;
                    }
                }

                if (IsSameWord)
                {
                    count++;
                }
            }

            return count;
        }
    }
}
