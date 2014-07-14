using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _10.XMLParser
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                //Reading all text from xml file
                StreamReader reader = new StreamReader("..\\..\\XML.xml");
                string XmlText = "";
                using (reader)
                {
                    XmlText = reader.ReadToEnd();
                }

                //Getting text without the tags
                Regex regex = new Regex("(<.*?>\\s*)+", RegexOptions.Singleline);
                string resultText = regex.Replace(XmlText, " ").Trim();

                //Printing it to the console
                Console.WriteLine("The text without tags from XML.xml is:");
                Console.WriteLine(resultText);

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            
        }
    }
}
