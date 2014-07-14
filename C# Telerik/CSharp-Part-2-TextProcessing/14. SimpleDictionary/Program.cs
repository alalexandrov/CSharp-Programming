using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14.SimpleDictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            string dictionaryText = ".NET - platform for applications from Microsoft\n" +
                                    "CLR - managed execution environment for .NET\n" +
                                    "namespace - hierarchical organization of classes";

            string[] DictLines = dictionaryText.Split('\n');

            //Fill dictionary 
            Dictionary<string, string> WordDictionary = new Dictionary<string, string>();
            foreach (var line in DictLines)
            {
                string[] values = line.Split('-');
                WordDictionary.Add(values[0].Trim().ToLower(), values[1].Trim());
            }

            //Read term from console
            Console.WriteLine("Get explanation of word: ");
            string input = Console.ReadLine();

            if (WordDictionary.ContainsKey(input.ToLower()))
            {
                Console.WriteLine("The word explanation is: {0}", WordDictionary[input]);
            }
            else
            {
                Console.WriteLine("This word is not contain in dictionary !");
            }
        }
    }
}
