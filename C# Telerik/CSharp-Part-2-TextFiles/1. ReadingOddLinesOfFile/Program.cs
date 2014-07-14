using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.ReadingOddLinesOfFile
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                StreamReader reader = new StreamReader("..\\..\\Text.txt");

                Console.WriteLine("Printing text...\n");

                //Reading file and printing them to console
                using (reader)
                {
                    Console.WriteLine(reader.ReadToEnd());
                }

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

        }
    }
}
