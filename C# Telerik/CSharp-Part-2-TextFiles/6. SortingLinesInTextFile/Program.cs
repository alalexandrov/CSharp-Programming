using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6.SortingLinesInTextFile
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                //Read text file line by line and adding them to list
                StreamReader reader = new StreamReader("..\\..\\Names.txt");

                List<string> TextLines = new List<string>();
                using (reader)
                {
                    string TextLine = reader.ReadLine();
                    while (TextLine != null)
                    {
                        TextLines.Add(TextLine);
                        TextLine = reader.ReadLine();
                    }
                }

                //Sort list and write data to another text file
                TextLines.Sort();

                StreamWriter writer = new StreamWriter("..\\..\\NamesSorted.txt");
                using (writer)
                {
                    foreach (var line in TextLines)
                    {
                        writer.WriteLine(line);
                    }
                }

                Console.WriteLine("The items are sorted successfully !");

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            
        }
    }
}
