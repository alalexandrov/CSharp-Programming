using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_3
{
    class Program
    {

        static void Main(string[] args)
        {
            Dictionary<string, string> InterpretationDictionary = new Dictionary<string, string>();
            Dictionary<string, string> СynonymousDictionary = new Dictionary<string, string>();
            Dictionary<string, string> EnglishDictionary = new Dictionary<string, string>();
            string word = "";
            string choice = "";
            while (true)
            {

                Console.WriteLine("For adding a word to Dictionary enter '1'");
                Console.WriteLine("For getting word from Dictionary enter '2'");
                Console.WriteLine("For End enter '0'");
                Console.Write("Your choice is: ");
                choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        Console.Clear();
                        Console.WriteLine("Enter word");
                        word = Console.ReadLine();
                        Console.WriteLine();
                        if (!InterpretationDictionary.ContainsKey(word))
                        {
                            Console.WriteLine("Enter word interpretation");
                            InterpretationDictionary.Add(word, Console.ReadLine());
                            Console.WriteLine("Enter word cynonymous");
                            СynonymousDictionary.Add(word, Console.ReadLine());
                            Console.WriteLine("Enter word in English");
                            EnglishDictionary.Add(word, Console.ReadLine());
                            Console.WriteLine();
                        }
                        else
                        {
                            Console.Clear();
                            Console.WriteLine("This word already exists in dictionary !\n");
                        }
                        break;

                    case "2":
                        Console.Clear();
                        Console.WriteLine("Enter word");
                        word = Console.ReadLine();
                        Console.WriteLine();
                        if (InterpretationDictionary.ContainsKey(word))
                        {
                            Console.WriteLine("The Interpretation of word is: {0}", InterpretationDictionary[word]);
                            Console.WriteLine("The Cynonymous of word is: {0}", СynonymousDictionary[word]);
                            Console.WriteLine("Word in english: {0}", EnglishDictionary[word]);
                            Console.WriteLine();
                        }
                        else
                        {
                            Console.Clear();
                            Console.WriteLine("This word is not exist in dictionary !\n");
                        }
                        break;

                    case "0": Console.WriteLine("Good bye !!!"); return;
                    default: Console.WriteLine("You Entered Invalid choice !");
                        break;
                }
            }
        }

    }
}
