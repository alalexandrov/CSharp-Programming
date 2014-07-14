using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11.DeleteWordsByGivenPrefixFromTextFile
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {

                StreamReader reader = new StreamReader("..\\..\\Text5.txt");
                StringBuilder output = new StringBuilder();

                using (reader)
                {
                    //Reading text file line by line
                    string CurrentLine = reader.ReadLine();
                  
                    while (CurrentLine != null)
                    {
                        CurrentLine = RemoveWordWithPrefix(CurrentLine, "test");
           
                        output.AppendLine(CurrentLine);
                        CurrentLine = reader.ReadLine();
                    }
                }

                ////Overwriting file with ouput 
                //StreamWriter writer = new StreamWriter("..\\..\\Text5.txt");
                //using (writer)
                //{
                //    writer.WriteLine(output);
                //}

                Console.WriteLine("The words with prefix 'test' was removed successfully !!!");
                Console.WriteLine(output);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        public static string RemoveWordWithPrefix(string text, string prefix)
        {
            //Getting words with punctoation
            char[] characters = { ' ' };
            string[] Words = text.Split(characters, StringSplitOptions.RemoveEmptyEntries);

            for (int i = 0; i < Words.Length; i++)
            {
                string Current = Words[i];

                bool ContainsPrefix = Current.Contains(prefix);
                bool IsPrefix = Current.First() == prefix.First() || !char.IsLetter(Current.First());

                bool HavePrefix = ContainsPrefix && IsPrefix;

                if (HavePrefix)
                {
                    //If current have prefix -> remove current
                    Words[i] = "";

                    //If current have punctoation -> adding it back
                    foreach (var symbol in Current)
                    {
                        if (char.IsPunctuation(symbol))
                        {
                            Words[i] += symbol;
                        }
                    }
                }
            }

            // Joining back words
            text = string.Join(" ", Words);

            return text;
        }
    }
}
