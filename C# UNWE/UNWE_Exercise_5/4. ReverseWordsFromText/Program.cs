using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter text: ");
            string text = Console.ReadLine();
            char [] separators  = {' ',',','.','!','?'};
            string[] TextWords = text.Split(separators, StringSplitOptions.RemoveEmptyEntries);
            Stack<string> OutputWords = new Stack<string>();
            foreach (var item in TextWords)
            {
                OutputWords.Push(item);
            }

            Console.WriteLine();
            Console.Write("The result is: ");
            while (OutputWords.Count > 0)
            {
                Console.Write("{0} ", OutputWords.Pop());
            }
            Console.WriteLine();
        }
    }
}
