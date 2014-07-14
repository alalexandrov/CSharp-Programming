using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9.DeleteOddLinesFromTextFile
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                //Reading text file line by line and adding only even lines to stringbuilder
                StreamReader reader = new StreamReader("..\\..\\Text4.txt");
                StringBuilder EvenTextLines = new StringBuilder();

                using (reader)
                {
                    string Line = reader.ReadLine();
                    int LineNum = 1;


                    while (Line != null)
                    {
                        if (LineNum % 2 != 0)
                        {
                            EvenTextLines.AppendLine(Line);
                        }
                        Line = reader.ReadLine();
                        LineNum++;
                    }
                }

                //Writing output to same file
                StreamWriter writer = new StreamWriter("..\\..\\Text4.txt");

                using (writer)
                {
                    writer.WriteLine(EvenTextLines);
                }

                Console.WriteLine("Odd lines was removed from file !");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            
        }
    }
}
