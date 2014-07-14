using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _24.SortingGivenWords
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter words separated by spaces");
            string input = Console.ReadLine();

            //Getting words
            string[] words = input.Split(' ');
            Array.Sort(words);

            //Printing words in alphabetical order
            Console.WriteLine("\nWords in alphabetical order\n");
            foreach (var word in words)
            {
                Console.WriteLine(word);
            }
        }
    }
}
