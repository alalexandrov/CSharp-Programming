using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5.StringToUpperTagParse
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = @"We are living in a <upcase>yellow submarine</upcase>. We don't have <upcase>anything</upcase> else.";
            string startTag = "<upcase>";
            string endTag = "</upcase>";

            //Replace words in tag <upcase> with same words in upper-case
            int startIndex = text.IndexOf(startTag);
            int endIndex = text.IndexOf(endTag);

            while (startIndex != -1 && endIndex != -1)
            {
                string SubstrWithTags = text.Substring(startIndex, endIndex - startIndex + endTag.Length);

                string TagText = ExtractTagText(SubstrWithTags);

                text = text.Replace(SubstrWithTags, TagText.ToUpper());

                startIndex = text.IndexOf(startTag);
                endIndex = text.IndexOf(endTag);
            }

            Console.WriteLine(text);
        }

        public static string ExtractTagText(string text)
        {
            //Remove start Tag            
            int StartTagEndIndex = text.IndexOf(">");
            text = text.Remove(0, StartTagEndIndex + 1);

            //Remove end tag
            int EndTagStartIndex = text.IndexOf("<");
            text = text.Remove(EndTagStartIndex, text.Length - EndTagStartIndex);

            return text;
        }
    }
}
