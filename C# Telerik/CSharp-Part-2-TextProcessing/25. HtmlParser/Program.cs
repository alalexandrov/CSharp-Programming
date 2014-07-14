using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _25.HtmlParser
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                //Reading all text from html file
                StreamReader reader = new StreamReader("..\\..\\Home.html");
                string HtmlText = "";
                using (reader)
                {
                    HtmlText = reader.ReadToEnd();
                }

                //Getting text without the tags
                Regex regex = new Regex("(<.*?>\\s*)+", RegexOptions.Singleline);
                string resultText = regex.Replace(HtmlText, " ").Trim();

                //Printing it to the console
                Console.OutputEncoding = Encoding.UTF8;
                Console.WriteLine("Text without tags from HTML.xml is:");
                Console.WriteLine(resultText);

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
