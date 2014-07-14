using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WordToUpper
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = "Alexander <up>obicha</up> portokali ! Alexander obicha <up>qbulki</up>";
            string StartTag = "<up>";
            string EndTag = "</up>";
            while (text.IndexOf(StartTag) != -1 && text.IndexOf(EndTag) != -1)
            {
                int StartIndex = text.IndexOf(StartTag);
                int EndIndex = text.IndexOf(EndTag);
                string WordInTag = text.Substring(StartIndex + StartTag.Length, (EndIndex - StartIndex) - StartTag.Length);
                string WordWithTags = StartTag + WordInTag + EndTag;
                text = text.Replace(WordWithTags, WordInTag.ToUpper());
            }
            Console.WriteLine(text);
        }
    }
}
