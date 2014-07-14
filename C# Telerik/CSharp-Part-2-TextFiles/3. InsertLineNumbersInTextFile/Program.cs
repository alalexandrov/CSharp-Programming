using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3.InsertLineNumbersInTextFile
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                StreamReader reader = new StreamReader("..\\..\\Text.txt");
                StreamWriter writer = new StreamWriter("..\\..\\Result.txt");
                int LineNum = 1;

                //Reading file line by line and appending each line with line number to another file
                using (writer)
                {
                    using (reader)
                    {
                        string LineText = reader.ReadLine();
                        while (LineText != null)
                        {
                            writer.WriteLine(LineNum + ". " + LineText);
                            LineText = reader.ReadLine();
                            LineNum++;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            
        }
    }
}
