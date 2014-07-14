using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10.StringToUnicodeConvert
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = "Hi!";
            StringBuilder output = new StringBuilder();

            //Getting sequence of C# Unicode character literals
            for (int i = 0; i < text.Length; i++)
            {
                output.Append("\\" + ((int)text[i]).ToString("X").PadLeft(4, '0'));
            }

            Console.WriteLine(text);
            Console.WriteLine("Output: {0}", output);
        }
    }
}
